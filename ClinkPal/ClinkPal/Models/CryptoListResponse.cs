namespace ClinkPal.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;
public class CryptoListResponse
{
    [JsonPropertyName("data")] public List<Crypto> Cryptos { get; set; }
    [JsonPropertyName("status")] public Status Status { get; set; }
}