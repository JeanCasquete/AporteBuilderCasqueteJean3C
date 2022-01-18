using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCasqueteJean3C
{
    public class ConcreteBuilder : Constructor
    {
        private Productos _productos = new Productos();

        // Una nueva instancia del constructor
        // debe contener un objeto de producto en blanco que
        // se usa en ensamblajes posteriores.
        public ConcreteBuilder()
        {
            this.Reset();
        }

      public void Reset()
        {
            this._productos = new Productos();
        }

        // Todos los pasos de producción funcionan con la misma instancia de producto.
        //Se van ir creando cada componente  que componer del productor principal que es una PC GAMING
        public void BuildRam()
        {
            this._productos.Add("Memoria RAM de 32GB\n");
        }

        public void BuildProcesador()
        {
            this._productos.Add("Intel Core i7 3.5GHZ\n");
        }

        public void BuildDisco()
        {
            this._productos.Add("1TB SSD\n");
        } 

        public void BuildMarca()
        {
            this._productos.Add("Razer Gaming 300\n");
        }

        public void BuildSoftware()
        {
            this._productos.Add("Windows 10\n");
        }

        public void BuildPantalla()
        {
            this._productos.Add("Pantalla 1442x1280\n");
        }

        public void BuildIDPC()
        {
            this._productos.Add("ID 775");
        }


        //Sera párte para la Mostrar lo datos del Computador Gaming
        public Productos GetProductos()
        {
            Productos resultado = this._productos;

            this.Reset();

            return resultado;
        }

  
    }
}
