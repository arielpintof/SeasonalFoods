namespace SeasonalFoods.Dto;

public class FoodSummarized
{
    public string ProductName { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public float Price { get; set; }
    public string PointType { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}