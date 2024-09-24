using ShopWeb.Data.Dtos;

namespace ShopWeb.Data.Interfaces
{
    public interface IProducts
    {

        void SaveProducts(ProductsAddDto productsAdd);

        void UpdateProducts(ProductUpdateDto productsUpdate);

        void DeleteProducts(ProductsRemoveDto productsRemove);


        List<ProductsAddDto> GetProducts();
        ProductsAddDto GetProductsById(int productId);
    }
}
    

