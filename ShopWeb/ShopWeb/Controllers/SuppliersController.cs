using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWeb.Data.Dtos;
using ShopWeb.Data.Entities;
using ShopWeb.Data.Interfaces;

namespace ShopWeb.Controllers
{
    public class SuppliersController : Controller
    {

        private readonly ISuppliers suppliers;

        // GET: CategoryController


        public SuppliersController(ISuppliers supplier)

        {
            this.suppliers = supplier;
        }

        // GET: SuppliersController
        public ActionResult Index()
        
        {

            var suppliers = this.suppliers.GetSuppliers();

            return View(suppliers);
        }

        // GET: SuppliersController/Details/5
        public ActionResult Details(int id)
        {

            try
            {
                var sup = this.suppliers.GetSuppliersById(id);
                return View(sup);

            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: SuppliersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuppliersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuppliersAddDto addDto)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    addDto.Creation_date = DateTime.Now;
                    addDto.Creation_user = 2;
                    addDto.Delete = false;

                    this.suppliers.SaveSuppliers(addDto);

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

        // GET: SuppliersController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var sup = suppliers.GetSuppliersById(id);

                if (sup == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                var update = new SuppliersUpdateDto
                {
                    supplierid = id,
                    companyname = sup.companyname,
                    contactname = sup.contactname,
                    contacttitle = sup.contacttitle,
                    Address = sup.address,
                    City = sup.city,
                    Region = sup.region,
                    Postalcode = sup.postalcode,
                    Phone = sup.phone,
                    Fax = sup.fax,
                    Country = sup.country,
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

        // POST: SuppliersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SuppliersUpdateDto updateDto)
        {

        try
        {
            updateDto.modify_date = DateTime.Now;
            updateDto.modify_user = 2;
            this.suppliers.UpdateSuppliers(updateDto);
            return RedirectToAction(nameof(Index));

        }

        catch
        {
            throw new Exception("Hubo un error");
        }
    }

        // GET: SuppliersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuppliersController/Delete/5
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
