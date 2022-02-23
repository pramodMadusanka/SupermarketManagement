using CoreBusiness;

namespace UseCases.UseCasesInterfaces;
public interface ICreateProductUseCase
{
    void Execute(Product item);
}