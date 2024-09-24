using System;
using System.Drawing;

namespace Array3
{
    /// <summary>
    /// Crear un programa que solicite al usuario "N" números, almacenarlos en una estructura de datos lineal y determinar lo siguiente:
      /// El menor valor.
    ///Indicar si algún valor se repite al menos una vez.
    /// </summary>
    public class Repeticion
    {


        private int [] datosLineal;
        private int repetirA;
        private int repetirB;

        public void resultado() {
            string entrada =  string.Empty;
            int contador = 0;
            bool repetido = false;
            


            Console.WriteLine("Ingrese la cantidad de numero que quiere ingresar");

            try
            {
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    Console.Clear();
                    resultado();
                }
                if (!int.TryParse(entrada, out contador))
                {

                    Console.WriteLine("Dato invalido");
                    Console.ReadKey();
                    Console.Clear();
                    resultado();

                }
                datosLineal = new int[contador];
                for (int i = 0; i < datosLineal.Length; i++)
                {

                    Console.WriteLine("Ingrese el valor de la posicion " + (i + 1));
                    entrada = Console.ReadLine();
                    if (entrada == string.Empty)
                    {
                        Console.WriteLine("Campo requerido");
                        Console.ReadKey();
                        Console.Clear();
                        resultado();
                    }
                    if (!int.TryParse(entrada, out contador))
                    {

                        Console.WriteLine("Dato invalido");
                        Console.ReadKey();
                        Console.Clear();
                        resultado();
                    }
                    datosLineal[i] = contador;



                }
                for (int i = 0; i < datosLineal.Length; i++)
                {

                    repetirA = datosLineal[i];
                    int contar = i+1;

                    for (int x = contar; x < datosLineal.Length; x++)
                    {
                        repetirB = datosLineal[x];

                        if (repetirA == repetirB)
                        {

                            repetido = true;
                            Console.WriteLine();
                            Console.WriteLine($"El menor valor es: {datosLineal.Min()}\n");
                            Console.WriteLine($"EL numero que se repite es " + repetirA + " en la lista\n");
                        }
                    }
                }

                if (repetido == false)
                {
                    Console.WriteLine();
                    Console.WriteLine($"El menor valor es: {datosLineal.Min()}\n");
                    Console.WriteLine("No hay numero repetido\n");
                }

            }

            catch (Exception e)
            {

                Console.WriteLine("Hubo un error", e); ;
            }
            finally
            {

                Console.WriteLine("Gracias por utilizar nuestra plataforma");
            }

        }
            }
        }
    



