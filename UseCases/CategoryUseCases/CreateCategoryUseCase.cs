using UseCases.UseCasesInterfaces;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;

namespace UseCases;
public class CreateCategoryUseCase: ICreateCategoryUseCase
{
    private readonly ICategoryRepository _categoryRepository;
    public CreateCategoryUseCase(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public void Execute(Category item)
    {        
        _categoryRepository.AddCategory(item);
    }
}