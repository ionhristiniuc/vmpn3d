using System;
using System.Windows;
using System.Windows.Controls;
using PNCreator.ManagerClasses;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Rules.Panels
{
    /// <summary>
    /// Interaction logic for RulesMembranePropertiesPanel.xaml
    /// </summary>
    public partial class RulesMembranePropertiesPanel
    {           
        public RulesMembranePropertiesPanel(Membrane pnObject)
            : base(pnObject)
        {
            InitializeComponent();
    
            PanelPNObjectType = typeof(Membrane);

            if (PanelPNObject is StructuralMembrane)
            {
                SpeedTextBlock.Visibility = Visibility.Visible;
                SpeedTextBox.Visibility = Visibility.Visible;
            }            
        }

        public override void ExecuteChangtes()
        {            
            base.ExecuteChangtes();

            Membrane pnObject = (Membrane)PanelPNObject;

            if (PanelPNObject is StructuralMembrane)
                if (!string.IsNullOrWhiteSpace(SpeedTextBox.Text))
                    AttachFormula(SpeedTextBox, pnObject, FormulaTypes.Value);            

                ChangeValuesInObjectsPanel(SpeedTextBox);               
        }
    }
}
