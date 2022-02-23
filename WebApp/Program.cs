using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using UseCases;
using UseCases.UseCasesInterfaces;
using UseCases.DataStorePluginInterfaces;
using Plugins.DataStore.InMemory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddServerSideBlazor();

//DI for CategoryUseCases
builder.Services.AddSingleton<ICategoryRepository, CategoryInMemoryRepository>(); //change this
builder.Services.AddScoped<IViewCategoriesUseCase, ViewCategoriesUseCase>();
builder.Services.AddScoped<ICreateCategoryUseCase, CreateCategoryUseCase>();
builder.Services.AddScoped<IEditCategoryUseCase, EditCategoryUseCase>();
builder.Services.AddScoped<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
builder.Services.AddScoped<IDeleteCategoryUseCase, DeleteCategoryUseCase>();

//DI for ProductUseCases
builder.Services.AddSingleton<IProductRepository, ProductInMemoryRepository>(); //change this
builder.Services.AddScoped<IViewProductsUseCase, ViewProductsUseCase>();
builder.Services.AddScoped<ICreateProductUseCase, CreateProductUseCase>();
builder.Services.AddScoped<IDeleteProductUseCase, DeleteProductUseCase>();
builder.Services.AddScoped<IEditProductUseCase, EditProductUseCase>();
builder.Services.AddScoped<IGetProductByIdUseCase, GetProductByIdUseCase>();
builder.Services.AddScoped<IGetProductsByCategoryIdUseCase, GetProductsByCategoryIdUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
