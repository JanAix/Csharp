
using Ejemplo3;
Console.WriteLine("Estudiante 1");
Alumno alumno= new Alumno();
alumno.nombre = "Juan Perez";
alumno.carrera = "Sistema";
alumno.matricula = "24-5js-5d";
alumno.calificaciones = new List<int> { 89, 69, 100, 98, 57, 98, 99, 78 };
alumno.MostrarInformacion();
Console.WriteLine("\n");

Console.WriteLine("Estudiante 2");
Alumno alumno2= new Alumno();
alumno2.nombre = "Maria Frias";
alumno2.carrera = "Educacion";
alumno2.matricula = "21-87E-30";
alumno2.calificaciones = new List<int> { 79, 59, 60, 94, 87, 78, 79, 78 };
alumno2.MostrarInformacion();

Console.ReadLine();