using System;


namespace Ejemplo1
{/// <summary>
/// Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se encuentra dicho punto (concepto matemático, primer cuadrante si x e y son positivas, si x<0 e y>0 segundo cuadrante, etc.
/// </summary>
    public class Punto
    {
        #region atributos


        private double _x;
        private double _y;
        #endregion

        #region proiedades
        public double x
        {
            get { return _x; }

            set { _x = value; }
        }


        public double y {
            get
            { return _y; }


            set
            { _y = value; }

        }
        #endregion

        #region Metodos

        


        // Método para cargar los valores de x e y
        public void CargarValores()
        {
            try
            {


                string entrada = string.Empty;
                Console.WriteLine("SABER CUADRANTE");
                Console.WriteLine();


                Console.WriteLine("Ingrese las coordenadas del Eje X:");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                }
                if (!double.TryParse(entrada, out _x))
                {
                    Console.WriteLine("Dato Invalido");
                }
                _x = double.Parse(entrada);

                Console.WriteLine("Ingrese las coordenadas del Eje Y:");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                }
                if (!double.TryParse(entrada, out _y))
                {
                    Console.WriteLine("Dato Invalido");
                }
                _y = double.Parse(entrada);




            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error intentalo nuevamente");
                Console.ReadKey();
                Console.Clear();
                CargarValores();
            }
           
        }

        // Método para determinar en qué cuadrante se encuentra el punto
        public string Cuadrante() 

        {
            

                if (x > 0 && y > 0)
                {
                    return "Primer cuadrante";
                }
                else if (x < 0 && y > 0)
                {
                    return "Segundo cuadrante";
                }
                else if (x < 0 && y < 0)
                {
                    return "Tercer cuadrante";
                }
                else if (x > 0 && y < 0)
                {
                    return "Cuarto cuadrante";
                }
                else if (x == 0 && y != 0)
                {
                    return "Sobre el eje Y";
                }
                else if (x != 0 && y == 0)
                {
                    return "Sobre el eje X";
                }
                else
                {
                    return "Origen";
                }
            
            
        }
        // Método para imprimir el cuadrante en la consola
        public void ImprimirCuadrante()
        {
            Console.Write($"La coordenada esta en el : ");
            Console.Write(Cuadrante());
        }
        #endregion
    }



}
