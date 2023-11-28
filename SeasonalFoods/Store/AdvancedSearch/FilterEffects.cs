using Fluxor;
using SeasonalFoods.Dto;
using SeasonalFoods.Service;

namespace SeasonalFoods.Store.AdvancedSearch;


public class FilterEffects
{
    private readonly IAdvancedSearchService _advancedSearchSearch;
    private readonly IState<FilterState> _filters;
    public FilterEffects(IAdvancedSearchService advanceSearchSearch, IState<FilterState> filters)
    {
        _advancedSearchSearch = advanceSearchSearch;
        _filters = filters;
    }

    [EffectMethod]
    public async Task SetFoodList(IDispatcher dispatcher)
    {
        //Llamar a la api con los filtros de FilterState
        
        //Despachar un loadAction con la FoodListState
        dispatcher.Dispatch(new LoadFoodAction(new List<FoodSummarized>()));
    }
    
}