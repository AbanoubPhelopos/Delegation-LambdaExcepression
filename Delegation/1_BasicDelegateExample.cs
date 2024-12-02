namespace Delegation;

// Step 1: Define a delegate type
public delegate void MessageDelegate(string message);

public class BasicDelegateExample
{
    // Method that matches the delegate signature
    public static void DisplayMessage(string message)
    {
        Console.WriteLine($"Regular method: {message}");
    }

    public static void Run()
    {
        // Problem: We want to make our code more flexible by passing behavior as a parameter
        // Solution: Use delegates to achieve this flexibility

        // Creating a delegate instance
        MessageDelegate messageHandler = DisplayMessage;

        // Using the delegate
        messageHandler("Hello from basic delegate!");

        // Adding another method to the delegate chain (multicast delegate)
        messageHandler += message => Console.WriteLine($"Lambda method: {message}");

        // This will call both methods
        messageHandler("This message will be displayed twice");
    }
}