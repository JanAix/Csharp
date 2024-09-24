using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Alumnos
    {
        public void Listar()
        {
            try
            {
                decimal num1 = 0;
                decimal num2 = 0;
                decimal num3 = 0;
                decimal promedio = 0;
                string entrada = string.Empty;
                Console.WriteLine("Ingresa la primera calificacion del 1 al 10");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    return;
                }
                if (!decimal.TryParse(entrada, out num1))
                {
                    Console.WriteLine("Dato invalido, debe ser un numero");
                    return;

                }
                num1 = decimal.Parse(entrada);

                Console.WriteLine("Ingresa la segunda calificacion de 1 al 10");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    return;
                }
                if (!decimal.TryParse(entrada, out num2))
                {
                    Console.WriteLine("Dato invalido, debe ser un numero");
                    return;

                }
                num2 = decimal.Parse(entrada);


                Console.WriteLine("Ingresa la Tercera calificacion del 1 al 10");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    return;
                }
                if (!decimal.TryParse(entrada, out num3))
                {
                    Console.WriteLine("Dato invalido, debe ser un numero");
                    return;

                }
                num2 = decimal.Parse(entrada);

                promedio = Math.Round((num1 + num2 + num3) / 3, 2);

                if (promedio >= 7)
                {
                    Console.WriteLine($"El Alumno ha aprobado con calificacion de : {promedio}");
                }
                else
                {
                    Console.WriteLine($"El alumno ha reprobado con calificacion de : {promedio}");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
