namespace ShopWeb.Data.Dtos
{
    public record SuppliersRemoveDto
    {

        public int supplierid { get; set; }
        public string companyname { get; set; }

        public string contactname { get; set; }

        public string contacttitle { get; set; }

        public DateTime delete_date { get; set; }

        public bool deleted { get; set; }


    }
}
