using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meshes3D;
using PNCreator.ManagerClasses;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Commands
{
    class CopyPNObjectsCommand
    {
        private readonly PNDocument pnDocument;
        private const string FileName = "copyPNObjects.mpn";

        public CopyPNObjectsCommand()
        {
            pnDocument = App.GetObject<PNDocument>();
        }

        public void CopyPNObjects(ICollection<Meshes3D.Mesh3D> objects)
        {
            ICollection<PNObject> pnObjects = objects.OfType<PNObject>().ToList();

            if (pnObjects.Count == 1 && pnObjects.First() is Membrane)
                pnDocument.CopySelectedMembrane(FileName, (Membrane)pnObjects.First());
            else
                pnDocument.CopySelectedPnObjects(FileName, pnObjects);
        }
    }
}
