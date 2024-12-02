namespace Delegation.ProblemWithSOLID;

public class NotifyByEmail : INotifyMethod
{
    public void Notify(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
    }
}