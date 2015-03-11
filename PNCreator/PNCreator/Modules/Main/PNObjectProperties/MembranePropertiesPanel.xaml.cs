using System.Windows;
using System.Windows.Controls;
using PNCreator.ManagerClasses.MeshPicker;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Main.PNObjectProperties
{
    public partial class MembranePropertiesPanel : IPNObjectProperties
    {
        public MembranePropertiesPanel()
        {
            InitializeComponent();
        }

        private void CoveredObjectsComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox coveredObjectsCb = (ComboBox)sender;
            if (coveredObjectsCb.SelectedItem != null)
            {
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                PNObject pnObject = (PNObject)coveredObjectsCb.SelectedItem;
                PNObjectPicker objectPicker = mainWindow.pnObjectPicker;
                objectPicker.SelectedObject = pnObject;
                mainWindow.pnViewport.SetCameraPosition(pnObject.Position);
                //mainWindow.ShowSelectedObjectProperties(pnObject)
            }
        }

        public void SetPNObject(PNObject pnObject)
        {
            if (pnObject.Type == PNObjectTypes.Membrane)
            {
                SetMembraneSpeedDataVisibility(Visibility.Collapsed);
            }
            else
            {
                SetMembraneSpeedDataVisibility(Visibility.Visible);
            }
        }

        private void SetMembraneSpeedDataVisibility(Visibility visibility)
        {
            speedLabel.Visibility = visibility;
            speedTB.Visibility = visibility;
            formulaBtn.Visibility = visibility;
        }

        public void PopulateCoveredObjectsComboBox(Membrane membrane)
        {
            CoveredObjectsComboBox.ItemsSource = membrane.PNObjects;
        }
    }
}
