using CoreBusiness;
using UseCases.UseCasesInterfaces;
using UseCases.DataStorePluginInterfaces;

namespace UseCases;
public class GetProductsByCategoryIdUseCase : IGetProductsByCategoryIdUseCase
{
    private readonly IProductRepository _productRepository;
    public GetProductsByCategoryIdUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IEnumerable<Product> Execute(int id)
    {
        return _productRepository.GetProductsByCategoryId(id);
    }
}