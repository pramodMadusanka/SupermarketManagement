using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface ICreateCategoryUseCase
{
    void Execute(Category item);
}