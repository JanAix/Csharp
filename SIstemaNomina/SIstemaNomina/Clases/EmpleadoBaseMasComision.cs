using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaNomina.Clases
{
    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {

        public decimal salarioBase { get; set; }


        public void Asignar()
        {
            string entrada;
            decimal a;
            base.Asignar();

            try
            {


                Console.WriteLine("Ingrese El Salario Base:");
                entrada = Console.ReadLine();
                if (entrada == string.Empty)
                {
                    Console.WriteLine("Campo Requerido");
                    return;
                }
                if (!decimal.TryParse(entrada, out a))
                {
                    Console.WriteLine("Campo Requerido");
                }
                else
                {
                    salarioBase = decimal.Parse(entrada);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override decimal Calcular()
        {
            return salarioBase + base.Calcular();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\n{2}:{3:C}", "Salario Base +", base.ToString(), "Salario Base", salarioBase.ToString());
        }
    }
}