using Microsoft.Identity.Client;
using ShopWeb.Data.Context;
using ShopWeb.Data.Dtos;
using ShopWeb.Data.Entities;
using ShopWeb.Data.Interfaces;

namespace ShopWeb.Data.Daos
{
    public class DaoProducts : IProducts
    {
        private readonly ShopWebContext shopWebDB;
        private readonly ILogger<DaoProducts> logger;

        public DaoProducts(ShopWebContext shopWebDb,
                             ILogger<DaoProducts> logger)

        {

            this.shopWebDB = shopWebDb ?? throw new ArgumentNullException(nameof(shopWebDb));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));


        }
        public void DeleteProducts(ProductsRemoveDto productsRemove)
        {
            throw new NotImplementedException();
        }

        public List<ProductsAddDto> GetProducts()
        {
            List<ProductsAddDto> productos = new List<ProductsAddDto>();
            try
            {
                productos = (from produt in this.shopWebDB.Products
                             orderby produt.Creation_date ascending
                             select new ProductsAddDto()
                             {
                                 productid = produt.Productid,
                                 productname = produt.Productname,
                                 categoryid = produt.Categoryid,
                                 supplierid = produt.Supplierid,
                                 unitprice = produt.Unitprice,
                                 discontinued = produt.Discontinued,
                                 creation_date = produt.Creation_date,
                                 creation_user = produt.Creation_user


                             }).ToList();
            }
            catch (Exception ex)
            {

                this.logger.LogError("Error", ex.ToString());

            }
            return productos;
        }

        public ProductsAddDto GetProductsById(int Productid)
        {
            ProductsAddDto productos = new ProductsAddDto();
            try
            {
                var producto = this.shopWebDB.Products.Find(Productid);
                if (producto == null)
                    throw new Exception("No se encuenta");

                productos.productid = producto.Productid;
                productos.productname = producto.Productname;
                productos.supplierid = producto.Supplierid;
                productos.categoryid = producto.Categoryid;
                productos.unitprice = producto.Unitprice;
                productos.discontinued = producto.Discontinued;
                productos.creation_date = producto.Creation_date;
                productos.creation_user = producto.Creation_user;


            }
            catch (Exception ex)
            {

                this.logger.LogError("Hubo un error", ex.ToString());
            }
            return productos;
        }

        public void SaveProducts(ProductsAddDto productsAdd)
        {
            try
            {
                if (productsAdd == null)
                    throw new Exception("Error");


                if (this.shopWebDB.Products.Any(prod => prod.Productname == productsAdd.productname))
                    throw new Exception("Ya existe");

                Products productos = new Products()
                {


                    Productname = productsAdd.productname,
                    Discontinued = productsAdd.discontinued,
                    Creation_date = productsAdd.creation_date,
                    Creation_user = productsAdd.creation_user,
                    Unitprice = Convert.ToDecimal(productsAdd.unitprice),
                    Categoryid = productsAdd.categoryid,
                    Supplierid = productsAdd.supplierid

                };

                this.shopWebDB.Products.Add(productos);
                this.shopWebDB.SaveChanges();


            }
            catch (Exception ex)
            {

                logger.LogError(ex.ToString());
            }


        }

        public void UpdateProducts(ProductUpdateDto productsUpdate)
        {
            try
            {
                Products productos = this.shopWebDB.Products.Find(productsUpdate.productid);
                if (productos == null)
                    throw new Exception("Error");


                {
                    productos.Productid = productsUpdate.productid;
                    productos.Productname = productsUpdate.productname;
                    productos.Discontinued = productsUpdate.discontinued;
                    productos.Modify_date = productsUpdate.modify_date;
                    productos.Modify_user = productsUpdate.modify_user;
                    productos.Unitprice = productsUpdate.unitprice;
                    productos.Categoryid = productsUpdate.categoryid;
                    productos.Supplierid = productsUpdate.supplierid;
                };

                this.shopWebDB.Products.Update(productos);
                this.shopWebDB.SaveChanges();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
