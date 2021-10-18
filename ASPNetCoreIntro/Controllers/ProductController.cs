using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    //HTTP GET İŞLEMLERİ  
    public class ProductController : Controller
    {
        //Controller içindeki public methodlar = Aksiyon-Action  //Index fonksiyonu = https:// localhost...:product/index
        public IActionResult Index() //Product Controllerinin Index Aksiyonunun Viewi
        {
            return View();
        }
    }
}
