using Ardalis.SmartEnum;

namespace SeasonalFoods.Enums;

public class Qualities : SmartEnum<Qualities>, IEnum<Qualities, QualityToken>
{
    public static readonly Qualities None = 
        new(nameof(None), (int)QualityToken.None, string.Empty);
    
    public static readonly Qualities First = 
        new(nameof(First), (int)QualityToken.First, "Primera");
    
    public static readonly Qualities Second = 
        new(nameof(Second), (int)QualityToken.Second, "Segunda");
    
    private Qualities(string name, int value, string readableName) : base(name, value)
    {
        ReadableName = readableName;
        
    }

    public string ReadableName { get; }
}

public enum QualityToken
{
    None,
    First,
    Second
}