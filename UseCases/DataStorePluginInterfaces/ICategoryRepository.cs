using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;

public interface ICategoryRepository
{
    IEnumerable<Category> GetCategories();
    void AddCategory(Category item);
    void EditCategory(Category item);
    Category? GetCategoryById(int id);
    void DeleteCategory(Category item);
}