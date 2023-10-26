using BusinessLayer;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApplication.Controllers
{
    public class PostsController : Controller
    {
        PostManager _postManager = new PostManager();
        public IActionResult Index(int? id)
        {
            //if(id == null)
            //{
            //    return View(_postManager.GetAll());
            //}
            return View(_postManager.GetAll());
        }

        public IActionResult Detail(int id)
        {
            return View(_postManager.Find(id));
        }
    }
}
