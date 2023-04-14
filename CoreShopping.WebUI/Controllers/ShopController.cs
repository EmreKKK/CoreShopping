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

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = _productService.GetProductDetails((int)id);

            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductDetailsModel()
            {
                Product = product,
                Categories = product.ProductCategories.Select(c => c.Category).ToList()
            });
        }

        [Route("products/{category?}")]
        public IActionResult List(string category,int page=1)
        {
            const int pageSize = 3;
            return View(new ProductListModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems= _productService.GetCountByCategory(category),
                    CurrentPage=page,
                    CurrentCategory=category,
                    ItemsPerPage=pageSize
                },

                Products = _productService.GetProductsByCategory(category,page,pageSize )
            });;
        }
    }
}
