using Ardalis.SmartEnum;

namespace SeasonalFoods.Enums;

public class Seasons : SmartEnum<Seasons>, IEnum<Seasons, SeasonToken>
{
    public static readonly Seasons None = 
        new(nameof(None), (int)SeasonToken.None, string.Empty);

    public static readonly Seasons Summer =
        new(nameof(Summer), (int)SeasonToken.Summer, "Verano");
    
    public static readonly Seasons Winter =
        new(nameof(Winter), (int)SeasonToken.Winter, "Invierno");
    
    public static readonly Seasons Spring =
        new(nameof(Spring), (int)SeasonToken.Spring, "Privamera");
    
    public static readonly Seasons Autumn =
        new(nameof(Autumn), (int)SeasonToken.Autumn, "Otoño");

    public Seasons(string name, int value, string readableName) : base(name, value)
    {
        ReadableName = readableName;
        
    }
    
    public string ReadableName { get; }
}


public enum SeasonToken
{
    None = 0,
    Summer = 1,
    Winter = 2,
    Spring = 3,
    Autumn = 4
}