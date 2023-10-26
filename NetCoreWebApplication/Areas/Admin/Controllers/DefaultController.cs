﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApplication.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
