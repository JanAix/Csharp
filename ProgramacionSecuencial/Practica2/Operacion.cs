using System;
using System.Diagnostics.CodeAnalysis;
namespace Practica2
{
    public class Operacion
    {
        string articulo =string.Empty;
        int cantidad = 0;
        int precio = 0;
        int totalPagar = 0;
        public void super()
        {
            try
            {
                Console.ReadKey(); 
                Console.Clear();
                Console.WriteLine("Ingresa el nombre del articulo");
                articulo = Console.ReadLine();
                if (articulo == string.Empty) {
                    Console.WriteLine("El articulo no puede estar vacio, favor de llenar el campo");
                super();
                }

                Console.WriteLine("Ingresa la cantidad");
                cantidad = int.Parse(Console.ReadLine());
             
                Console.WriteLine("Ingresa el precio");
                precio = int.Parse(Console.ReadLine());
                totalPagar = cantidad * precio;

                Console.WriteLine($"Su Articulo es {articulo} y el monto a abonar es: {totalPagar}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hubo un error {e.Message}");
                super();

            }


        }


    }
}
