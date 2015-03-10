using PNCreator.ManagerClasses;
using PNCreator.PNObjectsIerarchy;


namespace PNCreator.Modules.Rules.Panels
{
    /// <summary>
    /// Interaction logic for RulesLocationPropertiesPanel.xaml
    /// </summary>
    public partial class RulesLocationPropertiesPanel
    {                
        public RulesLocationPropertiesPanel(Location pnObject)
            : base(pnObject)
        {
            InitializeComponent();

            PanelPNObjectType = typeof (Location);

            if (PanelPNObject is DiscreteLocation)
            {
                TokenLevelTextBlock.Text = "Tokens";
            }
            else if (PanelPNObject is ContinuousLocation)
            {
                TokenLevelTextBlock.Text = "Level";
            }
        }

        public override void ExecuteChangtes()
        {
            base.ExecuteChangtes();

            Location pnObject = (Location)PanelPNObject;

            if (!string.IsNullOrWhiteSpace(MinCapacityTextBox.Text))            
                pnObject.MinCapacity = double.Parse(MinCapacityTextBox.Text);

            if (!string.IsNullOrWhiteSpace(MaxCapacityTextBox.Text))
                pnObject.MaxCapacity = double.Parse(MaxCapacityTextBox.Text);

            if (!string.IsNullOrWhiteSpace(TokenLevelTextBox.Text))
            {
                if (PanelPNObject is DiscreteLocation)
                {
                    AttachFormula(TokenLevelTextBox, pnObject, FormulaTypes.Value);                    
                }                    
                else if (PanelPNObject is ContinuousLocation)
                {
                    AttachFormula(TokenLevelTextBox, pnObject, FormulaTypes.Value);
                }

                ChangeValuesInObjectsPanel(TokenLevelTextBox);
            }            
        }        
    }
}
