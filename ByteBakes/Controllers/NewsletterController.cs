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
      var subscriber = new Subscriber { Email = email };

      //Add the subscriber to the database
      _newsletterService.AddSubscriberToDb(subscriber);

      //Add the subscriber to our Observer Pattern
      _newsletterService.Subscribe(subscriber);

      

      return Ok("Subscription Successful");
    }

    [HttpPost]
    public IActionResult Alert(string message)
    {
        _newsletterService.AlertSubscribers(message);
        return Ok("Notification sent to all subscribers");

    }
}