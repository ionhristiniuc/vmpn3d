using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using WindowsControl;
using PNCreator.ManagerClasses;
using PNCreator.Modules.Rules.Panels;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Rules.RulesXML
{
    class RulesXMLReader
    {
        private static string applicationPath =
           Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
        private string filePath = applicationPath + "//TempFiles//RulesSets.xml";

        public List<PanelExpender> Read(string name, out bool everythingWasLoaded)
        {
            everythingWasLoaded = true;

            XDocument rulesReader;
            try
            {
                rulesReader = XDocument.Load(filePath);
            }
            catch (Exception e)
            {
                DialogWindow.Error(e.Message);
                everythingWasLoaded = false;
                return null;
            }

            List<PanelExpender> returnList = new List<PanelExpender>();

            if (rulesReader.Root == null)
            {
                DialogWindow.Error("Root element does not exist in RulesSets.xml");
                return null;
            }

            foreach (var setElement in rulesReader.Root.Elements())
            {                
                string setName = setElement.Attribute("Name").Value;

                if (setName == name)
                {
                    foreach (var ruleElement in setElement.Elements())
                    {
                        long pnObjectID;
                        long.TryParse(ruleElement.Attribute("ID").Value, out pnObjectID);

                        PNObject pnObject =
                            (from obj in PNObjectRepository.GetPNObjects<PNObject>()
                                where obj.ID == pnObjectID
                                select obj)
                                .FirstOrDefault();

                        if (pnObject == null || !PNObjectRepository.GetPNObjects<PNObject>().Contains(pnObject))
                        {
                            everythingWasLoaded = false;
                            break;
                        }

                        PanelExpender newExpender = new PanelExpender(pnObject);
                        RulesPropertiesPanelBase panel = newExpender.Panel;

                        if (panel is RulesArcPropertiesPanel)
                        {
                            var weightElement = ruleElement.Element("Weight");
                            if (weightElement != null && !string.IsNullOrWhiteSpace(weightElement.Value))
                                ((RulesArcPropertiesPanel) panel).WeightTextBox.Text = weightElement.Value;
                        }
                        else if (panel is RulesLocationPropertiesPanel)
                        {
                            var minElement = ruleElement.Element("MinCapacity");
                            if (minElement != null && !string.IsNullOrWhiteSpace(minElement.Value))
                                ((RulesLocationPropertiesPanel) panel).MinCapacityTextBox.Text = minElement.Value;

                            var maxElement = ruleElement.Element("MaxCapacity");
                            if (maxElement != null && !string.IsNullOrWhiteSpace(maxElement.Value))
                                ((RulesLocationPropertiesPanel) panel).MaxCapacityTextBox.Text = maxElement.Value;

                            if (pnObject is DiscreteLocation)
                            {
                                var tokensElement = ruleElement.Element("Tokens");
                                if (tokensElement != null && !string.IsNullOrWhiteSpace(tokensElement.Value))
                                    ((RulesLocationPropertiesPanel) panel).TokenLevelTextBox.Text = tokensElement.Value;
                            }
                            else if (pnObject is ContinuousLocation)
                            {
                                var levelElement = ruleElement.Element("Level");
                                if (levelElement != null && !string.IsNullOrWhiteSpace(levelElement.Value))
                                    ((RulesLocationPropertiesPanel) panel).TokenLevelTextBox.Text = levelElement.Value;
                            }
                        }
                        else if (panel is RulesMembranePropertiesPanel)
                        {
                            if (pnObject is StructuralMembrane)
                            {
                                var speedElement = ruleElement.Element("Speed");
                                if (speedElement != null && !string.IsNullOrWhiteSpace(speedElement.Value))
                                    ((RulesMembranePropertiesPanel) panel).SpeedTextBox.Text = speedElement.Value;
                            }
                        }
                        else if (panel is RulesTransitionPropertiesPanel)
                        {
                            if (pnObject is DiscreteTransition)
                            {
                                var delayElement = ruleElement.Element("Delay");
                                if (delayElement != null && !string.IsNullOrWhiteSpace(delayElement.Value))
                                    ((RulesTransitionPropertiesPanel) panel).DelayExpectanceTextBox.Text =
                                        delayElement.Value;
                            }
                            else if (pnObject is ContinuousTransition)
                            {
                                var expectanceElement = ruleElement.Element("Expectance");
                                if (expectanceElement != null && !string.IsNullOrWhiteSpace(expectanceElement.Value))
                                    ((RulesTransitionPropertiesPanel) panel).DelayExpectanceTextBox.Text =
                                        expectanceElement.Value;
                            }
                        }

                        returnList.Add(newExpender);
                    }
                    return returnList;
                }
            }
            everythingWasLoaded = false;
            return null;
        }

        public List<string> GetSetsNames()
        {
            List<string> setsNamesList = new List<string>();
            XDocument rulesReader;

            try
            {
                rulesReader = XDocument.Load(filePath);
            }
            catch (Exception e)
            {
                DialogWindow.Error(e.Message);               
                return null;
            }


            if (rulesReader.Root != null)
                foreach (var setElement in rulesReader.Root.Elements())
                {
                    string setName = setElement.Attribute("Name").Value;
                    setsNamesList.Add(setName);
                }

            return setsNamesList;
        }

        public void CreateRuleSetsFile()
        {
            
        }
    }
}
