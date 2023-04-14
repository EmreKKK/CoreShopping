using CoreShopping.BusinessLogic.Abstract;
using CoreShopping.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreShopping.WebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService= categoryService;
        }

        public IViewComponentResult Invoke()
        {
            return View(new CategoryListViewModel()
            {
                SelectedCategory = RouteData.Values["category"]?.ToString(), // ? null değilse
                Categories =_categoryService.GetAll().ToList(),
            });
        }
    }
}
