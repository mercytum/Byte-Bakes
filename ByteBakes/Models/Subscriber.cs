public class Subscriber : ISubscriber
{
    public int Id { get; set; }
    public required string Email { get; set; }

    public DateTime TimeStamp { get; set; }

    public void Update(string message)
    {
      //TODO: send an email to this subscriber

      Console.WriteLine($"Email sent to {Email}: {message}");
    }
}