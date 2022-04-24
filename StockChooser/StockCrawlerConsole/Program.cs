// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using StockChooserConsole;

Console.WriteLine("Hello, World!");

var crawler = new Crawler();
var content = await crawler.Craw();

foreach (var stock in content)
{
    Console.WriteLine($"{stock.CommKey} {stock.CommName}");
}