using ByteBakes.Data;

public class NewsletterService : INewsletterSubject
{
    private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();
    private readonly ApplicationDbContext _context;

    public NewsletterService(ApplicationDbContext context)
    {
      _context = context;
    }

    public void AlertSubscribers(string message)
    {
        foreach (var subscriber in _subscribers)
        {
          subscriber.Update(message);
        }
    }

    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }


    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    //Add subscriber to our database
    public void AddSubscriberToDb(Subscriber subscriber)
    {
          try
          {
              subscriber.TimeStamp = DateTime.UtcNow;
              _context.Subscribers.Add(subscriber);
              try
              {
                _context.SaveChanges();
              }
              catch (Exception ex)
              {
                  Console.WriteLine($"Error saving subscriber: {ex.Message}");
                  Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
                  throw;
              }
              
              Console.WriteLine("Subscriber added successfully.");
          }
        catch (Exception ex)
          {
              Console.WriteLine($"Error saving subscriber: {ex.Message}");
          } 
    }
}