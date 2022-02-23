using UseCases.UseCasesInterfaces;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;

namespace UseCases;
public class EditCategoryUseCase: IEditCategoryUseCase
{
    private readonly ICategoryRepository _categoryRepository;
    public EditCategoryUseCase(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public void Execute(Category item)
    {
        _categoryRepository.EditCategory(item);
    }
}