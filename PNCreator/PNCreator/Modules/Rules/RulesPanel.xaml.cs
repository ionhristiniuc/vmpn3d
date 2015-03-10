using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WindowsControl;
using PNCreator.ManagerClasses;
using PNCreator.Modules.Rules.Panels;
using PNCreator.Modules.Rules.RulesXML;
using PNCreator.PNObjectsIerarchy;

namespace PNCreator.Modules.Rules
{  
    public partial class RulesPanel
    {                      
        public List<PanelExpender> currentExpenderList = new List<PanelExpender>();
        public Dictionary<string, List<PanelExpender>> expenderLists = new Dictionary<string, List<PanelExpender>>();        
        RulesXMLWriter rulesSetWriter = new RulesXMLWriter();
        RulesXMLReader rulesSetReader = new RulesXMLReader();
        private bool onSaveSet;  

        public RulesPanel()
        {
            InitializeComponent();      
            PanelExpender.MainPanel = this;          
            InitRulesSets();   
        }

        #region Rule Set Manager

        private void InitRulesSets()
        {
            if (rulesSetWriter.CreateFile())
                return;

            List<string> setsNames = rulesSetReader.GetSetsNames();
            foreach (var name in setsNames)
            {
                RulesSetsComboBox.Items.Add(name);
            }            
        }

        private void CreateRulesSetTextBox_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
                return;

            if (RulesSetsComboBox.Items.Contains(CreateRulesSetTextBox.Text))
            {
                DialogWindow.Error("This name already exists. Please choose antoher");
                return;
            }

            if (!currentExpenderList.Any())
            {
                DialogWindow.Error("The rule set is empty");
                return;
            }

            if (HasSpecialCharacters(CreateRulesSetTextBox.Text))
            {
                DialogWindow.Error("The name of the rule set can contain only letters, numbers and '_', '-' symbols");
                return;
            }            


            expenderLists.Add(CreateRulesSetTextBox.Text, new List<PanelExpender>(currentExpenderList));            
            rulesSetWriter.Write(CreateRulesSetTextBox.Text, currentExpenderList);
            RulesSetsComboBox.Items.Add(CreateRulesSetTextBox.Text);

            onSaveSet = true;
            RulesSetsComboBox.SelectedItem = CreateRulesSetTextBox.Text;

            CreateRulesSetTextBox.Text = string.Empty;

            e.Handled = true;
        }
 
        private void RulesSetsComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            if (onSaveSet)
            {
                onSaveSet = false;
                return;
            }

            CreateRulesSetTextBox.Text = string.Empty;

            if (RulesSetsComboBox.SelectedIndex == -1)
                return;
       
            List<PanelExpender> currentCopy = new List<PanelExpender>(currentExpenderList);
            foreach (var panelExpender in currentCopy)
            {
                RemoveExpender(panelExpender);
            }

            if (RulesSetsComboBox.SelectedIndex != 0)
            {
                string setName = RulesSetsComboBox.SelectedValue.ToString();

                if (!expenderLists.ContainsKey(setName))
                {
                    bool everythingWasLoaded;
                    expenderLists[setName] = rulesSetReader.Read(setName, out everythingWasLoaded);

                    if (!everythingWasLoaded)
                        DialogWindow.Alert("Some rules were not loaded due to the absence of some objects");
                }

                foreach (var panelExpender in expenderLists[setName])
                {
                    AddExpender(panelExpender);
                }
            }                       
        }

        private void SaveChangesButton_OnClick(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Rule Creator

        public void AddExpender(PanelExpender newExpender)
        {
            bool alreadyExists = false;
            foreach (var expender in currentExpenderList)
            {
                if (Equals(expender.Panel.PanelPNObject, newExpender.Panel.PanelPNObject))
                    alreadyExists = true;
            }
            if (!alreadyExists)
            {
                currentExpenderList.Add(newExpender);
                MiddleExpender.Children.Add(newExpender);
                if (RulesLisTextBlock.Visibility == Visibility.Hidden)
                    RulesLisTextBlock.Visibility = Visibility.Visible;
            }
        }

        public void RemoveExpender(PanelExpender expender)
        {
             currentExpenderList.Remove(expender);
             MiddleExpender.Children.Remove(expender);

            if (!currentExpenderList.Any())            
                RulesLisTextBlock.Visibility = Visibility.Hidden;           
        }       

        private void CreateRuleButton_OnClick(object sender, RoutedEventArgs e)
        {            
            if (ObjectIDComboBox.SelectedIndex != -1)
            {
                long selectedObjectID = (long) ObjectIDComboBox.SelectedItem;
                PNObject pnObjectExpender = null;

                foreach (var pnObject in PNObjectRepository.GetPNObjects<PNObject>())
                {
                    if (pnObject.ID == selectedObjectID)
                    {
                        pnObjectExpender = pnObject;
                        break;
                    }
                }

                if (pnObjectExpender != null)
                {                                                           
                    PanelExpender newExpender = new PanelExpender(pnObjectExpender);                        
                    AddExpender(newExpender);                                                           
                }
                else
                {
                    DialogWindow.Error("Object does not exist.");                    
                }
            }
        }

        private void TypeComboBox_DropDownOpened(object sender, EventArgs eventArgs)
        {
            TypeComboBox.Items.Clear();
            foreach (PNObject pnObject in PNObjectRepository.GetPNObjects<PNObject>())
            {
                if (pnObject is Arc3D)
                {
                    if (!TypeComboBox.Items.Contains(TypeNamePairs.GetNameByType(typeof(Arc3D))))
                        TypeComboBox.Items.Add(TypeNamePairs.GetNameByType(typeof(Arc3D)));
                }
                else if (pnObject is Location)
                {
                    if (!TypeComboBox.Items.Contains(TypeNamePairs.GetNameByType(typeof(Location))))
                        TypeComboBox.Items.Add(TypeNamePairs.GetNameByType(typeof (Location)));
                }
             /* else if (pnObject is Membrane)
                {
                    if (!TypeComboBox.Items.Contains(TypeNamePairs.GetNameByType(typeof(Membrane))))
                        TypeComboBox.Items.Add(TypeNamePairs.GetNameByType(typeof(Membrane)));
                }*/
                else if (pnObject is Transition)
                {
                    if (!TypeComboBox.Items.Contains(TypeNamePairs.GetNameByType(typeof(Transition))))
                        TypeComboBox.Items.Add(TypeNamePairs.GetNameByType(typeof(Transition)));
                }                
            }

            TypeComboBox.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
        }

        private void TypeComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeComboBox.SelectedIndex == -1)
            {
                ObjectNameComboBox.SelectedIndex = -1;
                ObjectIDComboBox.SelectedIndex = -1;
            }
        }


        private void ObjectNameComboBox_DropDownOpened(object sender, EventArgs eventArgs)
        {         
            ObjectNameComboBox.Items.Clear();            

            if (TypeComboBox.SelectedIndex == -1)
                return;

            string typeName = TypeComboBox.SelectedItem.ToString();
            Type selectedType = TypeNamePairs.GetTypeByName(typeName);
            
            foreach (PNObject pnObject in PNObjectRepository.GetPNObjects<PNObject>())
            {
                if (selectedType.IsInstanceOfType(pnObject))
                    ObjectNameComboBox.Items.Add(pnObject.Name);
            }

            ObjectNameComboBox.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
        }     

        private void ObjectNameComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ObjectIDComboBox.Items.Clear();

            if (ObjectNameComboBox.SelectedIndex == -1)
            {
                ObjectIDComboBox.SelectedIndex = -1;
                return;
            }
                        
            string selectedName = ObjectNameComboBox.SelectedItem.ToString();

            string typeName = TypeComboBox.SelectedItem.ToString();
            Type selectedType = TypeNamePairs.GetTypeByName(typeName);

            foreach (PNObject pnObject in PNObjectRepository.GetPNObjects<PNObject>())
            {
                if (selectedType.IsInstanceOfType(pnObject) && pnObject.Name == selectedName)
                    ObjectIDComboBox.Items.Add(pnObject.ID);
            }
            ObjectIDComboBox.SelectedItem = ObjectIDComboBox.Items[0];
                       
        }        
        
        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var panelExpender in currentExpenderList)
                {
                    if (PNObjectRepository.GetPNObjects<PNObject>().Contains(panelExpender.Panel.PanelPNObject))
                    {
                        if (!panelExpender.PNObjectExists)
                            panelExpender.PNObjectExists = true;

                        panelExpender.Panel.ExecuteChangtes();
                    }
                    else
                    {
                        panelExpender.PNObjectExists = false;
                    }
                }
            }
            catch (FormatException)
            {
                DialogWindow.Error("Some rules have wrong attributes");                
            }
            catch (NotSupportedException nse)
            {
                DialogWindow.Error(nse.Message);
            }
            finally
            {
                foreach (var panelExpender in currentExpenderList)
                {
                    panelExpender.Panel.UndoChanges();
                }
            }
        }

        #endregion Rule Creator                

        public static bool HasSpecialCharacters(string str)
        {
            const string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[~`+=" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();

            int index = str.IndexOfAny(specialCharactersArray);
            //index == -1 no special characters
            if (index == -1)
                return false;
            else
                return true;
        }
        
    }
}
