using Fluxor;

namespace SeasonalFoods.Store.AdvancedSearch;


public class FiltersReducer
{
    [ReducerMethod]
    public static FilterState UpdateFilters(FilterState state, UpdateFilterAction action) => 
        new FilterState(action.Filters);
    
    
}