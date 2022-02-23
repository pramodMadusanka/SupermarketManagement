using CoreBusiness;

namespace UseCases.UseCasesInterfaces;
public interface IGetProductByIdUseCase
{
    public Product? Execute(int id);
}