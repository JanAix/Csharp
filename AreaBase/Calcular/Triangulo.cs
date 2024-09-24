using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calcular
{/// <summary>
 /* Solicite al usuario ingresar un número entero "n" que represente la cantidad de triángulos a procesar.
    Para cada triángulo, capture los valores de la base y la altura.
    Calcule el área de cada triángulo utilizando la fórmula correspondiente.
    Muestre en pantalla los datos de cada triángulo (base, altura y área).
Determine y reporte la cantidad de triángulos con un área superior a 12 unidades cuadradas.*/
/// </summary>
    public class Triangulo
    {

        public void Calculo()
        {
            string entrada;
            int n;
            int triángulosConÁreaSuperiorA12 = 0;

            try
            {

            Console.Write("Ingrese la cantidad de triángulos a procesar: ");
            entrada = Console.ReadLine();
            if (entrada == string.Empty)
            {
                Console.WriteLine("Campo requerido");
            }
            if (int.TryParse(entrada, out n))
            {
                n = int.Parse(entrada);
            }
            else
            {
                Console.WriteLine("Dato invalido");
            }



            // Procesar cada triángulo
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nTriángulo {i + 1}");

                // Capturar base y altura
                Console.Write("Ingrese la base del triángulo: ");
                double baseTriángulo = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura del triángulo: ");
                double alturaTriángulo = double.Parse(Console.ReadLine());

                // Calcular el área del triángulo
                double áreaTriángulo = (baseTriángulo * alturaTriángulo) / 2;

                // Mostrar datos del triángulo
                Console.WriteLine($"Base: {baseTriángulo}");
                Console.WriteLine($"Altura: {alturaTriángulo}");
                Console.WriteLine($"Área: {áreaTriángulo:F2}");

                // Verificar si el área es mayor a 12 unidades cuadradas
                if (áreaTriángulo > 12)
                {
                    triángulosConÁreaSuperiorA12++;
                }
            }


            // Mostrar la cantidad de triángulos con área superior a 12 unidades cuadradas
            Console.WriteLine($"\n Cantidad de triángulos con área superior a 12 unidades cuadradas: {triángulosConÁreaSuperiorA12}");

            }
            catch (Exception)
            {

                Console.WriteLine( "Hubo un error"); ;
            }

        }
    }

}
