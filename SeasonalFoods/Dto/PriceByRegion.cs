using System.Text.Json.Serialization;

namespace SeasonalFoods.Dto;

public class PriceByRegion
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("region")]
    public string Region { get; set; } = string.Empty;
    
    [JsonPropertyName("point_type")]
    public string ShopPlace { get; set; } = string.Empty;
    
    [JsonPropertyName("quality")]
    public string Quality { get; set; } = string.Empty;
    
    [JsonPropertyName("history")] private ICollection<History>? History { get; set; }
}