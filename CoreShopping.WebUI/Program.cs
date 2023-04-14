using CoreShopping.BusinessLogic.Abstract;
using CoreShopping.BusinessLogic.Concrete;
using CoreShopping.DataAccess.Abstract;
using CoreShopping.DataAccess.Concrete.EFCore;
using CoreShopping.DataAccess.Concrete.Memory;
using CoreShopping.WebUI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
/////////////////////////////////////////////////////////
// DEPENDENCY INJECTION
builder.Services.AddScoped<IProductDAL, EFCoreProductDAL>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ICategoryDAL, EFCoreCategoryDAL>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);

//////////////////////////////////////////////////////////
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

SeedDatabase.Seed();
app.UseHttpsRedirection();
app.UseStaticFiles();
////////////////////////////////////////////////////////////////
app.CustomStaticFiles();//
////////////////////////////////////////////////////////////////
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
////////////////////////////////// PROJENÝN SONLAMA NOKTASI
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");

    endpoints.MapControllerRoute(
    name: "products",
    pattern: "products/{category?}",
    defaults: new { controller = "Shop", action = "List" }
     );
});

//////////////////////////////////
app.Run();
