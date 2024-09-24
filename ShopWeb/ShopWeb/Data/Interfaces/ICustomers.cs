using ShopWeb.Data.Dtos;

namespace ShopWeb.Data.Interfaces
{
    public interface ICustomers
    {
        void SaveCustomers(CustomersAddDto custommersAdd);

        void UpdateCustomers(CustomersUpdateDto customersUpdate);

        void DeleteCustomers(CustomersRemoveDto customersRemove);


        List<CustomersAddDto> GetCustomers();
        CustomersAddDto GetCustomersById(int Custid);
    }
}
