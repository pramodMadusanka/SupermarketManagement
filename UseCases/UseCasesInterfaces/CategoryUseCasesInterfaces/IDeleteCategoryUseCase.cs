using CoreBusiness;

namespace UseCases.UseCasesInterfaces;
public interface IDeleteCategoryUseCase
{
    void Execute(Category item);
}