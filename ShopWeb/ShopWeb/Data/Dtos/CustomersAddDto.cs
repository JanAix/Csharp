using System.ComponentModel.DataAnnotations;

namespace ShopWeb.Data.Dtos
{
    public record CustomersAddDto {

        [Display(Name = "ID")]
        [Key] public int? custid{ get; set; }

        [Display(Name ="Compañia")]
        public string companyname { get; set; }
        [Display(Name = "Nombre")]
        public string contactname { get; set; }
        [Display(Name = "Titulo")]
        public string contacttitle { get; set; }
        [Display(Name = "Dirrecion")]
        public string address { get; set; }
        [Display(Name = "Correo")]
        public string email { get; set; }
        [Display(Name = "Ciudad")]
        public string city { get; set; }
        [Display(Name = "Region")]
        public string? region { get; set; }
        [Display(Name = "Codigo Ciudad")]
        public string? postalcode { get; set; }
        [Display(Name = "Pais")]


        public string country { get; set; }
        [Display(Name = "Telefono")]
        public string phone { get; set; }
        [Display(Name = "Fax")]
        public string? fax { get; set; }
        [Display (Name = "Fecha")]
        public DateTime creation_date { get; set; }
        [Display (Name ="Usuario")]
        public int creation_user { get; set; }
        public bool delete = false;




    }
}
