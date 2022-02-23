using CoreBusiness;

namespace UseCases.UseCasesInterfaces;
public interface IDeleteProductUseCase
{
    void Execute(Product item);
}