using System.Net.Http.Json;
using Fluxor;
using SeasonalFoods.Pages;
using SeasonalFoods.Service;

namespace SeasonalFoods.Store.AdvancedSearch;


public class FilterEffects(IAdvancedSearchService advanceSearchSearch, IState<FilterState> filters)
{
    [EffectMethod(typeof(UpdateFilterAction))]
    public async Task SetFoodList(IDispatcher dispatcher)
    {
        var filterValue = filters.Value.Filters;
        var response = await advanceSearchSearch.GetFood(2023,
                filterValue.Region?.Value ?? null,
                filterValue.FoodGroups?.Value ?? null,
                filterValue.Qualities?.Value ?? null,
                filterValue.ShopPlace?.Value ??  null);
        
        var content = await response!.Content.ReadFromJsonAsync<List<Test.TemporalFood1>>();
        
        dispatcher.Dispatch(new LoadFoodAction(content));
    }
    
}