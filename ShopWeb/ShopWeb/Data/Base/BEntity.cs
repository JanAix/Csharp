using ShopWeb.Data.Base;

namespace ShopWeb.Data.Base
{
    public abstract class BEntity:AEntity
    {
        public string Contactname { get; set; }

        public string Contacttitle { get => Contactname;

            set { 
                if(value.Length > 30)
           

                throw new ArgumentException("Ha superado el limite de letras");
            }
                 
                }
        public string Address { get => Address; 
            set
            {
                if ((value.Length > 50) || string.IsNullOrEmpty(value))
                    throw new ArgumentException("EL valor execede  el maximo o es nulo");

            }
                }

       

        public string ?City { get => City; 
            set
            {
                if ((value.Length > 15) || string.IsNullOrEmpty(value))
                    throw new ArgumentException("EL valor execede  el maximo o es nulo");
            }
            }
        public string? Region { get => Region;

            set {
                if ((value.Length > 15) || string.IsNullOrEmpty(value))
                    throw new ArgumentException("EL valor execede  el maximo o es nulo");
            }
                
                
                }

        public string? Postalcode { get; set; }


        public string? Country { get; set; }

        public string Phone { get; set; }

        public string? Fax { get; set; }
        
    }
}
