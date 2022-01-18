using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCasqueteJean3C
{
    public interface Constructor
    {
        //Se crean la Reglas que necesita el objetos para crear la computador es decir todos las partes.
        void BuildRam();

        void BuildProcesador();

        void BuildDisco();

        void BuildMarca();

        void BuildSoftware();

        void BuildPantalla();

        void BuildIDPC();
    }
}
