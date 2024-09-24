using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaNomina.Clases
{
    public class EmpleadoPorComision: Empleado
    {
        public decimal ventasBrutas {  get; private set; }
        public decimal? tafiraDeComision {  get; private set; }



        public void Asignar()
        {
            string entrada;
            decimal a;
            decimal b;
            base.Asignar();
            try
            {
                Console.WriteLine("Ingrese La venta Bruta Del Mes");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    return;
                }
                if (!decimal.TryParse(entrada, out a))
                {

                    Console.WriteLine("Dato Invalido");
                    return;

                }
                else
                {
                    ventasBrutas = decimal.Parse(entrada);
                }
               Console.WriteLine("Ingrese La Tarifa Por Comision");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo requerido");
                    Console.ReadKey();
                    return;
                }
                if (!decimal.TryParse(entrada, out a))
                {

                    Console.WriteLine("Dato Invalido");
                    return;

                }
                else
                {
                    if (tafiraDeComision <= 0)
                    {
                        Console.WriteLine("La Tafifa Debe Ser Diferente A 0");
                        return;
                    }
                    tafiraDeComision = decimal.Parse(entrada);
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        public override decimal Calcular()
        {
           
            
            return Convert.ToDecimal(tafiraDeComision * ventasBrutas);
        }


        public override string ToString()
        {
            return string.Format("\nEmpleado Por Comision\n{0}\nVentas Brutas:{1:C}\nTafifa De Comision:{2}\n\nTotal:{3:C}", base.ToString(), ventasBrutas,tafiraDeComision,Calcular());
        }
    }
}
