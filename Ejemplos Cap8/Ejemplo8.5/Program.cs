
using System;

public class SumaArreglo
{

    public static void Main(string[] args)
    {


        int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
        int total = 0;


       

        for (int i = 0; i < arreglo.Length; i++)
        {
            total += arreglo[i];

            

        }
        Console.WriteLine("Total de los elementos del arreglo: {0}", total);
        Console.ReadKey();


    }
}


