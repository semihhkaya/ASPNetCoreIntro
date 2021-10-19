using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    [Route(template:"customer")]
    public class CustomerController : Controller
    {
        [Route(template:"index2")]
        [Route(template:"")]
        [Route(template:"~/anasayfa")]
        public IActionResult Index2() //Customer Controllerinin Index2 Aksiyonunun Viewi
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="Semih",LastName="Kaya",City="Istanbul"},
                new Customer{Id=1,FirstName="Sude",LastName="Öztürk",City="Ankara"},
                new Customer{Id=1,FirstName="Muhsin",LastName="Keskin",City="Trabzon"}
            };

            List<string> shops = new List<string> { "Ankara", "İstanbul", "Antalya" };
            
            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }

        [HttpGet]
        [Route(template:"save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel { 
                Cities = new List<SelectListItem>
                {
                    new SelectListItem {Text="Ankara",Value="06"},
                    new SelectListItem {Text="İstanbul",Value="34"},
                    new SelectListItem {Text="İzmir",Value="35"}
                }
            });
        }

        [HttpPost]
        [Route(template:"save")]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi ";
        }
    }
}
