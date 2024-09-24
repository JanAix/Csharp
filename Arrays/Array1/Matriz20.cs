using System;


namespace Array1
    
{
    public class Matriz20
    {
        /// <summary>
        /// Escribe un programa que cree una matriz de 20 elementos de tipo entero e inicialice cada uno de los elementos con un valor igual al índice del elemento multiplicado por 5. Imprime los elementos en la consola.
        /// </summary>


        public void Array()
        {

            int[] matriz = new int[20];


            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = i * 5;
            }

            
            foreach (int elemento in matriz)
            {
                Console.WriteLine(elemento);
            }

        }
}
}
