using Comman.Performance;
using DIP.Use;


Console.WriteLine("=== Dependency Inversion Principle (DIP) Demo ===\n");

//  Without DIP
Console.WriteLine(" Without DIP (Bad Example):");
var oldManager = new DIP.Not_Use.UserManager();
oldManager.CreateUser("Hajikhan");

//  With DIP
Console.WriteLine("\n With DIP (Good Example):");

// Inject SQL repo
IUserRepository sqlRepo = new SqlUserRepository();
var sqlManager = new DIP.Use.UserManager(sqlRepo);
sqlManager.CreateUser("Hajikhan");

// Inject Mongo repo
IUserRepository mongoRepo = new MongoUserRepository();
var mongoManager = new DIP.Use.UserManager(mongoRepo);
mongoManager.CreateUser("User");




// ---------------- PERFORMANCE TESTS ----------------
Console.WriteLine("\n=== Performance Tests ===");

// Results storage for table
var results = new List<(string Test, double TimeMs)>();

// Without DIP performance
PerformanceTester.MeasureTime(() =>
{
    oldManager.CreateUser("PerfUser_NotUse");
}, "NotUse: Single Save", results);

PerformanceTester.RunBenchmark("NotUse: Bulk Save", () =>
{
    oldManager.CreateUser("PerfUser_NotUse_Bulk");
}, iterations: 10, results);

// With DIP - SQL
PerformanceTester.MeasureTime(() =>
{
    sqlManager.CreateUser("PerfUser_SQL");
}, "Use (SQL): Single Save", results);

PerformanceTester.RunBenchmark("Use (SQL): Bulk Save", () =>
{
    sqlManager.CreateUser("PerfUser_SQL_Bulk");
}, iterations: 10, results);

// With DIP - Mongo
PerformanceTester.MeasureTime(() =>
{
    mongoManager.CreateUser("PerfUser_Mongo");
}, "Use (Mongo): Single Save", results);

PerformanceTester.RunBenchmark("Use (Mongo): Bulk Save", () =>
{
    mongoManager.CreateUser("PerfUser_Mongo_Bulk");
}, iterations: 10, results);

Console.WriteLine("\n=== Performance Tests Complete ===");

// ---------------- PRINT COMPARISON TABLE ----------------
Console.WriteLine("\n=== Performance Comparison Table ===");
Console.WriteLine("| Test Case              | Time (ms) |");
Console.WriteLine("|------------------------|-----------|");

foreach (var r in results)
{
    Console.WriteLine($"| {r.Test,-22} | {r.TimeMs,9:F3} |");
}

Console.WriteLine("\n=== End of Demo ===");


Console.ReadLine();