using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCasqueteJean3C
{
    public class Director 
    {
        private Constructor _constructor;

        public Constructor Constructor
        {
            set { _constructor = value; }
        }

        // El Director puede construir varias variaciones de productos usando el mismo
        // pasos de construcción.
        public void BuildMinimalViableProduct()
        {
            this._constructor.BuildRam();
        }

        public void BuildFullFeaturedProduct()
        {
            this._constructor.BuildRam();
            this._constructor.BuildProcesador();
            this._constructor.BuildMarca();
            this._constructor.BuildPantalla();
            this._constructor.BuildIDPC();
            this._constructor.BuildSoftware();
            this._constructor.BuildDisco();

        }

    }
}
