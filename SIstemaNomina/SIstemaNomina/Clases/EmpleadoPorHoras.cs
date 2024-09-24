using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaNomina.Clases
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal sueldoPorHoras { get; set; }

        public int horaTrabajadas { get; set; }



        public void Asignar()
        {
            decimal a;
            int b;
            string entrada;

            try
            {


                base.Asignar();
                Console.WriteLine("Ingrese El Valor Del Sueldo Por Hora");
                entrada = Console.ReadLine();

                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    return;
                }
                if (!decimal.TryParse(entrada, out a)) {

                    Console.WriteLine("Dato Invalido");
                    return;

                }
                else
                {
                    sueldoPorHoras = decimal.Parse(entrada);
                }
                Console.WriteLine("Ingrese Las Horas Trabajadas");
                entrada = Console.ReadLine();

                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    return;
                }
                if (!int.TryParse(entrada, out b))
                {

                    Console.WriteLine("Dato Invalido");
                    return;

                }
                else
                {
                    horaTrabajadas = int.Parse(entrada);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error");
            }



        }


        public override decimal Calcular()

        {
            try
            {


                if (horaTrabajadas <= 40)
                {

                    return sueldoPorHoras * horaTrabajadas;

                }
                else
                {

                    return (40 * sueldoPorHoras) + ((horaTrabajadas - 40) * sueldoPorHoras * 1.5M);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    public override string ToString()
        {
           return (string.Format("\nEmpleado Por Horas\n{0}\nSueldo por hora:{1:C}\nHoras:{2}\nTotal:{3:C}", base.ToString(), sueldoPorHoras, horaTrabajadas,Calcular()));
          

    }
}


