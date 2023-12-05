namespace SeasonalFoods.Service;

public interface IAdvancedSearchService
{
    Task<HttpResponseMessage?> GetFood
        (int year, int? region, int? category, int? quality, int? store);

    Task<HttpResponseMessage?> GetFoodHistoryLastWeeks(int region, string foodName, int quality);

    Task<HttpResponseMessage?> GetFoodRegionHistory(string foodName, int quality);

    Task<HttpResponseMessage?> GetSeasonalFoodByRegion(int region);



}