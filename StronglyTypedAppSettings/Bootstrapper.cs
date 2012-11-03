using LeoJH.StronglyTypedAppSettings;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypedAppSettings
{
    public static class Bootstrapper
    {
        public static void InitializeStructureMap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.Convention<SettingsScanner>();
                });
            });
        }
    }
}
