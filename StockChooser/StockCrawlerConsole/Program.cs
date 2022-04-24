// See https://aka.ms/new-console-template for more information

using StockChooserConsole;

Console.WriteLine("0050 成份股：");
Console.WriteLine("------------");

var first = await Crawler.Craw("0050");

foreach (var stock in first)
{
    Console.WriteLine($"{stock.CommKey} {stock.CommName} = {stock.Weights} %");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("0056 成份股：");
Console.WriteLine("------------");

var second = await Crawler.Craw("0056");

foreach (var stock in second)
{
    Console.WriteLine($"{stock.CommKey} {stock.CommName} = {stock.Weights} %");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("0050 x 0056");
Console.WriteLine("------------");

foreach (var stock in first.Intersect(second, new StockCompare()))
{
    Console.WriteLine($"{stock.CommKey} {stock.CommName}");
}
