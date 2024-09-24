namespace ShopWeb.Data.Base
{

    public abstract class AEntity
    {
        public AEntity()
        {
            Creation_date = DateTime.Now;
            Deleted = false;
        }

        public int Creation_user { get; set; }
        public DateTime Creation_date { get; set; }
        public DateTime? Modify_date { get; set; }
        public int?Modify_user { get; set; }
        public int? Delete_user { get; set; }
        public DateTime? Delete_date { get; set; }
        public bool? Deleted { get; set; }
    }
}
