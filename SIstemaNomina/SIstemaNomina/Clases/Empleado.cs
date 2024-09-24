using System;


namespace SIstemaNomina.Clases
{
    public abstract class Empleado
    {
        private string _Primernombre;
        private string _Apellido;
        private string _NumeroDeSeguroSocial;
        


        public string? primerNombre
        {
            get { return _Primernombre; }

            set { _Primernombre = value; }

        }
        public string? apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string numeroDeSeguroSocial
        {

            get { return _NumeroDeSeguroSocial; }
            set {
                _NumeroDeSeguroSocial = value;
            }
        }


        public void Asignar()

        {

            try
            {
                Console.WriteLine("Ingrese Su Datos\n");
                Console.WriteLine("Ingrese su Primer Nombre");
                _Primernombre = Console.ReadLine();
                Console.WriteLine("Ingrese Su Apellido");
                _Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Su NSS");
                _NumeroDeSeguroSocial = Console.ReadLine();


            }
            catch (Exception)
            {

                throw;

            }
            
            
        }

        public override string ToString()
        {

            return string.Format("Nombre:{0}\nApellido:{1}\nNSS:{2}",primerNombre, apellido, numeroDeSeguroSocial);
        }

        public abstract decimal Calcular(); 
            
            
    }
}
