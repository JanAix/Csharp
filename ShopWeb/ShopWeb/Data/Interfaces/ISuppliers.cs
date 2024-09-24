using ShopWeb.Data.Dtos;

namespace ShopWeb.Data.Interfaces
{
    public interface ISuppliers
    {


        void SaveSuppliers(SuppliersAddDto suppliersAdd);

        void UpdateSuppliers(SuppliersUpdateDto suppliersUpdate);

        void DeleteSuppliers(SuppliersRemoveDto suppliersRemove);


        List<SuppliersAddDto>GetSuppliers();
        SuppliersAddDto GetSuppliersById(int Supplierid);
    }
}
    

