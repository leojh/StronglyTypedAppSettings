StronglyTypedAppSettings
========================

Use Dependency Injection to enable Strongly Typed Application Settings

CODE:
--------------------------------------------------------------------------
System.Console.WriteLine("The bad");
System.Console.WriteLine(ConfigurationManager.AppSettings["ConfigSettings.SampleSetting1"]);
System.Console.WriteLine(ConfigurationManager.AppSettings["ConfigSettings.SampleSetting2"]);

System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("The better"); 
var settings = new SettingsInstanceFactory().GetInstanceOfConfigSettings<ConfigSettings>();
System.Console.WriteLine(settings.SampleSetting1);
System.Console.WriteLine(settings.SampleSetting2);

OUTPUT:
--------------------------------------------------------------------------
The bad
My value for ConfigSettings.SampleSetting1
My value for ConfigSettings.SampleSetting2


The better
My value for ConfigSettings.SampleSetting1
My value for ConfigSettings.SampleSetting2
Press any key to continue . . .
