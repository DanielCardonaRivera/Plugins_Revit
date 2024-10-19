using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*librerías de revit para el uso del IExternal Command*/
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
namespace MiPirmeraAppIExternalCommand
{
    /*Tipo de transacción*/
    [Transaction(TransactionMode.Manual)]
    public class Class1 : IExternalCommand
       

    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Saludo"," Mi Primer Plugin para Revit  parcero Juan Saa ");
            return Result.Succeeded;        }
    }
}
