using SeasonalFoods.Enums;

namespace SeasonalFoods.Components;

public class FiltersDto
{
    public Seasons Season { get; set; } = null!;
    public IEnumerable<string> FoodGroups { get; set; } = new List<string>();
    public Regions Region { get; set; } = null!;
    public IEnumerable<string> ShopPlace { get; set; } = new List<string>();
    
}