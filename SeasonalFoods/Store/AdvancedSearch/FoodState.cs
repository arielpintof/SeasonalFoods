using Fluxor;
using SeasonalFoods.Dto;

namespace SeasonalFoods.Store.AdvancedSearch;

[FeatureState]
public class FoodState
{
    public ICollection<FoodSummarized> FoodSummarizeds { get; } = null!;

    public FoodState(ICollection<FoodSummarized> foodSummarizeds)
    {
        FoodSummarizeds = foodSummarizeds;
    }

    public FoodState()
    {
    }

    
}