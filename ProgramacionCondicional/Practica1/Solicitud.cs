using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Solicitud
    {
        public void Respuesta()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int resta = 0;
            int producto = 0;
            decimal cociente = 0;
            string entrada = string.Empty;
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    return;
                }

                if (!int.TryParse(entrada, out num1))
                {
                    Console.WriteLine("Valor invalido");
                }
                else
                {
                    num1 = int.Parse(entrada);
                }

                Console.WriteLine("Ingrese el segundo numero");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    return;
                }

                if (!int.TryParse(entrada, out num2))
                {
                    Console.WriteLine("Valor invalido");
                }
                else
                {
                    num2 = int.Parse(entrada);
                }





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            if (num1 > num2)
            {
                suma = num1 + num2;
                resta = num1 - num2;
                Console.WriteLine($"La suma de los dos numero es: {suma} \n" +
                    $"La resta de los dos numeros es: {resta}");


            }
            else
            {
                producto = num1 * num2;
                cociente = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
                Console.WriteLine($"El producto de los dos numero es: {producto} \n" +
                 $"El cociente de los dos numeros es: {cociente.ToString("F2")}");


            }

        }




    }
}
