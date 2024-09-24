using System;

public class InicArreglo
{

    public static void Main(string[] args) {


        int[] arreglo = {32, 27, 64, 18, 95, 14, 90, 70, 60, 37};


        Console.WriteLine("{0}{1,8}", "Indice", "Valor"); //encabezado

        for (int i = 0; i < arreglo.Length; i++)
        {


            Console.WriteLine("{0,5}{1,8}", i, arreglo[i]);

        }
        Console.ReadKey();










}



}