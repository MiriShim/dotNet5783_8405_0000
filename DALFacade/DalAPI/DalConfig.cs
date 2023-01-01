namespace DalApi;

using DO;
using System.Xml.Linq;

static class DalConfig
{
    internal static string? s_dalName;
    internal static Dictionary<string, string> s_dalPackages;

    //בנאי סטטי
    static DalConfig()
    {
        XElement dalConfig = XElement.Load(@"..\xml\dal_config.xml")
            ?? throw new DalConfigException("dal_config.xml file is not found");

       string?  dalLayerName = dalConfig.Element("dal")?.Value ?? throw new DalConfigException("שגאה בגישה לקונפיג");

        s_dalName = dalConfig?.Element("dal")?.Value
            ?? throw new DalConfigException("<dal> element is missing");

        var packages = dalConfig?.Element("dal-packages")?.Elements()
            ?? throw new DalConfigException("<dal-packages> element is missing");
        s_dalPackages = packages.ToDictionary(p => "" + p.Name, p => p.Value);
    }
}
