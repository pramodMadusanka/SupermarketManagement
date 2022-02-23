using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory;
public class CategoryInMemoryRepository: ICategoryRepository
{
    List<Category> dummyList;
    int _id;
    public CategoryInMemoryRepository()
    {
        dummyList = new List<Category>();
        AddCategory(new Category{Name="Soft Drink", Description="Breverage"});
        AddCategory(new Category{Name="Smartphone", Description="Consumer Electronic"});
    }

    public IEnumerable<Category> GetCategories()
    {
        return dummyList;
    }
    public void AddCategory(Category item)
    {
        if(item == null || item.Name == null) return;
        if(dummyList.Any(x => x.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase))) return;
        item.CategoryId = ++_id;
        dummyList.Add(item);
    }
    public void EditCategory(Category item)
    {
        int index = dummyList.FindIndex(x => x.CategoryId.Equals(item.CategoryId));
        dummyList[index] = item;
    }
    public Category? GetCategoryById(int id)
    {
        return dummyList.FirstOrDefault(x => x.CategoryId==id);
    }
    public void DeleteCategory(Category item)
    {
        dummyList.Remove(item);
    }
}
