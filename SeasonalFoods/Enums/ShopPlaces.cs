using Ardalis.SmartEnum;

namespace SeasonalFoods.Enums;

public class ShopPlaces : SmartEnum<ShopPlaces>, IEnum<ShopPlaces, ShopPlacesToken>
{
    public static readonly ShopPlaces None =
        new(nameof(None), (int)ShopPlacesToken.None, string.Empty);
    
    public static readonly ShopPlaces Butchery =
        new(nameof(Butchery), (int)ShopPlacesToken.Butchery, "Carnicería");
    
    public static readonly ShopPlaces Bakery =
        new(nameof(Bakery), (int)ShopPlacesToken.Bakery, "Panadería");
    
    public static readonly ShopPlaces Market =
        new(nameof(Market), (int)ShopPlacesToken.Fair, "Feria Libre");
    
    public static readonly ShopPlaces RetailMarket =
        new(nameof(RetailMarket), (int)ShopPlacesToken.RetailMarket, "Mercado minorista");
    
    public static readonly ShopPlaces WholesaleMarket =
        new(nameof(WholesaleMarket), (int)ShopPlacesToken.WholesaleMarket, "Mercado mayorista");
    
    public static readonly ShopPlaces SuperMarket =
        new(nameof(SuperMarket), (int)ShopPlacesToken.SuperMarket, "Supermercado");
    
    public ShopPlaces(string name, int value, string readableName) : base(name, value)
    {
        ReadableName = readableName;
    }

    public string ReadableName { get; }
}

public enum ShopPlacesToken
{
    None,
    Butchery,
    Bakery,
    Fair,
    RetailMarket,
    WholesaleMarket,
    SuperMarket
    
    
}