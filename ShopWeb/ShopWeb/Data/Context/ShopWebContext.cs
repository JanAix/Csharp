using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ShopWeb.Data.Entities;

namespace ShopWeb.Data.Context
{
    public class ShopWebContext: DbContext
    {
        public ShopWebContext(DbContextOptions <ShopWebContext> options): base(options) 
        {
           
             

        }


        public DbSet<Categories> Categories { get; set; }   

        public DbSet<Customers> Customers { get; set; } 

        public DbSet<Products> Products { get; set; }   

        public DbSet<Suppliers> Suppliers { get; set; }




    }
}
