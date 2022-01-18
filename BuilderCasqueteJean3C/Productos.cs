using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCasqueteJean3C
{
    public class Productos
    {
        //Estos atributos de la lista para guardar los componentes de en este caso la computadora
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        //Esto muestra los componentes ya hechos del computador gaming
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + "";
            }

            str = str.Remove(str.Length - 2); 

            return "Producto estándar completo: " + str + "\n";

        }
    }
}
