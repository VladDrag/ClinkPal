using System.Text.Json.Serialization;

namespace ClinkPal.Models;

public class Supply
{
    [JsonPropertyName("annual_inflation_percent")] public double? AnnualInflationPercent { get; set; }
}