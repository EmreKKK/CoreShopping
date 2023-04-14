using CoreShopping.BusinessLogic.Abstract;
using CoreShopping.Entities;
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
                Products = _productService.GetAll()
            });
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = _productService.GetById((int)id);

            if(product == null)
            {
                return NotFound();
            }
            return View(product);
            


        }
    }
}
