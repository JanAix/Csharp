using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Examen
    {
        public void Resultado_test()
        {
            int totalPreguntas = 0;
            int correctas = 0;
            string entrada= string.Empty;
            decimal porcentaje = 0;

            try
            {
                Console.WriteLine("Ingrese el total de preguntas");
                entrada = Console.ReadLine();

                if (entrada == string.Empty)

                {
                    Console.WriteLine("Campo requerido");
                    return;
                }

                if (!int.TryParse(entrada, out totalPreguntas))
                {
                    Console.WriteLine("Dato invalida");
                    return;
                }
                totalPreguntas = int.Parse(entrada);




                Console.WriteLine("Ingrese el total de repuestas correctas");
                entrada = Console.ReadLine();

                if (entrada == string.Empty)

                {
                    Console.WriteLine("Campo requerido");
                    return;
                }

                if (!int.TryParse(entrada, out correctas))
                {
                    Console.WriteLine("Dato invalida");
                    return;
                }
                correctas = int.Parse(entrada);
            }

            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un erro en: {e}");
            }


            try
            {
                
                   porcentaje =(Convert.ToDecimal(correctas) /Convert.ToDecimal( totalPreguntas)) * 100;

                if (porcentaje >= 90)
                {
                    Console.WriteLine($"Nivel Maximo, su porcentaje es : {porcentaje.ToString("F0")}%");


                }
                else if (porcentaje >= 75 && porcentaje <90)
                {
                    Console.WriteLine($"Nivel medio, su porcentaje es : {porcentaje.ToString("F0")}%");
                }  
                else if(porcentaje >= 50 && porcentaje < 75)
                {

                    Console.WriteLine($"Nivel regular, su porcentaje es : {porcentaje.ToString("F0")}%");
                }
                else
                {
                    Console.WriteLine($"Fuera de nivel, su porcentaje es : {porcentaje.ToString("F0")}%");
                }



            }
            catch (Exception)
            {

                throw;
            }









            }
    }
}
