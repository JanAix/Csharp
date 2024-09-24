//Fig. 8.8: EncuestaEstudiantil.cs
//Aplicacion para analizar encuestas.
using System;

namespace EncuestaEstudiantil.cs
{
    public class EncuestaEstudiantil
    {
        public static void Main(string[] args)
        {
            int[] respuestas = {1,2,6,4,8,5,9,7,8,10,1,6,3,8,6,10,3,
            8,2,7,6,5,7,6,8,6,7,5,6,6,5,6,7,5,6,4,8,6,8,10};
            int[] frecuencia = new int[11]; //arreglo de contadores de frecuencia

            //para cada respuesta, selecciona el elemento de respuesta y usa ese valor 
            // como indice de frecuencia para determinar el elemento a incrementar
            for (int respuesta = 0; respuesta < respuestas.Length; respuesta++)
                ++frecuencia[respuestas[respuesta]];

            Console.WriteLine("{0}{1,11}", "Calificacion", "Frecuencia");

            //imprime en pantalla el valor de cada elemento del arreglo
            for (int calificacion = 1; calificacion < frecuencia.Length; calificacion++)
                Console.WriteLine("{0,12}{1,11}", calificacion, frecuencia[calificacion]);
            Console.ReadLine();
        }// fin de Main
    }// fin de la clase EncuestaEstudiantil
}
