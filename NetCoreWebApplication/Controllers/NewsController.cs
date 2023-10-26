using BusinessLayer;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApplication.Controllers
{
    public class NewsController : Controller
    {
        NewManager _newManager = new NewManager();
        public IActionResult Index()
        {
            return View(_newManager.GetAll());
        }

        public IActionResult Detail(int id)
        {
            return View(_newManager.Find(id));
        }
    }
}
