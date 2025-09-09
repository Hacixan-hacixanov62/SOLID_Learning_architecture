using Comman.Models;
using Comman.Performance;
using OCP.NotUse;
using OCP.Use;
using System.Diagnostics;

const int iterations = 10;

var badDiscount = new Discount();
PerformanceTester.RunBenchmark("Without OCP", () =>
{
    badDiscount.CalculateDiscount(new Customer { Name = "Alizamin", Type = "Regular" }, 100);
    badDiscount.CalculateDiscount(new Customer { Name = "Sadiq", Type = "VIP" }, 100);
}, iterations);

var discountManager = new DiscountManager();
PerformanceTester.RunBenchmark("With OCP", () =>
{
    discountManager.CalculateDiscount(new RegulerDiscount(), 100);
    discountManager.CalculateDiscount(new VipDiscount(), 100);
    discountManager.CalculateDiscount(new PremiumDiscount(), 100);
}, iterations);


Console.WriteLine("======= Without OCP ======");
var stopwatch = Stopwatch.StartNew();

var regularPriceBad = badDiscount.CalculateDiscount(new Customer { Name = "Alizamin", Type = "Regular" }, 100);
var vipPriceBad = badDiscount.CalculateDiscount(new Customer { Name = "Sadiq", Type = "VIP" }, 100);
Console.WriteLine($"Regular customer pays: {regularPriceBad}");
Console.WriteLine($"Vip customer pays: {vipPriceBad}");

stopwatch.Stop();
Console.WriteLine($"Time taken (Without OCP): {stopwatch.Elapsed.TotalMilliseconds} ms");


Console.WriteLine("======= With OCP ======");
stopwatch = Stopwatch.StartNew();

var regularPrice = discountManager.CalculateDiscount(new RegulerDiscount(), 100);
var vipPrice = discountManager.CalculateDiscount(new VipDiscount(), 100);
Console.WriteLine($"Regular customer pays: {regularPrice}");
Console.WriteLine($"VIP customer pays: {vipPrice}");

// ----------- Extend to Premium Without changing Any Code --------------//

var premiumPriceGood = discountManager.CalculateDiscount(new PremiumDiscount(), 100);
Console.WriteLine($"Premium Customer Pays L: {premiumPriceGood}");
stopwatch.Stop();
Console.WriteLine($"Time taken (With OCP): {stopwatch.Elapsed.TotalMilliseconds} ms");

Console.ReadLine();

















