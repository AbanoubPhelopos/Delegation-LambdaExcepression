namespace Delegation.ProblemWithSOLID;

public static class NotificationHandler
{
    public static void SendNotification(INotifyMethod method, string message)
    {
        method.Notify(message);
    }
}