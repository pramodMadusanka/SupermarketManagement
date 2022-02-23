using CoreBusiness;

namespace UseCases.UseCasesInterfaces;
public interface IViewProductsUseCase
{
    IEnumerable<Product> Execute();
}