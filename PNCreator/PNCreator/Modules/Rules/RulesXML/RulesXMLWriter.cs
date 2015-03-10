using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Microsoft.Expression.Shapes;
using PNCreator.Modules.Rules.Panels;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Rules.RulesXML
{
    public class RulesXMLWriter
    {
        private static readonly XNamespace rulesNs = "rules";

        private static string applicationPath =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
        
        private string filePath = applicationPath + "//TempFiles//RulesSets.xml";

        public void Write(string ruleSetName, List<PanelExpender> rulesList)
        {
            XDocument rulesWriter = XDocument.Load(filePath);
            
            XElement ruleSet = new XElement("RuleSet");
            ruleSet.Add(new XAttribute("Name", ruleSetName));

            if (rulesWriter.Root != null)
                rulesWriter.Root.Add(ruleSet);
            else 
                return;

            foreach (var panelExpender in rulesList)
            {
                RulesPropertiesPanelBase panel = panelExpender.Panel;
                PNObject pnObject = panel.PanelPNObject;

                XElement pnObjectRule = new XElement(TypeNamePairs.GetNameByType(panel.PanelPNObjectType));                
                pnObjectRule.Add(new XAttribute("Name", pnObject.Name));
                pnObjectRule.Add(new XAttribute("ID", pnObject.ID));
                ruleSet.Add(pnObjectRule);

                
                if (panel is RulesArcPropertiesPanel)
                {
                    RulesArcPropertiesPanel arcPanel = (RulesArcPropertiesPanel) panel;
                    pnObjectRule.Add(new XElement("Weight", arcPanel.WeightTextBox.Text));
                }
                else if (panel is RulesLocationPropertiesPanel)
                {
                    RulesLocationPropertiesPanel locationPanel = (RulesLocationPropertiesPanel)panel;

                    pnObjectRule.Add(new XElement("MinCapacity", locationPanel.MinCapacityTextBox.Text));
                    pnObjectRule.Add(new XElement("MaxCapacity", locationPanel.MaxCapacityTextBox.Text));

                    if (pnObject is DiscreteLocation)
                    {
                        pnObjectRule.Add(new XElement("Tokens", locationPanel.TokenLevelTextBox.Text));
                    }
                    else if (pnObject is ContinuousLocation)
                    {
                        pnObjectRule.Add(new XElement("Level", locationPanel.TokenLevelTextBox.Text));
                    }
                }
                else if (panel is RulesMembranePropertiesPanel)
                {
                    RulesMembranePropertiesPanel membranePanel = (RulesMembranePropertiesPanel)panel;

                    if (pnObject is StructuralMembrane)
                    {
                        pnObjectRule.Add(new XElement("Speed", membranePanel.SpeedTextBox.Text));
                    }
                }
                else if (panel is RulesTransitionPropertiesPanel)
                {
                    RulesTransitionPropertiesPanel transitionPanel = (RulesTransitionPropertiesPanel)panel;

                    
                    if (pnObject is DiscreteTransition)
                    {
                        pnObjectRule.Add(new XElement("Delay", transitionPanel.DelayExpectanceTextBox.Text));
                    }
                    else if (pnObject is ContinuousTransition)
                    {
                        pnObjectRule.Add(new XElement("Expectance", transitionPanel.DelayExpectanceTextBox.Text));
                    }

                    pnObjectRule.Add(new XElement("Guard", transitionPanel.GuardTextBox.Text));
                }
            }

            rulesWriter.Save(filePath);
        }

        public bool CreateFile()
        {
            if (!File.Exists(filePath))
            {
                XDocument rulesWriter = new XDocument(new XElement("RulesSets"));
                rulesWriter.Save(filePath);
                return true;
            }

            return false;
        }
    }
}
