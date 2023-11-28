using System.Text;

namespace SeasonalFoods.Service;

public class AdvancedSearchService : IAdvancedSearchService
{
    private readonly HttpClient _httpClient;

    public AdvancedSearchService(HttpClient httpClient)
    {
        _httpClient = httpClient;
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
}