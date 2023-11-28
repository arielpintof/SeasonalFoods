namespace SeasonalFoods.Service;

public interface IFoodService
{
    Task<HttpResponseMessage?> GetFood(string name, string quality, string region);

    Task<HttpResponseMessage?> GetFoodByWeekRange(
        string name, string quality, string region, string storeType, string year, int week);

    Task<HttpResponseMessage?> GetFoodByDate(
        string name, string quality, string region, string storeType, DateTime date);
    
}