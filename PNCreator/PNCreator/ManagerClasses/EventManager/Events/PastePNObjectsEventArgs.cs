using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.ManagerClasses.EventManager.Events
{
    class PastePNObjectsEventArgs
    {
        public PNObjectDictionary<long, PNObject> PNObjects
        {
            get;
            set;
        }
    }
}
