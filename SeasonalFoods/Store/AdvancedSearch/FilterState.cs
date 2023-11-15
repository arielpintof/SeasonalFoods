using Fluxor;
using SeasonalFoods.Components;

namespace SeasonalFoods.Store.AdvancedSearch;

[FeatureState]
public class FilterState
{
    public FiltersDto Filters { get; }
    
    
    public FilterState(){}
    
    public FilterState(FiltersDto filters)
    {
        Filters = filters;
    }
}