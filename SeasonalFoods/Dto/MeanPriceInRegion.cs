namespace SeasonalFoods.Dto;

public class MeanPriceInRegion
{
    public string Region { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public int Week { get; set; }
    public float MeanPrice { get; set; }
}