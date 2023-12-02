using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;

namespace SeasonalFoods.Dto;

public class History
{
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }
    
    [JsonPropertyName("week")]
    public int Week { get; set; }
    
    [JsonPropertyName("mean_price")]
    public float MeanPrice { get; set; }
    
    [JsonPropertyName("max_price")]
    public int MaxPrice { get; set; }
    
    [JsonPropertyName("min_price")]
    public int MinPrice { get; set; }
    
} 