using System;
using System.Windows.Controls;
using PNCreator.ManagerClasses;
using PNCreator.ManagerClasses.EventManager;
using PNCreator.ManagerClasses.EventManager.Events;
using PNCreator.ManagerClasses.Exception;
using PNCreator.ManagerClasses.FormulaManager;
using PNCreator.Modules.FormulaBuilder;
using PNCreator.PNObjectsIerarchy;
using PNCreator.Properties;
using RuntimeCompiler.FormulaCompiler;

namespace PNCreator.Modules.Rules.Panels
{
    public class RulesPropertiesPanelBase:Grid
    {        
        protected PNObject OldPNObject;

        public PNObject PanelPNObject { get; protected set; }
        public Type PanelPNObjectType { get; protected set; }                

        public RulesPropertiesPanelBase(PNObject pnObject)
        {
            PanelPNObject = pnObject;
        }

        public virtual void ExecuteChangtes()
        {
            if (PanelPNObject == null)
                return;
        }

        public virtual void UndoChanges()
        {
            if (PanelPNObject == null || OldPNObject == null)
                return;
        }       

        protected void ChangeValuesInObjectsPanel(TextBox sender)
        {
            var texBox = sender;
            var pnObject = texBox.Tag as PNObject;
            if (pnObject != null)
            {
                pnObject.ValueInCanvas.Text = texBox.Text;
            }
        }

        #region FormulaBuilder

        private string formulaString;

        protected void AttachFormula(TextBox formulaTB, PNObject pnObject, FormulaTypes formulaType)
        {
            var eventPublisher = App.GetObject<EventPublisher>();

            if (formulaTB.Text.Equals(""))
            {
                SetFormula(formulaTB.Text, pnObject, formulaType, false);
            }
            else if (CheckFormula(formulaTB, formulaType))
            {
                var formulaMng = App.GetObject<FormulaManager>();

                SetFormula(formulaTB.Text, pnObject, formulaType, true);
                formulaMng.IsNeedToCompile = true;

                var result = UpdateObjectsWithFormula(formulaMng, pnObject);
               /* if (result != null)
                {
                    DialogWindow.Alert(result);
                }*/

                formulaMng.IsNeedToCompile = false;
            }
            eventPublisher.ExecuteEvents(new PNObjectChangedEventArgs(pnObject));
        }

        private bool CheckFormula(TextBox formulaTB, FormulaTypes formulaType)
        {
            try
            {
                if (formulaTB.Text.Equals(""))
                    return true;

                formulaString = FormulaConverter.ToArrayOfValues(formulaTB.Text);
                if (formulaString != null)
                {
                    if (formulaType == FormulaTypes.Guard)
                    {                     
                        FormulaCompiler.CompileBoolFormula(formulaString).ExecuteBooleanFormula(PNObjectRepository.PNObjects.DoubleValues,
                                                                                                 PNObjectRepository.PNObjects.BooleanValues);
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (NotSupportedException ex)
            {
                ExceptionHandler.HandleException(ex);
                return false;
            }
        }

        private void SetFormula(string formula, PNObject pnObject, FormulaTypes formulaType, bool isCompile)
        {
            if (formulaType == FormulaTypes.Guard)
            {
                ((IExtendedFormula)pnObject).TransitionGuardFormula = formula;
                if (isCompile)
                    ((IExtendedFormula)pnObject).CompileBooleanFormula(formulaString);
            }
            else
            {
                ((IFormula)pnObject).Formula = formula;
                if (isCompile)
                {
                    ((IFormula)pnObject).CompileFormula(formulaString);
                }
            }
        }

        private string UpdateObjectsWithFormula(FormulaManager formulaMng, PNObject pnObject)
        {
            foreach (ObjectWithFormula objWithFormula in formulaMng.GetObjectsWithFormula())
            {
                if (objWithFormula.FormulaType == FormulaTypes.Guard)
                {
                    bool booleanResult = ((IExtendedFormula)objWithFormula.Object).ExecuteGuardFormula();
                    if (pnObject.Equals(objWithFormula.Object))
                    {
                        return Messages.Default.CorrectFormula + booleanResult.ToString();
                    }
                }
                else
                {
                    double doubleResult = ((IFormula)objWithFormula.Object).ExecuteFormula();
                    if (pnObject.Equals(objWithFormula.Object))
                    {
                        return Messages.Default.CorrectFormula + doubleResult.ToString();
                    }
                }
                // eventPublisher.ExecuteEvents(new ProgressEventArgs(progress++));
            }
            return null;
        }
        #endregion
    }
}