using BusinessLayer;
using Entities;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApplication.Models;
using NetCoreWebApplication.Utils;
using System.Diagnostics;

namespace NetCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        SliderManager _sliderManager =new SliderManager();
        CategoryManager _categoryManager = new CategoryManager();
        PostManager _postManager = new PostManager();
        NewManager _newManager = new NewManager();
        ContactManager _contactManager = new ContactManager();  
     

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel()
            {
                Categories = _categoryManager.GetAll(),
                Sliders = _sliderManager.GetAll(),
                News = _newManager.GetAll(),
                Posts= _postManager.GetAll()

            };
            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if(ModelState.IsValid) 
            {
              
                try
                {
                    contact.CreateDate = DateTime.Now;
                    var mailgittimi= MailHelper.SendMail(contact);
                    var sonuc=_contactManager.Add(contact);
                    if (sonuc>0)
                    {
                        TempData["Mesaj"] = "Mesajınız başarıyla Gönderilmiştir...";
                        return RedirectToAction("Contact");
                    }
                }
                catch (Exception)
                {
                    TempData["Mesaj"] = "Hata oluştu! Mesajınız Gönderilemedi...";
                }
               
            }
             
            return View(contact);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}