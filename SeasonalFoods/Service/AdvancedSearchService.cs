using System.Text;

namespace SeasonalFoods.Service;

public class AdvancedSearchService : IAdvancedSearchService
{
    private readonly HttpClient _httpClient;

    public AdvancedSearchService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<HttpResponseMessage?> GetFoodHistoryLastWeeks(int region, string foodName, int quality)
    {
        return await _httpClient.GetAsync(
            $"seasonal-foods/api/v1/product/{foodName}/?region={region}&quality={quality}");
    }
    
    public async Task<HttpResponseMessage?> GetFoodRegionHistory(string foodName, int quality)
    {
        return await _httpClient.GetAsync(
            $"seasonal-foods/api/v1/per_region/product/{foodName}/?quality={quality}");
    }

    public async Task<HttpResponseMessage?> GetFood(int year, int? region, int? category, 
        int? quality, int? store)
    {
        var urlBuilder = new StringBuilder($"seasonal-foods/api/v1/foods_search/year/{year}");
        var queryParams = new List<string>();
        
        if (region.HasValue)
        {
            queryParams.Add($"region={region.Value}");
        }

        if (category.HasValue)
        {
            queryParams.Add($"category={category.Value}");
        }
        
        if (quality.HasValue)
        {
            queryParams.Add($"quality={quality.Value}");
        }

        if (store.HasValue)
        {
            queryParams.Add($"store={store.Value}");
        }
        
        if (queryParams.Count > 0)
        {
            urlBuilder.Append("?" + string.Join("&", queryParams));
        }
        
        return await _httpClient.GetAsync(urlBuilder.ToString());
    }

    public async Task<HttpResponseMessage?> GetSeasonalFoodByRegion(int region)
    {
        return await _httpClient.GetAsync(
            $"seasonal-foods/api/v1/foods_search/year/2023/?region={region}&in_season=true");
    }
}