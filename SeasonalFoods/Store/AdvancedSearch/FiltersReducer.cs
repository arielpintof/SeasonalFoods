using System.Runtime.InteropServices.ComTypes;
using Fluxor;

namespace SeasonalFoods.Store.AdvancedSearch;


public class FiltersReducer
{
    [ReducerMethod]
    public static FilterState UpdateFilters(FilterState state, UpdateFilterAction action)
    {
        return new FilterState(action.Filters);
    }
        
    
    
}