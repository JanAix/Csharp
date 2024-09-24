namespace ShopWeb.Data.Dtos
{
    public record SuppliersUpdateDto
    {

        public int supplierid { get; set; }
        public string companyname { get; set; }

        public string contactname { get; set; }

        public string contacttitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string? Region { get; set; }

        public string? Postalcode { get; set; }


        public string Country { get; set; }

        public string Phone { get; set; }

        public string? Fax { get; set; }

        public DateTime modify_date { get; set; }

        public int modify_user { get; set; }

    }
}
