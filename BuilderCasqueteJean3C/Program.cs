using System;

namespace BuilderCasqueteJean3C
{
    class Program
    {
        static void Main(string[] args)
        {
             //Nombre: Casquete Jean Pier 3C
            //En este casoel patron builder lo usaremos para solucionar la creación de un computador de alta gama
            //Para eso debemos contruir como clase principal al televisor y sub clase para el televisor que serán sus partes o componentes
            //Este televisor se ira construyendo paso a paso


            /*El código del cliente crea un objeto constructor, lo pasa al
             director y luego inicia el proceso de construcción. El fin
             el resultado se recupera del objeto constructor.*/

            var director = new Director();
            var constructor = new ConcreteBuilder();
            director.Constructor = constructor;

            //Creamos un Objetos basico del computador Gaming

            Console.WriteLine("Productos básicos estándar de un computador:\n");
            director.BuildMinimalViableProduct();
            Console.WriteLine(constructor.GetProductos().ListParts());

            //Creamos un Objetos Estandar del computador Gaming
            Console.WriteLine("Productos estándar completados:\n");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(constructor.GetProductos().ListParts());

            //Creamos un Objetos personalizado
            // clase.
            Console.WriteLine("Producto personalizado de la Computadora:\n");
            constructor.BuildRam();
            constructor.BuildProcesador();
            constructor.BuildMarca();
            constructor.BuildPantalla();
            constructor.BuildIDPC();
            constructor.BuildSoftware();
            constructor.BuildDisco();


            Console.Write(constructor.GetProductos().ListParts());





        }
    }
}
