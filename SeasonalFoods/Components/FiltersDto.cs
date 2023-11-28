using SeasonalFoods.Enums;

namespace SeasonalFoods.Components;

public class FiltersDto
{
    public Seasons Season { get; set; }
    public FoodGroups FoodGroups { get; set; } 
    public Regions Region { get; set; }
    public ShopPlaces ShopPlace { get; set; }
    
    public Qualities Qualities { get; set; }
    
}