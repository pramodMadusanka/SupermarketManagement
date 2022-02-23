using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;
public class EditProductUseCase: IEditProductUseCase
{
    private readonly IProductRepository _productRepository;
    public EditProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public void Execute(Product item)
    {
        _productRepository.UpdateProduct(item);
    }
}