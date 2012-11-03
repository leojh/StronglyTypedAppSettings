using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypedAppSettings.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.InitializeStructureMap();

            System.Console.WriteLine("The bad");
            System.Console.WriteLine(ConfigurationManager.AppSettings["ConfigSettings.SampleSetting1"]);
            System.Console.WriteLine(ConfigurationManager.AppSettings["ConfigSettings.SampleSetting2"]);

            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("The better"); 
            var settings = new SettingsInstanceFactory().GetInstanceOfConfigSettings<ConfigSettings>();
            System.Console.WriteLine(settings.SampleSetting1);
            System.Console.WriteLine(settings.SampleSetting2);
        }
    }
}
