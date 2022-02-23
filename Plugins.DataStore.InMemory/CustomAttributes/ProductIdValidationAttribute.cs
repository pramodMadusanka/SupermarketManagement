using System.ComponentModel.DataAnnotations;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;

namespace Plugins.DataStore.InMemory.CustomAttributes;
public class ProductIdValidationAttribute: ValidationAttribute
{
    private readonly ICategoryRepository _categoryRepository;
    public ProductIdValidationAttribute(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(_categoryRepository.GetCategories().Any(x=>x.CategoryId==(int)value)) return null;
        return new ValidationResult("No category with the given ID", new[] {"ProductId"});
    }
}