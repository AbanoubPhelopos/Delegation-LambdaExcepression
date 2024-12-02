using System;

public class AdvancedDelegatePatterns
{
    // Event pattern using delegates
    public class Publisher
    {
        // Define a delegate for the event
        public delegate void DataChangedEventHandler(object sender, DataChangedEventArgs e);
        
        // Define the event using the delegate
        public event DataChangedEventHandler DataChanged;

        private string _data;
        public string Data
        {
            get => _data;
            set
            {
                if (_data != value)
                {
                    _data = value;
                    OnDataChanged(new DataChangedEventArgs(value));
                }
            }
        }

        protected virtual void OnDataChanged(DataChangedEventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }
    }

    public class DataChangedEventArgs : EventArgs
    {
        public string NewValue { get; }
        public DataChangedEventArgs(string newValue)
        {
            NewValue = newValue;
        }
    }

    // Generic delegate example
    public delegate T Operation<T>(T x, T y);

    public static void Run()
    {
        // Event pattern demonstration
        Console.WriteLine("Event Pattern Example:");
        var publisher = new Publisher();
        publisher.DataChanged += (sender, e) => 
            Console.WriteLine($"Data changed to: {e.NewValue}");

        publisher.Data = "Hello";
        publisher.Data = "World";

        // Generic delegate demonstration
        Console.WriteLine("\nGeneric Delegate Example:");
        Operation<int> add = (x, y) => x + y;
        Operation<string> concat = (x, y) => x + y;

        Console.WriteLine($"Add numbers: {add(5, 3)}");
        Console.WriteLine($"Concat strings: {concat("Hello ", "World")}");

        // Func composition example
        Console.WriteLine("\nDelegate Composition Example:");
        Func<int, int> double1 = x => x * 2;
        Func<int, int> addOne = x => x + 1;
        
        // Composing functions
        Func<int, int> doubleAndAddOne = x => addOne(double1(x));
        Console.WriteLine($"Double and add one to 5: {doubleAndAddOne(5)}");
    }
}