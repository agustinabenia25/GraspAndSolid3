using System;
using System.IO;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("..\\..\\recetas_guardadas\\" + recipe.FinalProduct.Description + ".txt", recipe.GetTextToPrint());
        }
    }
}