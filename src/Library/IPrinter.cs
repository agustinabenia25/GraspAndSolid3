using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}
/*

    El patrón que no se estaba cumpliendo en este caso era el de Polimorfismo.
    Este indica que el código que varía según el destino debería estar en diferentes clases con una operación polimórfica.

*/