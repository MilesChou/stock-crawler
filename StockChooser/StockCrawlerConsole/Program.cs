// See https://aka.ms/new-console-template for more information

using StockChooserConsole;

Console.WriteLine("0050 成份股：");
Console.WriteLine("------------");

foreach (var stock in (await Crawler.Craw("0050"))!)
{
    Console.WriteLine($"{stock.CommKey} {stock.CommName} = {stock.Weights} %");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("0056 成份股：");
Console.WriteLine("------------");

foreach (var stock in (await Crawler.Craw("0056"))!)
{
    Console.WriteLine($"{stock.CommKey} {stock.CommName} = {stock.Weights} %");
}