using UseCases.UseCasesInterfaces;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;

namespace UseCases;
public class DeleteCategoryUseCase: IDeleteCategoryUseCase
{
    private readonly ICategoryRepository _categoryRepository;
    public DeleteCategoryUseCase(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public void Execute(Category item)
    {
        _categoryRepository.DeleteCategory(item);
    }
}