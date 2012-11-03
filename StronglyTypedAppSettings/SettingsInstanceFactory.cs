using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypedAppSettings
{
    public sealed class SettingsInstanceFactory
    {
        public T GetInstanceOfConfigSettings<T>() where T : class
        {
            return ObjectFactory.GetInstance<T>();
        }
    }
}
