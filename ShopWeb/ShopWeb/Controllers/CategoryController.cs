using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopWeb.Data.Dtos;
using ShopWeb.Data.Entities;
using ShopWeb.Data.Interfaces;

namespace ShopWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategories categories;
        private readonly DbContext db;

        // GET: CategoryController


        public CategoryController(ICategories categories) 
        
       {
            this.categories = categories;
        }
        public ActionResult Index()
        {
            var categors = this.categories.GetCategories();
               return View(categors);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var categors = this.categories.GetCategoriesById(id);
                return View(categors);

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        // GET: CategoryController/Create
        public ActionResult Create()
            
        {
            try
            {
               
                return View();
            }
            catch
            {
                return View(Index);
            }


    }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriesAddDto addDto)
        {
            
                try
                {

                if (ModelState.IsValid)
                {

                    addDto.creation_date = DateTime.Now;
                    addDto.creation_user = 2;
                    addDto.delete = false;

                    this.categories.SaveCategorie(addDto);

                    return RedirectToAction(nameof(Index));

                }
                else
                {

                    return View(addDto);

                }
                }
                catch
                {
                    return View();
                }

              
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
  {

            try
            {
                var category = categories.GetCategoriesById(id);

                if (category == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                var update = new CategoriesUpdateDto
                {

                    categoryid = category.categoryid,
                    description = category.description,
                    categoryname = category.categoryname,
                    modify_date = DateTime.Now,
                    modify_user = 2,    
                };
                  


               
                


                return View(update);
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriesUpdateDto updateDto)
        {
            try
            {
                updateDto.modify_date = DateTime.Now;
                updateDto.modify_user = 2;
                this.categories.UpdateCategorie(updateDto);
                return RedirectToAction(nameof(Index));

            }
               
            catch
            {
                throw new Exception("Hubo un error");
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var category = categories.GetCategoriesById(id);

                if (category == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                var remov = new CategoriesRemoveDto
                {

                    categoryid = category.categoryid,
                    description = category.description,
                    categoryname = category.categoryname,
                    delete_date = DateTime.Now,
                    delete_user = 2,
                };

                return View(remov);
            }
            catch {


                throw new Exception("hubo un eeror");
            }


            }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CategoriesRemoveDto cat)
        {
            try
            {

                var category = new CategoriesRemoveDto();
                if (category != null)
                {
                   var categoriesRemoveDto = new CategoriesRemoveDto
                    {
                        categoryid = category.categoryid, 
                       description = category.description,
                       categoryname=category.categoryname,
                       deleted = true,

                    
                    };
                    categories.DeleteCategorie(categoriesRemoveDto);
                   
                    
                }
                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View();
            }
        }
    }
}
