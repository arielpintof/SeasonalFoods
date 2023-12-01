using Fluxor;

namespace SeasonalFoods.Store.AdvancedSearch;

public static class FoodReducer
{
    [ReducerMethod]
    public static FoodState UpdateFoodState(FoodState state, LoadFoodAction action)
    {
        return new FoodState(action.FoodSummarizeds);
    }
}