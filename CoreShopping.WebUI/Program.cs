using CoreShopping.BusinessLogic.Abstract;
using CoreShopping.BusinessLogic.Concrete;
using CoreShopping.DataAccess.Abstract;
using CoreShopping.DataAccess.Concrete.Memory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
/////////////////////////////////////////////////////////
// DEPENDENCY INJECTION
builder.Services.AddScoped<IProductDAL,MemoryProductDAL>();
builder.Services.AddScoped<IProductService,ProductManager>();

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
////////////////////////////////// PROJENÝN SONLAMA NOKTASI
app.UseEndpoints(endpoints => { endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}"); }) ;
//////////////////////////////////
app.Run();
