using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWeb.Data.Daos;
using ShopWeb.Data.Dtos;
using ShopWeb.Data.Entities;
using ShopWeb.Data.Interfaces;

namespace ShopWeb.Controllers
{
    public class ProductsController : Controller
    {


        private readonly IProducts products;

        // GET: CategoryController


        public ProductsController(IProducts Product)

        {
            this.products = Product;
        }

        // GET: ProductsController




        public ActionResult Index(int id)
        {
            var product = this.products.GetProducts();
            return View(product);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var prodt = products.GetProductsById(id);
                return View(prodt);

            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductsAddDto addDto)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    addDto.creation_date = DateTime.Now;
                    
                    

                    this.products.SaveProducts(addDto);

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

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var produ = products.GetProductsById(id);

                if (produ == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                var update = new ProductUpdateDto
                {
                    productid = id,
                    productname = produ.productname,
                    supplierid = produ.supplierid,
                    categoryid = produ.categoryid,
                    unitprice = Convert.ToDecimal(produ.unitprice),
                    discontinued = produ.discontinued,
                    modify_date = DateTime.Now,
                    
                };







                return View(update);
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductUpdateDto updateDto)
        {
            try
            {
                updateDto.modify_date = DateTime.Now;
                this.products.UpdateProducts(updateDto);
                return RedirectToAction(nameof(Index));

            }

            catch
            {
                throw new Exception("Hubo un error");
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
