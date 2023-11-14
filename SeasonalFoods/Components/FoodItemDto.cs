using SeasonalFoods.Enums;

namespace SeasonalFoods.Components;

public class FoodItemDto
{
    public string Name { get; set; } = string.Empty;
    public string FoodGroup { get; set; } = string.Empty;
    public HistoricalData HistoricalData { get; set; } = new();
}

public class HistoricalData
{
    public Regions Region { get; set; } = null!;
    public ShopPlaces ShopPlaces { get; set; } = null!;
    public string Sector { get; set; } = string.Empty;
    public double MinimalPrice { get; set; }
    public double AveragePrice { get; set; }
    public double MaximumPrice { get; set; }
    public string? Variety { get; set; }
    public string Date { get; set; } = string.Empty;
}