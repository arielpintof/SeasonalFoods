using System.Runtime.InteropServices.JavaScript;

namespace SeasonalFoods.Dto;

public class History
{
    public DateTime Date { get; set; }
    public int Week { get; set; }
    public int Year { get; set; }
    public string Region { get; set; } = string.Empty;
    public string Sector { get; set; } = string.Empty;
    public string PointType { get; set; } = string.Empty;
    public string Variety { get; set; } = string.Empty;
    public string Quality { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
    public int MinPrice { get; set; }
    public float MeanPrice { get; set; }
    public int MaxPrice { get; set; }
    
}