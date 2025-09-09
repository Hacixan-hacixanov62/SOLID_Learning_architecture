using Comman.Performance;
using LSP.Not_Use;
using LSP.Use;

var rect = new Rectangle { Width=5,Height=10};
Console.WriteLine($"Rectangle Area: {rect.Area()}");

Rectangle square =new Square();
square.Width = 5;
square.Height = 10;
Console.WriteLine($"Square Area: {square.Area()}");



IShape IShaperect = new RectangleShape { Width=5,Height=10};
Console.WriteLine($"IShape Rectangle Area: {IShaperect.Area()}");

IShape IShapesquare = new SquareShape { Side=5};
Console.WriteLine($"IShape Square Area: {IShapesquare.Area()}");

IShape IShapescircle =new CircleShape { Radius=5};
Console.WriteLine($"Circle Area: {IShapescircle.Area()}");



/// ---------- Performance Testing -------------- ///

const int iterations = 10000000;
Console.WriteLine("=== LSP Performance Test ===");



// ---------- NotUse ----------
var badRect = new Rectangle { Width = 5, Height = 10 };
var badSquare = new Square { Width = 5, Height = 10 };

PerformanceTester.RunBenchmark("NotUse Rectangle", () =>
{
    var area = badRect.Area();
}, iterations);

PerformanceTester.RunBenchmark("NotUse Square", () =>
{
    var area = badSquare.Area();
}, iterations);



// ---------- Use ----------
IShape goodRect = new RectangleShape { Width = 5, Height = 10 };
IShape goodSquare = new SquareShape { Side = 5 };

PerformanceTester.RunBenchmark("Use RectangleShape", () =>
{
    var area = goodRect.Area();
}, iterations);

PerformanceTester.RunBenchmark("Use SquareShape", () =>
{
    var area = goodSquare.Area();
}, iterations);


Console.ReadLine();
