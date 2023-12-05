using System.Text.Json.Serialization;
using SeasonalFoods.Enums;

namespace SeasonalFoods.Dto;

public class PriceInRegions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("region")]
    public string Region { get; set; } = string.Empty;
    [JsonPropertyName("point_type")]
    public string? ShopPlace { get; set; }
    
    [JsonPropertyName("quality")]
    public string Quality { get; set; } = string.Empty;
    
    [JsonPropertyName("unity")]
    public string Unit { get; set; } = string.Empty;
    
    [JsonPropertyName("history")]
    public ICollection<History>? History { get; set; } 
}