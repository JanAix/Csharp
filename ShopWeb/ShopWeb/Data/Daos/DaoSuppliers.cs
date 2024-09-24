using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using ShopWeb.Data.Context;
using ShopWeb.Data.Dtos;
using ShopWeb.Data.Entities;
using ShopWeb.Data.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShopWeb.Data.Daos
{
    public class DaoSuppliers : ISuppliers
    {

        private readonly ShopWebContext shopWebDb;
        private readonly ILogger<DaoSuppliers> logger;

        public DaoSuppliers(ShopWebContext shopWebDb,
                             ILogger<DaoSuppliers> logger)

        {

            this.shopWebDb = shopWebDb ?? throw new ArgumentNullException(nameof(shopWebDb));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));


        }

        public void DeleteSuppliers(SuppliersRemoveDto suppliersRemove)
        {
            throw new NotImplementedException();
        }

        public List<SuppliersAddDto> GetSuppliers()
        {
            List<SuppliersAddDto> suplidores = new List<SuppliersAddDto>();
            try
            {
                suplidores = (from sup in this.shopWebDb.Suppliers
                              where sup.Supplierid > 0
                              select new SuppliersAddDto()
                              {
                                  supplierid = sup.Supplierid,
                                  companyname = sup.Companyname,
                                  contacttitle = sup.Contacttitle,
                                  address = sup.Address,
                                  city = sup.City,
                                  country = sup.Country,
                                  phone = sup.Phone,
                                  Creation_date = sup.Creation_date,
                                  Creation_user = sup.Creation_user


                              }).ToList();
            }
            catch (Exception ex)
            {

                this.logger.LogError("Error", ex.ToString());
                return new List<SuppliersAddDto>();

            }
            return suplidores;
        }

        public SuppliersAddDto GetSuppliersById(int Supplierid)
        {
            SuppliersAddDto su = new SuppliersAddDto();
            try
            {
                var supl = this.shopWebDb.Suppliers.Find(Supplierid);
                if (supl == null)
                    throw new Exception("No se encuenta");

                su.supplierid = supl.Supplierid;
                su.companyname = supl.Companyname;
                su.contactname = supl.Contactname;
                su.contacttitle = supl.Contacttitle;
                su.address = supl.Address;
                su.country = supl.Country;
                su.city = supl.City;
                su.region = supl.Region;
                su.postalcode = supl.Postalcode;
                su.phone = supl.Phone;
                su.fax = supl.Fax;
                su.Creation_date = supl.Creation_date;
                su.Creation_user = supl.Creation_user;


            }
            catch (Exception ex)
            {

                this.logger.LogError("Hubo un error", ex.ToString());
            }
            return su;
        }

        public void SaveSuppliers(SuppliersAddDto suppliersAdd)
        {
            try
            {
                if (suppliersAdd == null)
                    throw new Exception("Error");


                if (this.shopWebDb.Suppliers.Any(sup => sup.Supplierid == suppliersAdd.supplierid))
                    throw new Exception("Ya existe");

                Suppliers Suplier = new Suppliers
                {
                    Companyname = suppliersAdd.companyname,
                    Contactname = suppliersAdd.contactname,
                    Contacttitle = suppliersAdd.contacttitle,
                    Address = suppliersAdd.address,
                    City = suppliersAdd.city,
                    Region = suppliersAdd.region,
                    Postalcode = suppliersAdd.postalcode,
                    Country = suppliersAdd.country,
                    Phone = suppliersAdd.phone,
                    Creation_date = suppliersAdd.Creation_date,
                    Creation_user = suppliersAdd.Creation_user,
                    Deleted = suppliersAdd.Delete,


                };

                this.shopWebDb.Suppliers.Add(Suplier);
                this.shopWebDb.SaveChanges();


            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateSuppliers(SuppliersUpdateDto suppliersUpdate)
        {
            try
            {
                Suppliers suppliers = this.shopWebDb.Suppliers.Find(suppliersUpdate.supplierid);
                if (suppliers == null)
                    throw new Exception("Error");

                suppliers.Supplierid = suppliersUpdate.supplierid;
                suppliers.Companyname = suppliersUpdate.companyname;
                suppliers.Contactname = suppliersUpdate.contactname;
                suppliers.Contacttitle = suppliersUpdate.contacttitle;
                suppliers.Address = suppliersUpdate.Address;
                suppliers.Region = suppliersUpdate.Region;
                suppliers.Phone = suppliersUpdate.Phone;
                suppliers.Modify_date = suppliersUpdate.modify_date;
                suppliers.Modify_user = suppliersUpdate.modify_user;



                this.shopWebDb.Suppliers.Update(suppliers);
                this.shopWebDb.SaveChanges();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
