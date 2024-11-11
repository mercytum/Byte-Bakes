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
      _context.Subscribers.Add(subscriber);
      _context.SaveChanges();
    }
}