namespace ShopWeb.Data.Dtos
{
    public record CustomersRemoveDto
    {



        public int custid { get; set; }

        public int delete_user { get; set; }

        public DateTime delete_date { get; set; }

        public bool deleted { get; set; }

    }
}
