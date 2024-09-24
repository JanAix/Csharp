namespace ShopWeb.Data.Dtos
{
    public record ProductsRemoveDto
    {



        public int productid { get; set; }

        public string productname { get; set; }

        public int delete_user { get; set; }

        public DateTime delete_date { get; set; }

        public bool deleted { get; set; }


    }
}
