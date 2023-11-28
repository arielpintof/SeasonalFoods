using SeasonalFoods.Dto;

namespace SeasonalFoods.Store.AdvancedSearch;

public class LoadFoodAction
{
    public ICollection<FoodSummarized> FoodSummarizeds { get; }

    public LoadFoodAction(ICollection<FoodSummarized> foodSummarizeds)
    {
        FoodSummarizeds = foodSummarizeds;
    }
}