using System;

namespace Piezas_Practica2
{/// <summary>
/// Crear un programa que cuente cuántas piezas de hierro de un lote, dentro de un rango específico de longitud, son aptas para fabricar perfiles.
/// </summary>
    public class PIEZAS
    {

        public void Fabricacion()
        {
            int cantidad = 0;
            int contador = 1;
            int piezasAptas = 0;
            int piezasNoaptas = 0;
            string dato= string.Empty;
            double longitud;
            const double  max = 2.30;
            const  double min = 1.40;
            Console.WriteLine("Digite la cantidad de piezas \n Nota: rango 1.40 - 2.30");
            dato = Console.ReadLine();
            if (dato == string.Empty) {
                Console.WriteLine("Campo requerido");
            }
            if (int.TryParse(dato, out cantidad))
            {
                cantidad = int.Parse(dato);

            }
            else
            {
                Console.WriteLine("Debe ingresar un numero");
            }
            try
            {
                while (contador <= cantidad)
                {
                    Console.WriteLine("Digite la longitud del metal {0}",contador);
                    dato = Console.ReadLine();
                    if( dato == string.Empty)
                    {
                        Console.WriteLine("Campo Requerido");
                    }
                    if(double.TryParse(dato, out longitud))
                    longitud = Double.Parse(dato);
                    if (longitud <= max && longitud >= min)
                    {
                        piezasAptas++;
                    }
                    else
                    {
                        piezasNoaptas++;
                    }
                    contador++;
                }


                Console.WriteLine("Metales Aptos: {0}, Metales No Aptos: {1}",piezasAptas, piezasNoaptas);

            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error, intente nuevamente");
            }
          
        }

    }
}
