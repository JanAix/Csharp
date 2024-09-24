// Fig. 8.2: InicArreglo.cs 
// Creación de un arreglo using System;
using System;
public class InicArreglo
{
    public static void Main(string[] args)
    {
        int[] arreglo; // declara un arreglo 11amado arreglo // crea el espacio para el arreglo y 1o inicializa con ceros predeterminados
        arreglo = new int[10]; // 10 elementos int
        Console.WriteLine("{0}{1,8}", "Índice", "Valor"); // encabezados
                                                          // imprime en pantalla el valor de cada elemento del arreglo

        for (int contador = 0; contador < arreglo.Length; contador++)
            Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
        Console.ReadKey();
    }// fin de Main ) 
}// fin de 1a clase InicArreglo