using ShopWeb.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace ShopWeb.Data.Dtos
{
    public record ProductsAddDto
    {

        [Display(Name = "ID")]
        public int?productid{ get; set; }
        [Display(Name = "DESCRIPCION")]
        public string productname { get; set; }
        [Display(Name = "CATEGORIA")]
        public int categoryid { get; set; }
        [Display(Name = "SUPLIDOR")]
        public int supplierid { get; set; }
        [Display(Name = "PRECIO")]
        public decimal? unitprice { get; set; }
        [Display(Name = "ESTADO")]
        public bool discontinued { get; set; }
        [Display(Name = "CREACION")]
        public DateTime creation_date { get; set; }
        [Display(Name = "USUARIO")]
        public int creation_user { get; set; }




    }
}
