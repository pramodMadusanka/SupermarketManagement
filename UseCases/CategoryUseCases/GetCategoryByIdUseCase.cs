using UseCases.UseCasesInterfaces;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;

namespace UseCases;
public class GetCategoryByIdUseCase: IGetCategoryByIdUseCase
{
    private readonly ICategoryRepository _categoryRepository;
    public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public Category? Execute(int Id)
    {
        return _categoryRepository.GetCategoryById(Id);
    }
}