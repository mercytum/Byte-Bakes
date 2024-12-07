using Microsoft.AspNetCore.Mvc;

public class NewsletterController : Controller
{
    private readonly NewsletterService _newsletterService;

    public NewsletterController(NewsletterService newsletterService)
    {
      _newsletterService = newsletterService;
    }

    [HttpPost]
    public IActionResult Subscribe(string email)
    {
      
      if (string.IsNullOrWhiteSpace(email))
    {
        TempData["SubscriptionMessage"] = "Email is required.";
        return Redirect(Request.Headers["Referer"].ToString());
    }

    var subscriber = new Subscriber { Email = email};

    try
    {
      //Add the subscriber to the database
      _newsletterService.AddSubscriberToDb(subscriber);

      //Add the subscriber to our Observer Pattern
      _newsletterService.Subscribe(subscriber);

      // Redirect back to the current view with a success message
      TempData["SubscriptionMessage"] = "Subscription Successful!";
    }
    catch (Exception ex)
    {
        TempData["SubscriptionMessage"] = $"Error saving subscriber: {ex.Message}";
    }
      
      // Redirect back to the referring page
    string refererUrl = Url.Action("Index", "Home") + "#SubscribeSection";

    return Redirect(refererUrl);
    }

    [HttpPost]
    public IActionResult Alert(string message)
    {
        _newsletterService.AlertSubscribers(message);
        return Ok("Notification sent to all subscribers");

    }
}