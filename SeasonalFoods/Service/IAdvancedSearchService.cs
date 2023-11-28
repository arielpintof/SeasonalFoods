namespace SeasonalFoods.Service;

public interface IAdvancedSearchService
{
    Task<HttpResponseMessage?> GetFood
        (int year, int? region, int? category, int? quality, int? store);
}