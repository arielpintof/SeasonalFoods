using SeasonalFoods.Components;

namespace SeasonalFoods.Store.AdvancedSearch;

public class UpdateFilterAction
{
    public FiltersDto Filters { get; }

    public UpdateFilterAction(FiltersDto filters)
    {
        Filters = filters;
    }
}