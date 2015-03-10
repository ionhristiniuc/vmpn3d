using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PNCreator.ManagerClasses;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Rules.Panels
{
    /// <summary>
    /// Interaction logic for RulesTransitionPropertiesPanel.xaml
    /// </summary>
    public partial class RulesTransitionPropertiesPanel
    {      
        public RulesTransitionPropertiesPanel(Transition pnObject)
            : base(pnObject)
        {
            InitializeComponent();

            PanelPNObjectType = typeof (Transition);

            if (PanelPNObject is DiscreteTransition)
            {
                DelayExpectanceTextBlock.Text = "Delay";
            }
            else if (PanelPNObject is ContinuousTransition)
            {
                DelayExpectanceTextBlock.Text = "Expectance";             
            }
        }

        public override void ExecuteChangtes()
        {
            base.ExecuteChangtes();

            Transition pnObject = (Transition)PanelPNObject;

            if (!string.IsNullOrWhiteSpace(DelayExpectanceTextBox.Text))
            {
                if (PanelPNObject is DiscreteTransition)
                    AttachFormula(DelayExpectanceTextBox, pnObject, FormulaTypes.Delay);
                else if (PanelPNObject is ContinuousTransition)
                    AttachFormula(DelayExpectanceTextBox, pnObject, FormulaTypes.Expectance);

                ChangeValuesInObjectsPanel(DelayExpectanceTextBox);
            }

            if (!string.IsNullOrWhiteSpace(GuardTextBox.Text))
            {
                AttachFormula(GuardTextBox, pnObject, FormulaTypes.Guard);
                ChangeValuesInObjectsPanel(DelayExpectanceTextBox);
            }                            
        }       
    }
}
