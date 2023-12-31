﻿using SeasonalFoods.Enums;

namespace SeasonalFoods.Components;

public class FoodItemDto
{
    public string Name { get; set; } = string.Empty;
    public string FoodGroup { get; set; } = string.Empty;
    public HistoricalData HistoricalData { get; set; } = new();
}

public class HistoricalData
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Region { get; set; }
    public string? ShopPlaces { get; set; } 
    public string? Sector { get; set; } = string.Empty;
    public double? MinimalPrice { get; set; }
    public int? AveragePrice { get; set; }
    public double? MaximumPrice { get; set; }
    public string? Variety { get; set; }
    public string? Date { get; set; } = string.Empty;
}