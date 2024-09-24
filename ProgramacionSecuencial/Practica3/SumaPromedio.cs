using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class SumaPromedio
    {

        public void Sumar_pr()
        {
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0;
            int suma = 0;
            int promedio = 0;


            try
            {
                Console.WriteLine("Ingresa un numero");
                num1=int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa otro numero");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa otro numero");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa otro numero");
                num4 = int.Parse(Console.ReadLine());

                suma=(num1 + num2 + num3 + num4);
                promedio = (num1 + num2 + num3 + num4) / 4;

                Console.WriteLine($"La suma de todos los numeros es: {suma}");
                Console.WriteLine($"El promedio de tods los numero es : {promedio}");   

            }
            catch (Exception e)
            {

                Console.WriteLine($"Hubo un error con {e.Message}");
                Sumar_pr();
            }
            

        }
    }
}
