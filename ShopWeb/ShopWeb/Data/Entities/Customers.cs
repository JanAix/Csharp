using ShopWeb.Data.Base;
using System.ComponentModel.DataAnnotations;


namespace ShopWeb.Data.Entities
{
    public sealed class Customers : BEntity
    {

        [Key] public int custid{ get; set; }
        public string companyname { get; set; }

        public string email { get; set; }


       
    }
}
