namespace ClinkPal.Models;
using System.Text.Json.Serialization;

public class Status
{
    [JsonPropertyName("timestamp")] public string Date { get; set; }
}