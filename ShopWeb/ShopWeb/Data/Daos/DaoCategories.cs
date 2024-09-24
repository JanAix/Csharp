using ShopWeb.Data.Context;
using ShopWeb.Data.Dtos;
using ShopWeb.Data.Entities;
using ShopWeb.Data.Interfaces;

namespace ShopWeb.Data.Daos
{
    public class DaoCategories : ICategories

    {
        private readonly ShopWebContext shopWebDb;
        private readonly ILogger<DaoCategories> logger;

        public DaoCategories(ShopWebContext shopWebDb,
                             ILogger<DaoCategories> logger)

        {

            this.shopWebDb = shopWebDb ?? throw new ArgumentNullException(nameof(shopWebDb));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));


        }

        public void DeleteCategorie(CategoriesRemoveDto categoriesRemove)
        {
            try
            {
                var dcategoria = this.shopWebDb.Categories.Find(categoriesRemove);
                if (dcategoria == null)
                {
                    throw new Exception("Hubo un error");
                }

                dcategoria.Deleted = true;
                 shopWebDb.Categories.Remove(dcategoria);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CategoriesAddDto>GetCategories()
        {
            List<CategoriesAddDto> categorias = new List<CategoriesAddDto>();
            try
            {
                categorias = (from categ in this.shopWebDb.Categories
                              where categ.Deleted == false
                              orderby categ.Creation_date ascending
                              select new CategoriesAddDto()
                              {
                                 categoryid = categ.categoryid,
                                  categoryname = categ.Categoryname,
                                  description = categ.Description,
                                  creation_date = categ.Creation_date,
                                  creation_user = categ.Creation_user


                              }).ToList();
            }
            catch (Exception ex)
            {

                this.logger.LogError("Error", ex.ToString());

            }
            return categorias;
        }

        public CategoriesAddDto GetCategoriesById(int Categoryid)
        {
            CategoriesAddDto categorias = new CategoriesAddDto();
            try
            {
                var categoria = this.shopWebDb.Categories.Find(Categoryid);
                if (categoria == null)
                    throw new Exception("No se encuenta");

                categorias.categoryid = categoria.categoryid;
                categorias.categoryname = categoria.Categoryname;
                categorias.creation_date = categoria.Creation_date;
                categorias.creation_user = categoria.Creation_user;
                categorias.description = categoria.Description;
            }
            catch (Exception ex)
            {

                this.logger.LogError("Hubo un error", ex.ToString());
            }
            return categorias;
        }

        public void SaveCategorie(CategoriesAddDto categoriesAdd)
        {
            try
            {
                if (categoriesAdd == null)
                    throw new Exception("Error");


                if (this.shopWebDb.Categories.Any(categ => categ.Categoryname == categoriesAdd.categoryname))
                throw new Exception("Ya existe");

                Categories categories = new Categories()
                {
                    

                    categoryid = categoriesAdd.categoryid,
                    Categoryname = categoriesAdd.categoryname,
                    Description = categoriesAdd.description,
                    Creation_date = categoriesAdd.creation_date,
                    Creation_user = categoriesAdd.creation_user
                    

                };

                    this.shopWebDb.Categories.Add(categories);
                    this.shopWebDb.SaveChanges();
                
          
                }




            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateCategorie(CategoriesUpdateDto categoriesUpdate)
        {
            try
            {
                Categories categoria = this.shopWebDb.Categories.Find(categoriesUpdate.categoryid);
                if (categoria == null)
                    throw new Exception("Error");

                categoria.categoryid = categoriesUpdate.categoryid;
                categoria.Categoryname = categoriesUpdate.categoryname;
                categoria.Description = categoriesUpdate.description;
                categoria.Modify_user = categoriesUpdate.modify_user;
                categoria.Modify_date = categoriesUpdate.modify_date;
                


                this.shopWebDb.Categories.Update(categoria);
                this.shopWebDb.SaveChanges();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
