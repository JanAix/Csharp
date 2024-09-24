using System;

namespace Ejemplo2
{
    /// <summary>
    /// Crea una clase Libro con las propiedades Titulo, Autor y Paginas.

    ///  Implementa un método MostrarInformacion que imprima la información del libro.
    ///Implementa un método EsLargo que devuelva true si el libro tiene más de 500 páginas, o false en caso contrario.
    /// </summary>
    public class Libro
    {

        #region Atributo
        private string _titulo;
        private string _autor;
        private int _paginas;

        #endregion

        #region Propiedades

        public string titulo
        {
            get { return _titulo; }

            set { _titulo = value; }
        }
        public string autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public int paginas
        {
            get { return _paginas; }
            set { _paginas = value; }


            #endregion




        }

        #region Metodos

        public void Asignar()
        {
            try
            {



                String entrada = string.Empty;
                Console.WriteLine("Bienvenido a Libreria Alix\n \n");
                Console.WriteLine("Ingrese el titulo del libro:");
                entrada = Console.ReadLine();

                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    Console.Clear();
                    Asignar();
                }

                _titulo = entrada;

                Console.WriteLine("Ingrese el titulo del autor:");
                entrada = Console.ReadLine();

                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    Console.Clear();
                    Asignar();

                }
                _autor = entrada;

                Console.WriteLine("Ingrese la cantida de paginas del libro:");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    Console.Clear();
                    Asignar(); 
                }
                if (!int.TryParse(entrada, out _paginas))
                {
                    Console.WriteLine("Dato Invalido");
                    Console.ReadKey();
                    Console.Clear();
                    Asignar();
                }
                _paginas = int.Parse(entrada);

            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error, intentalo nuevamente");
                Console.ReadKey();
                Console.Clear();
                Asignar();
            }

        }


        public void MostrarInformacion()
        {

            Console.WriteLine("Informacion Del Libro \n \n");
            Console.Write("Titulo: ");
            Console.Write(titulo);
            Console.WriteLine("\n");
            Console.Write("Autor: ");
            Console.Write(autor);
            Console.WriteLine("\n");
            Console.Write("Paginas: ");
            Console.Write(paginas);
            Console.WriteLine("\n");
            if (EsLArgo(paginas) == true)
            {
                Console.WriteLine("El libro tiene mas de 500 paginas");
            }
            else
            {
                Console.WriteLine("El libro tiene menos de 500 paginas");
            }

            }

        public bool EsLArgo(int cantidad)
        {

            if (cantidad > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
       
        

            #endregion

        
    }
}
