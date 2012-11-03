using System;
using System.Configuration;
using System.Reflection;

namespace LeoJH.StronglyTypedAppSettings
{
    public class AppSettingsProvider
    {
        public object PopulateAllPublicPropertiesForTypeWithItsCorrespondingAppConfigValue(Type type)
        {
            var settingsInstace = Activator.CreateInstance(type);

            foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty))
            {
                var settingKey = string.Format("{0}.{1}", type.Name, property.Name);
                var settingValue = ConfigurationManager.AppSettings[settingKey];

                if (!string.IsNullOrEmpty(settingValue))
                {
                    property.SetValue(settingsInstace, settingValue, null);
                }
            }
            return settingsInstace;
        }
    }
}