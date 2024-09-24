using ShopWeb.Data.Dtos;

namespace ShopWeb.Data.Interfaces
{
    public interface ICategories
    {

        void SaveCategorie(CategoriesAddDto categoriesAdd);

        void UpdateCategorie(CategoriesUpdateDto categoriesUpdate);

        void DeleteCategorie(CategoriesRemoveDto categories);


        List<CategoriesAddDto>GetCategories();
        CategoriesAddDto GetCategoriesById(int Categoryid);
    }
}
