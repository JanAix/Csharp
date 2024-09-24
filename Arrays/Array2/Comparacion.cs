using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;


namespace Array2
{ /// <summary>
  /// Escriba un programa que lea dos matrices desde la consola y verifique si son iguales (dos matrices son iguales cuando tienen la misma longitud 
  /// y todos sus elementos, que tienen el mismo índice, son iguales).
  /// </summary>
    public class Comparacion
    {
       private int[] matriz1;
        private int[] matriz2;

        public void Verificacion()
        {
           // int[] matriz1;
            //int[] matriz2;
            int datos = 0;
            int contar = 0;
            string entrada;

            try
            {


                Console.WriteLine("Ingrese la longitud de la primera matriz");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    Console.Clear();
                    Verificacion();
                }
                if (!int.TryParse(entrada, out contar))
                {
                    Console.WriteLine("Datos invalido");
                    Console.ReadKey();
                    Console.Clear();
                    Verificacion();

                }
                else
                {
                    contar = int.Parse(entrada);

                    matriz1 = new int[contar];

                    for (int i = 0; i < contar; i++)
                    {


                        Console.WriteLine("Ingrese el valor de la posicion " + i);
                        entrada = Console.ReadLine();
                        if (entrada == string.Empty)
                        {
                            Console.WriteLine("Campo requerido");
                            Console.ReadKey();
                            Console.Clear();
                            Verificacion();
                        }
                        if (!int.TryParse(entrada, out datos))
                        {
                            Console.WriteLine("Datos invalido");
                            Console.ReadKey();
                            Console.Clear();
                            Verificacion(); ;
                        }

                        datos = int.Parse(entrada);
                        matriz1[i] = datos;

                    }



                    Console.WriteLine("Ingrese la longitud de la segunda matriz");
                    entrada = Console.ReadLine();
                    if (entrada == string.Empty)
                    {
                        Console.WriteLine("Campo requerido");
                        Console.ReadKey();
                        Console.Clear();
                        Verificacion();
                    }
                    if (!int.TryParse(entrada, out contar))
                    {
                        Console.WriteLine("Datos invalido");
                        Console.ReadKey();
                        Console.Clear();
                        Verificacion(); ;

                    }
                    else
                    {
                        contar = int.Parse(entrada);

                        matriz2 = new int[contar];

                        for (int i = 0; i < contar; i++)
                        {


                            Console.WriteLine("Ingrese el valor de la posicion " + i);
                            entrada = Console.ReadLine();
                            if (entrada == string.Empty)
                            {
                                Console.WriteLine("Campo requerido");
                                Console.ReadKey();
                                Console.Clear();
                                Verificacion(); ;
                            }
                            if (!int.TryParse(entrada, out datos))
                            {
                                Console.WriteLine("Datos invalido");
                                Console.ReadKey();
                                Console.Clear();
                                Verificacion();
                            }

                            datos = int.Parse(entrada);
                            matriz2[i] = datos;


                        }
                    }
                }


                if (matriz1.Length == matriz2.Length && matriz1.SequenceEqual(matriz2))
                {
                    Console.WriteLine();
                    Console.WriteLine("Son iguales \n");

                    Console.WriteLine("Matriz 1 ");
                    foreach (int uno in matriz1)
                    {

                        Console.WriteLine(uno);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Matriz 2 ");
                    foreach (int dos in matriz2)
                    {
                        Console.WriteLine(dos);

                    }
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Son diferentes" +
                        "\n");
                    Console.WriteLine("Matriz 1  ");
                    foreach (int uno in matriz1)
                    {

                        Console.WriteLine(uno);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Matriz 2  ");
                    foreach (int dos in matriz2)
                    {

                        Console.WriteLine(dos);

                    }
                    

                }
            }

            catch (Exception e)
            {

                Console.WriteLine("Hubo un error", e); ;
            }

            finally {
                Console.WriteLine("Gracias por preferirnos");
                
            }




        }
    
    }
}