using CoreBusiness;
using UseCases.UseCasesInterfaces;
using UseCases.DataStorePluginInterfaces;

namespace UseCases;
public class GetProductByIdUseCase : IGetProductByIdUseCase
{
    private readonly IProductRepository _productRepository;
    public GetProductByIdUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public Product? Execute(int id)
    {
        return _productRepository.GetProductById(id);
    }
}