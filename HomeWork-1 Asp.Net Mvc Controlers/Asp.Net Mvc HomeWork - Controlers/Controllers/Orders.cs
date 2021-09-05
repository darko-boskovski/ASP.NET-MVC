using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Mvc_HomeWork___Controlers.Controllers
{
    public class Orders : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            return View();
        }
  
        public IActionResult Details(int? id)
        {   
            if (id.HasValue)
                return View();
            return new EmptyResult();
        }
        public IActionResult JsonData()
        {
            var jsonObject = new { Id = 12,  someJsonData = "smthsmth", isSuccesfull = "yes"};
            return new JsonResult(jsonObject);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
