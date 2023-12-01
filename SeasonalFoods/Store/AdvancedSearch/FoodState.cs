using Fluxor;
using SeasonalFoods.Dto;
using SeasonalFoods.Pages;

namespace SeasonalFoods.Store.AdvancedSearch;

[FeatureState]
public class FoodState
{
    public List<Test.TemporalFood1> FoodSummarizeds { get; } = new();

    public FoodState(List<Test.TemporalFood1> foodSummarizeds)
    {
        FoodSummarizeds = foodSummarizeds;
    }

    public FoodState()
    {
    }

    
}