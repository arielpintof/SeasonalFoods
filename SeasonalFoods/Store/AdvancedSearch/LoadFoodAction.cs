using SeasonalFoods.Dto;
using SeasonalFoods.Pages;

namespace SeasonalFoods.Store.AdvancedSearch;

public class LoadFoodAction
{
    public List<Test.TemporalFood1> FoodSummarizeds { get; }

    public LoadFoodAction(List<Test.TemporalFood1> foodSummarizeds)
    {
        FoodSummarizeds = foodSummarizeds;
    }
}