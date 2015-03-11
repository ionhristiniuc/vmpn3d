using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WindowsControl;
using PNCreator.ManagerClasses;
using PNCreator.ManagerClasses.EventManager;
using PNCreator.ManagerClasses.EventManager.Events;
using PNCreator.ManagerClasses.Exception;
using PNCreator.Properties;

namespace PNCreator.Commands
{
    class PastePNObjectsCommand
    {
        private const string FileName = "copyPNObjects.mpn";

        public void PastePNObjects()
        {
            try
            {
                var copiedPnObjects = App.GetObject<PNDocument>().PasteCopiedPnObjects(FileName);

                App.GetObject<EventPublisher>().ExecuteEvents(new PastePNObjectsEventArgs()
                {
                    PNObjects = copiedPnObjects
                });
            }
            catch (System.Xml.XmlException)
            {
                DialogWindow.Error(Messages.Default.WrongNetFileFormat);
            }
            catch (FormatException)
            {
                DialogWindow.Error(Messages.Default.WrongNetFileFormat);
            }
            catch (FileNotFoundException)
            {
                DialogWindow.Error(Messages.Default.FileNotFound);
            }
            catch (DirectoryNotFoundException)
            {
                DialogWindow.Error(Messages.Default.DirNotFound);
            }
            catch (Exception e)
            {
                ExceptionHandler.HandleException(e);
            }
         
        }
    }
}
