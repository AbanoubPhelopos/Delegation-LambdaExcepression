using System;
using System.Collections.Generic;
using System.Linq;

public class LambdaExample
{
    public static void Run()
    {
        // Problem: Traditional delegates can be verbose
        // Solution: Lambda expressions provide a more concise syntax

        // Example with built-in delegates: Func and Action
        Func<int, int, int> add = (a, b) => a + b;
        Action<string> print = message => Console.WriteLine(message);

        Console.WriteLine($"Add numbers using lambda: {add(5, 3)}");
        print("Hello from lambda!");

        // LINQ with lambda expressions
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);
        var doubledNumbers = numbers.Select(n => n * 2);
        var sum = numbers.Aggregate((a, b) => a + b);

        Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
        Console.WriteLine($"Doubled numbers: {string.Join(", ", doubledNumbers)}");
        Console.WriteLine($"Sum of all numbers: {sum}");
    }
}