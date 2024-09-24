using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using ShopWeb.Data.Context;
using ShopWeb.Data.Dtos;
using ShopWeb.Data.Entities;
using ShopWeb.Data.Interfaces;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShopWeb.Data.Daos
{
    public class DaoCustomers : ICustomers

    {
        private readonly ShopWebContext shopWebDB;
        private readonly ILogger<DaoCustomers> logger;

        public DaoCustomers(ShopWebContext shopWebDb,
                             ILogger<DaoCustomers> logger)

        {

            this.shopWebDB = shopWebDb ?? throw new ArgumentNullException(nameof(shopWebDb));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));


        }


        public void DeleteCustomers(CustomersRemoveDto customersRemove)
        {
            throw new NotImplementedException();
        }

        public List<CustomersAddDto> GetCustomers()
        {
            List<CustomersAddDto>customer = new List<CustomersAddDto>();
            try
            {
                customer = (from custome in this.shopWebDB.Customers
                            //where custome.Deleted == false
                            orderby custome.Creation_date ascending
                            select new CustomersAddDto()
                            {
                                custid = custome.custid,
                                companyname = custome.companyname,
                                contactname = custome.Contactname,
                                country = custome.Country,
                                contacttitle = custome.Contacttitle,
                                address = custome.Address,
                                email = custome.email,
                                region = custome.Region,
                                phone = custome.Phone,
                                creation_date = custome.Creation_date,
                                creation_user = custome.Creation_user


                            }).ToList();
            }


            catch (Exception ex)
            {
                this.logger.LogError("Error", ex.ToString());
            }

            return customer;

        }

        public CustomersAddDto GetCustomersById(int Custid)
        {
            CustomersAddDto clientes = new CustomersAddDto();
            try
            {
                var cliente = this.shopWebDB.Customers.Find(Custid);
                if (cliente == null)
                    throw new Exception("No se encuenta");

                clientes.custid = cliente.custid;
                clientes.companyname= cliente.companyname;
                clientes.contactname = cliente.Contactname;
                clientes.contacttitle = cliente.Contacttitle;
                clientes.address = cliente.Address;
                clientes.email = cliente.email;
                clientes.city = cliente.City;
                clientes.country = cliente.Country;
                clientes.region = cliente.Region;
                clientes.postalcode = cliente.Postalcode;
                clientes.phone = cliente.Phone;
                clientes.fax = cliente.Fax;
                clientes.creation_date= cliente.Creation_date;
                clientes.creation_user = cliente.Creation_user;
        

            }
            catch (Exception ex)
            {

                this.logger.LogError("Hubo un error", ex.ToString());
            }
            return clientes;
        }

        public void SaveCustomers(CustomersAddDto custommersAdd)
        {
            try
            {
                if (custommersAdd == null)
                    throw new Exception("Error");


                if (this.shopWebDB.Customers.Any(cust => cust.custid == custommersAdd.custid))
                    throw new Exception("Ya existe");

                Customers customer = new Customers()
                {


                   // custid = custommersAdd.custid,
                    companyname = custommersAdd.companyname,
                    Contactname = custommersAdd.contactname,
                    Contacttitle = custommersAdd.contacttitle,
                    Address = custommersAdd.address,
                    email = custommersAdd.email,
                    City = custommersAdd.city,
                    Region = custommersAdd.region,
                    Postalcode = custommersAdd.postalcode,
                    Country = custommersAdd.country,
                    Phone = custommersAdd.phone,
                    Creation_date = custommersAdd.creation_date,
                    Creation_user = custommersAdd.creation_user,
                    Deleted = false,
                  



                };

                this.shopWebDB.Customers.Add(customer);
                this.shopWebDB.SaveChanges();


            }
            catch (Exception)
            {

                throw;
            }


        }

        public void UpdateCustomers(CustomersUpdateDto customersUpdate)
        {
            Customers cliente = this.shopWebDB.Customers.Find(customersUpdate.custid);
            if (cliente == null)
                throw new Exception("Error");


                   cliente.custid = customersUpdate.custid;
            cliente.companyname = customersUpdate.companyname;
            cliente.Contactname = customersUpdate.contactname;
            cliente.Contacttitle = customersUpdate.contacttitle;
            cliente.Address = customersUpdate.Address;
            cliente.email = customersUpdate.Email;
            cliente.City = customersUpdate.City;
            cliente.Region = customersUpdate.Region;
            cliente.Postalcode = customersUpdate.Postalcode;
            cliente.Country = customersUpdate.Country;
            cliente.Phone = customersUpdate.Phone;
            cliente.Creation_date = customersUpdate.modify_date;
            cliente.Creation_user = customersUpdate.modify_user;
            cliente.Deleted = false;


        }
    }
}