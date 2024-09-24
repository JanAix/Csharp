using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejemplo3
{
    /// <summary>
    /// Crea una clase Alumno con las propiedades Nombre, Matricula, Carrera y Calificaciones (una lista de enteros).

  //  Implementa un método CalcularPromedio que devuelva el promedio de las calificaciones.
    //Implementa un método MostrarInformacion que imprima el nombre, la matrícula, la carrera y el promedio del alumno
    //Crea instancias de la clase Alumno, asigna valores a las propiedades y muestra la información.
    /// </summary>
    public class Alumno
    {
        #region Atributo

        private string _nombre;
        private string _matricula;
        private string _carrera;
        private List<int> _calificaciones;
        #endregion

        #region Propiedades

        public string nombre
        {

            get { return _nombre; }
            set { _nombre = value; }
        }

        public string matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public string carrera
        {
            get { return _carrera; }
            set { _carrera = value; }
        }

        public List<int> calificaciones
        {
            get; set;
        }
            //get {return _calificaciones = new List<int>(); }
            //set { _calificaciones = value; }}

        #endregion

        #region Metodos


        public double CalcularPromedio()
        {
            if (calificaciones.Count == 0)
            {
                return 0;
            }
            return calificaciones.Average();
        }

        public void MostrarInformacion()
        {
            double promedio = CalcularPromedio();
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Carrera: {carrera}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }
        #endregion

    }
}
