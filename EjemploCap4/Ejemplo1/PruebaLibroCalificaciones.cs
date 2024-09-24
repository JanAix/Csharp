using System;


namespace Ejemplo
{
    public class PruebaLibroCalificaciones
    {

        // E1 método Main comienza la ejecución del programa
        public  void ver() { 

            // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones  

            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

            // muestra el valor inicial de NombreCurso
          Console.WriteLine("Por favor escriba el nombre del curso:");
            string elNombre = Console.ReadLine();
            // lee una línea de texto
            miLibroCalificaciones.NombreCurso = elNombre;

            Console.WriteLine("E1 nombre inicial del curso es: {0}", miLibroCalificaciones.NombreCurso );
           
            
           // pide y lee e1 nombre del curso

            

            // establece el nombre usando una propiedad 
            Console.WriteLine(); // imprime en pantalla una línea en blanco

            // llama al método MostrarMensaje de miLibroCalificaciones

            miLibroCalificaciones.MostrarMensaje();  
            // fin de Main  
                                                     
            

        }
    }
}
