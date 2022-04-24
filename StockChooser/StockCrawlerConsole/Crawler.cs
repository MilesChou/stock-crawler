using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace StockChooserConsole;

public class Crawler
{
    private static readonly HttpClient Client = new();

    /**
     * curl -X POST -d 'action=GetShareholdingDetails&stockId=0050' https://www.cmoney.tw/etf/ashx/e210.ashx
     */
    public static async Task<List<Stock>?> Craw(string stockId)
    {
        var request = new HttpRequestMessage(
            HttpMethod.Post,
            "https://www.cmoney.tw/etf/ashx/e210.ashx"
        );

        request.Content = new StringContent(
            $"action=GetShareholdingDetails&stockId={stockId}",
            Encoding.UTF8,
            "application/x-www-form-urlencoded"
        );

        var response = await Client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var responseContent = response.Content;

        var root = await responseContent.ReadFromJsonAsync<Root>();

        return root?.Data;
    }
}