using CoreShopping.BusinessLogic.Abstract;
using CoreShopping.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreShopping.WebUI.Controllers
{
    public class HomeController : Controller
    {
        #region Injection

        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }


        #endregion
        public IActionResult Index()
        {
            return View(new ProductListModel() { Products = _productService.GetAll() });
        }
    }
}
