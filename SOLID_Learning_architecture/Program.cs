using Comman.Models;
using System.Diagnostics;

class Program()
{
    static void Main()
    {
        // === Demo: SRP Not Use ===
        Console.WriteLine("=== SRP Not Use Demo ===");
        var badManager = new SRP.NotUse.UserManager();
        MeasureTime(() =>
        {
            badManager.AddUser(new User { Name = "Bob" });
            badManager.AddUser(new User { Name = "" });
        });

        // === Demo: SRP Use ===
        Console.WriteLine("\n=== SRP Use Demo ===");
        var goodManager = new SRP.Use.UserManager();
        MeasureTime(() =>
        {
            goodManager.AddUser(new User { Name = "Alice" });
            goodManager.AddUser(new User { Name = "" });
        });

        // === Performance: 10 Runs ===
        Console.WriteLine("\n=== Performance Benchmark: 10 Runs ===");

        MeasureTime(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                badManager.AddUser(new User { Name = "Test" });
            }
        }, "SRP Not Use 10 runs");

        MeasureTime(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                goodManager.AddUser(new User { Name = "Test" });
            }
        }, "SRP Use 10 runs");

        Console.ReadLine();
    }

    static void MeasureTime(Action action, string label = "Time taken")
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        Console.WriteLine($"{label}: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
}