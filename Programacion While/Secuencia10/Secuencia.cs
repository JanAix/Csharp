using System;


namespace Secuencia10
{/// <summary>
/// Confeccionar un programa que, a partir de una secuencia de 10 números enteros, calcule y muestre la suma y el promedio aritmético de dichos números.
/// </summary>
    public class Secuencia
    {


        public void Sumaypromedio()
        {
            int numeros = 0;
            double promedio = 0;
            string entrada;
            int suma = 0;
            int contador = 1;
            string vaalidacion=string.Empty;

            try
            {
                Console.WriteLine("Ingrese 10 numeros");
                while (contador <= 10)
                {
                    Console.WriteLine("Ingrese el numero {0}", contador);
                    entrada = Console.ReadLine();
                    if (entrada == string.Empty)
                    {
                        Console.WriteLine("campo Requerido");
                    }
                    if (int.TryParse(entrada, out numeros))
                    {
                        numeros = int.Parse(entrada);
                        suma += numeros;

                        contador++;
                    }
                    else {
                        Console.WriteLine("Dato invalido");
                    }
                }
                    promedio = ( Convert.ToDouble( suma) / 10);
                    Console.WriteLine("La suma de los numeros es: {0} y el promedio es: {1}",suma,promedio);


                

            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error");
            }

           

        }
    }
}
