using System.Text.Json.Serialization;

namespace ClinkPal.Models;

public class Crypto
{
    [JsonPropertyName("id")] public string Id { get; set; }
    [JsonPropertyName("symbol")] public string Symbol { get; set; }
    [JsonPropertyName("metrics")] public Metrics Metrics { get; set; }
}