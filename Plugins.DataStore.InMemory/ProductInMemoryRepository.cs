using System.ComponentModel.DataAnnotations;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using Plugins.DataStore.InMemory.CustomAttributes;

namespace Plugins.DataStore.InMemory;
public class ProductInMemoryRepository : IProductRepository
{
    private int _productId;
    private List<Product> _dummyList;
    private readonly ICategoryRepository _categoryRepository;
    public ProductInMemoryRepository(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
        _dummyList = new List<Product>();
        AddProduct(new Product{CategoryId=2, Name="POCO M3", Quantity=5, Price=1000.00m});
    }
    public IEnumerable<Product> GetProducts()
    {
        return _dummyList;
    }
    public void AddProduct(Product item)
    {
        if(!_categoryRepository.GetCategories().Any(x=>x.CategoryId==item.CategoryId)) return;
        item.ProductId = ++_productId;
        _dummyList.Add(item);
    }
    public Product? GetProductById(int id)
    {
        return _dummyList.FirstOrDefault(x => x.ProductId==id);
    }
    public void UpdateProduct(Product item)
    {
        int index = _dummyList.FindIndex(x => x.ProductId==item.ProductId);
        _dummyList[index] = item;
    }
    public void DeleteProduct(Product item)
    {
        _dummyList.Remove(item);
    }

    public IEnumerable<Product> GetProductsByCategoryId(int id)
    {
        return _dummyList.Where(x => x.CategoryId==id);
    }
}