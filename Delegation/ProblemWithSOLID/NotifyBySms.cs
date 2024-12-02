namespace Delegation.ProblemWithSOLID;

public class NotifyBySms : INotifyMethod
{
    public void Notify(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }
}