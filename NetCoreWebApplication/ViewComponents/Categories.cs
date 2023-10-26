using BusinessLayer;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApplication.ViewComponents
{
    public class Categories :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryManager categoryManager = new CategoryManager();
            return View(categoryManager.GetAll());
        }
    }
}
