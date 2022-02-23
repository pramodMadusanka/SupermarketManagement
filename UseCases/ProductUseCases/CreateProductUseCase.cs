using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;
using CoreBusiness;

namespace UseCases;
public class CreateProductUseCase: ICreateProductUseCase
{
    private readonly IProductRepository _productRepository;
    public CreateProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public void Execute(Product item)
    {
        _productRepository.AddProduct(item);
    }
}