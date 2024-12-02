namespace Delegation;

public class EventNotifier
{
    public void NotifyByEmail(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
    }

    public static void NotifyBySms(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }

    public void SendNotification(string method, string message)
    {
        if (method == "Email")
            NotifyByEmail(message);
        else if (method == "SMS")
            NotifyBySms(message);
        else
            Console.WriteLine("Unsupported notification method");
    }
}