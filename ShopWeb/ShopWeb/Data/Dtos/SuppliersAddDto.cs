using ShopWeb.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ShopWeb.Data.Dtos
{
    public record SuppliersAddDto
    {
        [Display (Name="ID" )]
        public int?  supplierid { get; set; }
        [Display(Name = "NOMBRE")]
        public string companyname { get; set; }
        [Display(Name = "COMPAÑIA")]
        public string contactname { get; set; }
        [Display(Name = "TITULO")]
        public string contacttitle { get; set; }
        [Display(Name = "DIRECCION")]
        public string address{ get; set; }
       
        [Display(Name = "CIUDAD")]
        public string city{ get; set; }
        [Display(Name = "REGION")]
        public string? region { get; set; }
        [Display(Name = "CODIDO DE CIUDAD")]
        public string? postalcode { get; set; }
        [Display(Name = "PAIS")]

        public string country { get; set; }
        [Display(Name = "TELEFONO")]
        public string phone { get; set; }
        [Display(Name = "FAX")]
        public string?fax { get; set; }
        [Display(Name = "CREACION")]
        public DateTime Creation_date { get; set; }
        [Display(Name = "USUARIO")]
        public int Creation_user { get; set; }

        public bool Delete { get; set; }
    }
}
