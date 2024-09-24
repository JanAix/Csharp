namespace ShopWeb.Data.Dtos
{
    public record CategoriesUpdateDto
    {

        public int categoryid { get; set; }
        public string categoryname { get; set; }

        public string description { get; set; }


        public DateTime modify_date { get; set; }

        public int modify_user { get; set; }


        public bool delete { get; set; }

    }
}
