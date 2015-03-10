using System;
using System.Windows;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Rules.Panels
{
    /// <summary>
    /// Interaction logic for PanelExpender.xaml
    /// </summary>
    public partial class PanelExpender
    {
        public static RulesPanel MainPanel = null;

        private string _expenderName;
        private bool _pnObjectExists = false;

        public RulesPropertiesPanelBase Panel { get; set; }

        public bool PNObjectExists
        {
            get { return _pnObjectExists; }
            set 
            {
                this.Red.Visibility = value ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        public string ExpenderName
        {
            get { return _expenderName; }
            set
            {
                if (value != null)
                {
                    _expenderName = value;
                    Expender.Header = _expenderName;
                }
            }
        }
        
        private PanelExpender()
        {
            InitializeComponent();
            Red.Visibility = Visibility.Collapsed;
        }                              

        public PanelExpender(PNObject pnObject)
            :this()
        {
            PNObjectExists = true;

            if (pnObject is Arc3D)
            {
                ExpenderName = TypeNamePairs.GetNameByType(typeof(Arc3D)) + " - " + pnObject.Name;
                Panel = new RulesArcPropertiesPanel((Arc3D)pnObject);
            }    
            else if (pnObject is Location)
            {
                ExpenderName = TypeNamePairs.GetNameByType(typeof(Location)) + " - " + pnObject.Name;
                Panel = new RulesLocationPropertiesPanel((Location)pnObject);
            }
            else if (pnObject is Membrane)
            {
                ExpenderName = TypeNamePairs.GetNameByType(typeof(Membrane)) + " - " + pnObject.Name;              
                Panel = new RulesMembranePropertiesPanel((Membrane)pnObject);
            }
            else if (pnObject is Transition)
            {
                ExpenderName = TypeNamePairs.GetNameByType(typeof(Transition)) + " - " + pnObject.Name;
                Panel = new RulesTransitionPropertiesPanel((Transition)pnObject);
            }
                    
            ExpenderStacklPanel.Children.Add(Panel);
        }

        private void DeleteExpenderButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (MainPanel != null)
                MainPanel.RemoveExpender(this);
        }
    }
}
