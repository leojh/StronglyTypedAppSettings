using System;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace LeoJH.StronglyTypedAppSettings
{
    public class SettingsScanner : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            if (!type.Name.EndsWith("Settings")) return;

            registry.For(type).LifecycleIs(InstanceScope.Singleton).Use(
                c => c.GetInstance<AppSettingsProvider>().PopulateAllPublicPropertiesForTypeWithItsCorrespondingAppConfigValue(type));
        }
    }
}