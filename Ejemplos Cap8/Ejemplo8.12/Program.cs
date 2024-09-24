//Fig. 8.12: PruebaForEach.cs
//Uso de la instruccion foreach para totalizar los enteros en un arreglo.
using System;

namespace PruebaForEach.cs
{
    public class PruebaForEach
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;
            //Suma el valor de cada elemento a total
            foreach (int numero in arreglo)
                total += numero;
            Console.WriteLine("Total de elementos en el arreglo:{0}", total);
            Console.ReadLine();
        }//fin de main
    }// fin de la clase PruebaForEach
}
