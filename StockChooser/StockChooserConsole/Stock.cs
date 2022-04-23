using System.Text.Json.Serialization;

namespace StockChooserConsole;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public record Stock
{
    [JsonPropertyName("Date")] public DateTime Date { get; set; }

    [JsonPropertyName("CommKey")] public string CommKey { get; set; }

    [JsonPropertyName("CommName")] public string CommName { get; set; }

    [JsonPropertyName("Type")] public string Type { get; set; }

    [JsonPropertyName("Weights")] public double Weights { get; set; }

    [JsonPropertyName("Value")] public int Value { get; set; }

    [JsonPropertyName("Unit")] public string Unit { get; set; }

    [JsonPropertyName("Amount")] public double Amount { get; set; }

    [JsonPropertyName("Currency")] public string Currency { get; set; }
}

public class Root
{
    [JsonPropertyName("Data")] public List<Stock> Data { get; set; }

    [JsonPropertyName("Date")] public string Date { get; set; }
}