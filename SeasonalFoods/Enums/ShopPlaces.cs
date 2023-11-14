using Ardalis.SmartEnum;

namespace SeasonalFoods.Enums;

public class ShopPlaces : SmartEnum<ShopPlaces>, IEnum<ShopPlaces, ShopPlacesToken>
{
    public static readonly ShopPlaces None =
        new(nameof(None), (int)ShopPlacesToken.None, "");
    
    public static readonly ShopPlaces Market =
        new(nameof(Market), (int)ShopPlacesToken.Market, "Feria Libre");
    
    public static readonly ShopPlaces Butchery =
        new(nameof(Butchery), (int)ShopPlacesToken.Butchery, "Carnicería");
    
    public static readonly ShopPlaces Bakery =
        new(nameof(Bakery), (int)ShopPlacesToken.Bakery, "Panadería");
    
    public ShopPlaces(string name, int value, string readableName) : base(name, value)
    {
        ReadableName = readableName;
    }

    public string ReadableName { get; }
}

public enum ShopPlacesToken
{
    None,
    Market,
    Butchery,
    Bakery
}