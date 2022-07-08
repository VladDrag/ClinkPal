using System.Text.Json.Serialization;

namespace ClinkPal.Models;

public class Metrics
{
    [JsonPropertyName("market_data")] public MarketData MarketData { get; set; }
    [JsonPropertyName("marketcap")] public Marketcap Marketcap { get; set; }
    [JsonPropertyName("supply")] public Supply Supply { get; set; }
}