using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace StockChooserConsole;

public class Crawler
{
    private static readonly HttpClient Client = new HttpClient();

    public async Task<List<Stock>?> Craw()
    {
        var request = new HttpRequestMessage(HttpMethod.Post, "https://www.cmoney.tw/etf/ashx/e210.ashx");

        request.Content = new StringContent("action=GetShareholdingDetails&stockId=0050", Encoding.UTF8, "application/x-www-form-urlencoded");

        var response = await Client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var responseContent = response.Content;

        var root = await responseContent.ReadFromJsonAsync<Root>();

        return root?.Data;
    }
}