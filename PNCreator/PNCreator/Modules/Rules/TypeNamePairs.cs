using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Rules
{
    public static class TypeNamePairs
    {
        private static readonly List<KeyValuePair<Type, string>> objectTypeNamePairs = new List<KeyValuePair<Type, string>>();

        static TypeNamePairs()
        {            
            objectTypeNamePairs.Add(new KeyValuePair<Type, string>(typeof(Arc3D), "Arc"));
            objectTypeNamePairs.Add(new KeyValuePair<Type, string>(typeof(Location), "Location"));
            objectTypeNamePairs.Add(new KeyValuePair<Type, string>(typeof(Membrane), "Membrane"));
            objectTypeNamePairs.Add(new KeyValuePair<Type, string>(typeof(Transition), "Transition"));
        }

        public static string GetNameByType(Type pnObjectType)
        {
            return (from pair in objectTypeNamePairs where pair.Key == pnObjectType select pair.Value).FirstOrDefault();
        }

        public static Type GetTypeByName(string pnObjectNames)
        {
            return (from pair in objectTypeNamePairs where pair.Value == pnObjectNames select pair.Key).FirstOrDefault();
        }
    }
}
