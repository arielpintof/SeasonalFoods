using Ardalis.SmartEnum;

namespace SeasonalFoods.Enums;

public class Regions : SmartEnum<Regions>, IEnum<Regions, RegionToken>
{
    public static readonly Regions None = 
        new(nameof(None), (int)RegionToken.None, string.Empty, string.Empty);

    public static readonly Regions AricaParinacota =
        new(nameof(AricaParinacota), (int)RegionToken.AricaParinacota, "Arica y Parinacota", "Región de Arica y Parinacota");

    public static readonly Regions Coquimbo =
        new(nameof(Coquimbo), (int)RegionToken.Coquimbo, "Coquimbo", "Región de Coquimbo");

    public static readonly Regions Valparaiso =
        new(nameof(Valparaiso), (int)RegionToken.Valparaiso, "Valparaíso", "Región de Valparaiso");

    public static readonly Regions Santiago =
        new(nameof(Santiago), (int)RegionToken.Santiago, "Metropolitana de Santiago", "Región Metropolitana de Santiago");
    
    public static readonly Regions Maule =
        new(nameof(Maule), (int)RegionToken.Maule, "Maule", "Región del Maule");

    public static readonly Regions Nuble =
        new(nameof(Nuble), (int)RegionToken.Nuble, "Ñuble", "Región de Ñuble");

    public static readonly Regions Biobio =
        new(nameof(Biobio), (int)RegionToken.Biobio, "Biobío", "Región del BioBio");

    public static readonly Regions Araucania =
        new(nameof(Araucania), (int)RegionToken.Araucania, "La Araucanía", "Región de la Araucanía");
    
    public static readonly Regions LosLagos =
        new(nameof(LosLagos), (int)RegionToken.LosLagos, "Los Lagos", "Región de los Lagos");
    

    private Regions(string name, int value, string completeName, string readableName) : base(name, value)
    {
        ReadableName = readableName;
        CompleteName = completeName;
    }

    public string CompleteName { get; }
    public string ReadableName { get; }
}

public enum RegionToken
{
    None,
    AricaParinacota,
    Coquimbo,
    Valparaiso,
    Santiago,
    Maule,
    Nuble,
    Biobio,
    Araucania,
    LosLagos,
}