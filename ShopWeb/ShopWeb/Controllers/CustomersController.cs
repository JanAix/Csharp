using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWeb.Data.Dtos;
using ShopWeb.Data.Entities;
using ShopWeb.Data.Interfaces;

namespace ShopWeb.Controllers
{
    public class CustomersController : Controller
  
    {
        private readonly ICustomers Customer1;

        public CustomersController(ICustomers customers) { 
        
        this.Customer1 = customers;
        }

        // GET: CustomersController
        public ActionResult Index()
         {

           var custome= this.Customer1.GetCustomers();
             return View(custome);
        }

        // GET: CustomersController1/Details/5
        public ActionResult Details(int id)
        {

            try
            {
                var customer = this.Customer1.GetCustomersById(id);
                return View(customer);

            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: CustomersController1/Create
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

        // POST: CustomersController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomersAddDto addDto)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    addDto.creation_date = DateTime.Now;
                    addDto.creation_user = 2;
                    addDto.delete = false;

                    this.Customer1.SaveCustomers(addDto);

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

        // GET: CustomersController1/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var custome = Customer1.GetCustomersById(id);

                if (custome == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                var update = new CustomersUpdateDto
                {
                    companyname = custome.companyname,
                    contactname = custome.contactname,
                    contacttitle = custome.contacttitle,
                    Address = custome.address,
                    Email = custome.email,
                    City = custome.city,
                    Region = custome.region,
                    Postalcode = custome.postalcode,
                    Phone = custome.phone,
                    Fax = custome.fax,
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

        // POST: CustomersController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomersUpdateDto customersUpdate)
        {
            try
            {
                customersUpdate.modify_date = DateTime.Now;
                customersUpdate.modify_user = 2;
                this.Customer1.UpdateCustomers(customersUpdate);
                return RedirectToAction(nameof(Index));

            }

            catch
            {
                throw new Exception("Hubo un error");
            }
        }

        // GET: CustomersController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomersController1/Delete/5
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
