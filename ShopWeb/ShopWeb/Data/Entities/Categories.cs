using ShopWeb.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ShopWeb.Data.Entities
{
    public  sealed class Categories: AEntity
    {

        [Key] public int categoryid{ get; set; }

        public string Categoryname { get; set; }

        public string Description { get; set; }

    }
}
