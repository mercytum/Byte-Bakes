public interface INewsletterSubject
{
  void Subscribe(ISubscriber subscriber);
  void Unsubscribe(ISubscriber subscriber);
  void AlertSubscribers(string message);
}