using CoreBusiness;

namespace UseCases.UseCasesInterfaces;
public interface IGetCategoryByIdUseCase
{
    Category? Execute(int Id);
}