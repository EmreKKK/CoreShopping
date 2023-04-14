using CoreShopping.BusinessLogic.Abstract;
using CoreShopping.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreShopping.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(new ProductListModel()
            {
                Products=_productService.GetAll()
            });
        }
    }
}
