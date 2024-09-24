using ShopWeb.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ShopWeb.Data.Entities
{
    public sealed class Products: AEntity
    {
        
       [Key] public int Productid { get; set; }

        public string Productname { get; set; }

        public int Supplierid {  get; set; }  

        public int Categoryid { get; set; }

        public decimal Unitprice { get; set; }

        public Boolean Discontinued { get; set; }

    }
}
