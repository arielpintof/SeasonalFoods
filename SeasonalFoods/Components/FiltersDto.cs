using SeasonalFoods.Enums;

namespace SeasonalFoods.Components;

public class FiltersDto
{
    public string Season { get; set; } = null!;
    public IEnumerable<string> FoodGroups { get; set; } = new List<string>();
    public string Region { get; set; } = null!;
    public IEnumerable<string> ShopPlace { get; set; } = new List<string>();
    
}