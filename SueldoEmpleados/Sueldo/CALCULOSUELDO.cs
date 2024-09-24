using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo
{/// <summary>
/// En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.
/// </summary>
    public class CALCULOSUELDO
    {


        public void Sueldo()
        {
            string entrada = string.Empty;
            int empleadosEntre100y300 = 0;
            int empleadosMasDe300 = 0;
            double gastoTotal = 0.0;
            double sueldo = 0.0;
            int n = 0;

            try
            {

                Console.WriteLine("Bienvenido a Nomina");

                Console.Write("Ingrese el número de empleados: ");
            entrada = Console.ReadLine();
            if( entrada == string.Empty)
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
                    Console.ReadKey();
                    Console.Clear();
                    Sueldo();
                }
            

            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el sueldo del empleado {i + 1}: ");
                entrada = Console.ReadLine();
                if (entrada == null)
                {
                    Console.WriteLine("Campo requerido");
                }
                if (double.TryParse(entrada, out sueldo))
                {
                    sueldo = double.Parse(entrada);
                }
                    else
                    {

                        Console.WriteLine("Dato invalido");
                    }



                    // Validar que el sueldo esté en el rango permitido
                    if (sueldo < 100 || sueldo > 500)
                {
                    Console.WriteLine("El sueldo ingresado no está en el rango permitido ($100 - $500).");
                    Console.WriteLine("Vuelva a intentarlo");
                    Sueldo();
                }

                // Clasificar el sueldo
                if (sueldo >= 100 && sueldo <= 300)
                {
                    empleadosEntre100y300++;
                }
                else if (sueldo > 300)
                {
                    empleadosMasDe300++;
                }

                // Acumular el gasto total
                gastoTotal += sueldo;
            }

            Console.WriteLine("La cantidad de empleado que cobran entre $100 y $300 son: {0}\n \n"+
               "La cantidad de empleado que cobran mas de $300 son: {1} \n \n"
               + "La empresa gasta en los sueldos del personal : {2}",empleadosEntre100y300,empleadosMasDe300,gastoTotal);

            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error"); 
            }
        }
    }
}
