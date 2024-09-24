// GraficoBarrars

using System;

public class GraficoBarras
{
    public static void Main (string[] args)
    {




        int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

        Console.WriteLine("Distribucion de las calificaciones");

        for (int i = 0; i < arreglo.Length; i++)
        { 


            if (i == 10)
            {

                Console.Write("  100:");
            }
            else
            {
                Console.Write("{0:D2}-{1:D2}:", i * 10, i * 10 + 9);
            }
        

            for (int estrella = 0; estrella < arreglo[i]; estrella++)
            {

                Console.Write("*");
                
            }
            Console.WriteLine();

        }

    }

}