using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaNomina.Clases
{
    public class EmpleadoAsalariado: Empleado
    {
        
        public decimal salarioSemanal {  get; private set; }



        public void Asignar()
        {
            decimal a;
            string entrada;
             base.Asignar();
            try
            {

            
            Console.WriteLine("Ingrese El Salario Semanal:");
            entrada= Console.ReadLine();
            if (entrada== string.Empty)
            {
                Console.WriteLine("Campo Requerido");
                return;
            }
            if (!decimal.TryParse(entrada, out a))
                {
                Console.WriteLine("Campo Requerido");
            } else
            {
                salarioSemanal = decimal.Parse(entrada);
            }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override decimal Calcular()
        {

            return salarioSemanal;
        }

        public override string ToString()
        {
            return String.Format("\nEmpleado Asalariado\n\n{0}\n{1}:{2:C}", base.ToString(),"Salario Semanal",salarioSemanal);
        }




    }




    }

   


