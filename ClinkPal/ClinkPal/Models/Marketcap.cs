using System.Text.Json.Serialization;

namespace ClinkPal.Models;

public class Marketcap
{
    [JsonPropertyName("rank")] public int Rank { get; set; }
    [JsonPropertyName("liquid_marketcap_usd")] public double? LiquidMarketCapUSD { get; set; }
}