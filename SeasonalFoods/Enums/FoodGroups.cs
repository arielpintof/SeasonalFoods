using Ardalis.SmartEnum;

namespace SeasonalFoods.Enums;

public class FoodGroups : SmartEnum<FoodGroups>, IEnum<FoodGroups, FoodGroupToken>
{
    public static readonly FoodGroups None =
        new(nameof(None), (int)FoodGroupToken.None, string.Empty);
    
    public static readonly FoodGroups Fruits =
        new(nameof(Fruits), (int)FoodGroupToken.Fruits, "Frutas");

    public static readonly FoodGroups Vegetables =
        new(nameof(Vegetables), (int)FoodGroupToken.Vegetables, "Vegetales");

    public static readonly FoodGroups Seeds =
        new(nameof(Seeds), (int)FoodGroupToken.Seeds, "Semillas");
    
    public static readonly FoodGroups Grains =
        new(nameof(Grains), (int)FoodGroupToken.Grains, "Granos");
    
    public static readonly FoodGroups Meats =
        new(nameof(Meats), (int)FoodGroupToken.Meats, "Carnes");
    private FoodGroups(string name, int value, string readableName) :
        base(name, value)
    {
        ReadableName = readableName;
    }

    public string ReadableName { get; }
    
}

public enum FoodGroupToken
{
    None,
    Fruits,
    Vegetables,
    Grains,
    Seeds, 
    Meats 
}
