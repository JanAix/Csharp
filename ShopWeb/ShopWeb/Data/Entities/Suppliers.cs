using ShopWeb.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ShopWeb.Data.Entities
{
    public sealed class Suppliers:BEntity
    {

        [Key] public int Supplierid { get; set; }

        public string Companyname { get; set; }

     


    }
}
