using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace TEMA_3_DZ_6_2_Library
{
    public class FamilySumbolUtils
    {

        public static List<FamilySymbol> GetFurnitureSymbols(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            var furnitureTypes = new FilteredElementCollector(doc)
                .WherePasses(new ElementCategoryFilter(BuiltInCategory.OST_Furniture))
                .OfClass(typeof(FamilySymbol))
                .Cast<FamilySymbol>()
                .ToList();

            return furnitureTypes;
        }
    }
}
