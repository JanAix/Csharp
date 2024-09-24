using System.ComponentModel.DataAnnotations;

namespace ShopWeb.Data.Dtos

{
    public record  CategoriesAddDto
    {

        [Display(Name = "ID")]
       [Key] public int categoryid { get; set; }

        [Display(Name = "Categoria")]

        public string categoryname { get; set; }


        [Display(Name = "Nombre")]

        public string description { get; set; }

        [Display(Name = "Fecha")]


        public DateTime creation_date { get; set; }


        [Display(Name = "Usuario")]

        public int creation_user { get; set; }

        public bool delete = false;




    }
}
