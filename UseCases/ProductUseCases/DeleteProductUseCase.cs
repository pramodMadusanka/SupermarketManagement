using CoreBusiness;
using UseCases.UseCasesInterfaces;
using UseCases.DataStorePluginInterfaces;

namespace UseCases;
public class DeleteProductUseCase : IDeleteProductUseCase
{
    private readonly IProductRepository _productRepository;
    public DeleteProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public void Execute(Product item)
    {
        _productRepository.DeleteProduct(item);
    }
}