using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class OperacionPract1
    {

        public void sumar()
        {

            try
            {
                int nummero1 = 0;
                int numero2 = 0; ;
                Console.WriteLine("Suma");

                Console.WriteLine("Ingrese un numero");
                nummero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                numero2 = int.Parse(Console.ReadLine());

                int resultado = (nummero1 + numero2);

                Console.WriteLine("La suma de los datos ingresados son:{0}", resultado);
            }
            catch (Exception)
            {
                Console.WriteLine("Debe de ser un numero");
                Console.ReadKey();  
                Console.Clear();
                sumar();
            }


        }

        public void producto()
        {

            try
            {
                int nummero1=0
                    , numero2=0;
                Console.WriteLine("producto");

                Console.WriteLine("Ingrese un numero");
                nummero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                numero2 = int.Parse(Console.ReadLine());

                int resultado = (nummero1 * numero2);

                Console.WriteLine("EL producto de los datos ingresados son:{0}", resultado);
            }
            catch (Exception)
            {
                Console.WriteLine("Debe ser un numero");
                Console.ReadLine();
                Console.Clear();
                producto();
            }
        }

    }
}


    

