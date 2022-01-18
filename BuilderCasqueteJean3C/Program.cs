using System;

namespace BuilderCasqueteJean3C
{
    class Program
    {
        static void Main(string[] args)
        {
             //Nombre: Casquete Jean Pier 3C
            //En este casoel patron builder lo usaremos para solucionar la creación de un computador de alta gama
            //Para eso debemos contruir como clase principal al Computador y una clase para las partes de este mismo osea sus componentes
            //Este computador se ira construyendo paso a paso


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

            //Creamos un Objetos personalizado para la Computadora Gaming
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
