//Fig 8.4

using System;


using System;

public class InicArreglo
{

    public static void Main(string[] args)
    {

        const int LONGITUD_ARREGLO = 10; //Constante

        int[] arreglo = new int[LONGITUD_ARREGLO];


        Console.WriteLine("{0}{1,8}", "Indice", "Valor"); //encabezado

        for (int i = 0; i < arreglo.Length; i++)
        {

            arreglo[i] = 2 + 2 * i;
            Console.WriteLine("{0,5}{1,8}", i, arreglo[i]);

        }
        Console.ReadKey();
    }
}




