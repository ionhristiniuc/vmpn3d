using System.Windows.Controls;
using Microsoft.Expression.Shapes;
using PNCreator.ManagerClasses;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Rules.Panels
{
    public partial class RulesArcPropertiesPanel:RulesPropertiesPanelBase
    {                          
        public RulesArcPropertiesPanel(Arc3D pnObject)      
            :base(pnObject)
        {
            InitializeComponent();
            PanelPNObjectType = typeof (Arc3D);
        }

        public override void ExecuteChangtes()
        {
            base.ExecuteChangtes();

            Arc3D pnObject = (Arc3D)PanelPNObject;            

            if (!string.IsNullOrWhiteSpace(WeightTextBox.Text))
            {
                AttachFormula(WeightTextBox, pnObject, FormulaTypes.Weight);
                ChangeValuesInObjectsPanel(WeightTextBox);
            }            
        }          
    }
}
