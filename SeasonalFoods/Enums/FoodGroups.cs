using Ardalis.SmartEnum;

namespace SeasonalFoods.Enums;

public class FoodGroups : SmartEnum<FoodGroups>, IEnum<FoodGroups, FoodGroupToken>
{
    public static readonly FoodGroups None =
        new(nameof(None), (int)FoodGroupToken.None, string.Empty);
    
    public static readonly FoodGroups Fruits =
        new(nameof(Fruits), (int)FoodGroupToken.Fruits, "Frutas");

    public static readonly FoodGroups Vegetables =
        new(nameof(Vegetables), (int)FoodGroupToken.Vegetables, "Hortalizas");

    public static readonly FoodGroups Bovine =
        new(nameof(Bovine), (int)FoodGroupToken.Bovine, "Bovina");
    
    public static readonly FoodGroups Meat =
        new(nameof(Meat), (int)FoodGroupToken.Meat, "Carne");
    
    public static readonly FoodGroups Dairies =
        new(nameof(Dairies), (int)FoodGroupToken.Dairies, "Lácteos");
    
    public static readonly FoodGroups Bread =
        new(nameof(Bread), (int)FoodGroupToken.Bread, "Pan");
    
    public static readonly FoodGroups Groceries =
        new(nameof( Groceries), (int)FoodGroupToken. Groceries, "Abarrotes");
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
    Bovine,
    Meat,
    Dairies,
    Bread, 
    Groceries
}
