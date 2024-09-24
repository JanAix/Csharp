namespace ShopWeb.Data.Dtos
{
    public record CategoriesRemoveDto
    {


        public int categoryid { get; set; }
        public string categoryname { get; set; }

        public string description { get; set; }

        public int delete_user { get; set; }

        public DateTime delete_date { get; set; }

        public bool deleted { get; set; }



    }
    
}
