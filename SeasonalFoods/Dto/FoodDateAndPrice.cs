namespace SeasonalFoods.Dto;

public class FoodDateAndPrice
{
    public DateTime Date { get; set; }
    public int Week { get; set; }
    public float MeanPrice { get; set; }
}