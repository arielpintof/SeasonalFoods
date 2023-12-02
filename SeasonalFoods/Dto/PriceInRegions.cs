using System.Text.Json.Serialization;
using SeasonalFoods.Enums;

namespace SeasonalFoods.Dto;

public class PriceInRegions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    public string Region { get; set; } = string.Empty;
    [JsonPropertyName("point_type")]
    public string? ShopPlace { get; set; }
    public string Quality { get; set; } = string.Empty;
    public ICollection<History>? History { get; set; } 
}