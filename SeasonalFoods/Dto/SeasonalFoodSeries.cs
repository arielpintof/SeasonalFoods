namespace SeasonalFoods.Dto;

public class SeasonalFoodSeries
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public List<FoodWeekAndPrice> Series { get; set; } = new();
}