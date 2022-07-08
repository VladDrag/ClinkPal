using System.Text.Json.Serialization;

namespace ClinkPal.Models;

public class MarketData
{
    [JsonPropertyName("price_usd")] public double? PriceUSD { get; set; }
    [JsonPropertyName("price_btc")] public double? PriceBTC { get; set; }
    [JsonPropertyName("percent_change_usd_last_24_hours")] public double? PercentChangePerDay { get; set; }
}