using System;

namespace Ejemplo
{
    public class LibroCalificaciones


    {// Fig. 4.7: LibroCalificaciones.cs 
     // Clase LibroCalificaciones que contiene una variable de instancia cursoNombre 
     // y una propiedad para obtener (get) y establecer (set) su valor.  

        private string nombreCurso;
        // nombre del curso para este  LibroCalificaciones  

        // propiedad para obtener

        public string NombreCurso
        {
            get
            {

                return nombreCurso;
            }
            set
            {
                nombreCurso = value;
            }

        }
  //  fin de la propiedad NombreCurso  

//  public void MostrarMensaje()
//// usa la propiedad Nombreurso para obtener el
//// nombre del curso que representa este LibroCalificaciones 
// Console.WriteLine("iBienvenido al libro de calificaciones para\nf0]!"  NombreCurso );
// // muestra Ta propiedad NombreCurso  // fin del método MostrarMensaje  fin de la clase LibroCalificaciones




        // Fig. 4.1: LibroCalificaciones.cs 
        // Declaración de una clase con un método.

        // muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
        public void MostrarMensaje() {
            Console.WriteLine("¡Bienvenido al Libro de calificaciones!");
        }
        // fin del método MostrarMensaje 
        // fin de 1a clase LibroCalificaciones

        // Fig. 4.4: LibroCalificaciones.cs
        //Declaración de la clase con un método que tiene un parámetro. u

        public void MostrarMensaje(string nombreCurso) {
            Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}", nombreCurso);
            // fin del método MostrarMensaje 
            // fin de la clase LibroCalificaciones
        }






    }
}
