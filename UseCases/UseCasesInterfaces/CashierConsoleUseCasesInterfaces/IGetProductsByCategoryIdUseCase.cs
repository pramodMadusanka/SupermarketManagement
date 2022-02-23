using CoreBusiness;

namespace UseCases.UseCasesInterfaces;
public interface IGetProductsByCategoryIdUseCase
{
    IEnumerable<Product> Execute(int id);
}