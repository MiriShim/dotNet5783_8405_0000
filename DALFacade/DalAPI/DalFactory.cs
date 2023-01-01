using DO;
using System.Reflection;
using static DalApi.DalConfig;

namespace DalAPI;

public static class Factory
{
    public static IDal? GetDal()
    {
        string dalType = DalApi.DalConfig. s_dalName  
            ?? throw new DalConfigException($"DAL name is not extracted from the configuration");
      
        string dal = s_dalPackages[dalType]
           ?? throw new DalConfigException($"Package for {dalType} is not found in packages list");
        Assembly asem;
        try
        {
             asem= Assembly.Load(dal ?? throw new DalConfigException($"Package {dal} is null"));
        }
        catch (Exception)
        {
            throw new DalConfigException("Failed to load {dal}.dll package");
        }
        //אפשר גם::
     //  Type? t = asem.GetType($"Dal.{dal}");

        Type? type = Type.GetType($"Dal.{dal}, {dal}")
            ?? throw new DalConfigException($"Class Dal.{dal} was not found in {dal}.dll");

        return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?
                   .GetValue(null) as IDal
            ?? throw new DalConfigException($"Class {dal} is not singleton or Instance property not found");
    }
}
