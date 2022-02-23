using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;
public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
    void AddProduct(Product item);
    Product? GetProductById(int id);
    void UpdateProduct(Product item);
    void DeleteProduct(Product item);
    IEnumerable<Product> GetProductsByCategoryId(int id);
}