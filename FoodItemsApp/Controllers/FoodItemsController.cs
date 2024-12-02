using FoodItemsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace FoodItemsApp.Controllers
{
    public class FoodItemsController : Controller
    {
        
        public ActionResult Index()
        {
            FoodItems f1 = new FoodItems()
            {
                Id = 1,
                FoodItemName = "Biryani",
                FoodItemType = "Non-Veg",
                Price = 250.00
            };

            return View(f1);
        }
        public ActionResult ShowFoodItems()
        {
            List<FoodItems> flist = new List<FoodItems>()
            {
                new FoodItems()
                {
                    Id=1,
                    FoodItemName = "Biryani",
                    FoodItemType = "Non-Veg",
                    Price = 250.00
                },
                new FoodItems()
                {
                    Id=2,
                    FoodItemName = "chicken-65",
                    FoodItemType = "Non-Veg",
                    Price = 200.00
                },
                new FoodItems()
                {
                    Id=3,
                    FoodItemName = "Mutton Roast",
                    FoodItemType = "Non-Veg",
                    Price = 350.00
                },
                new FoodItems()
                {
                    Id=4,
                    FoodItemName = "Chicken Pakoda",
                    FoodItemType = "Non-Veg",
                    Price = 259.00

                }
            };
            return View(flist);
           

        }
        public ActionResult DisplayFoodItems()
        {
            return View();
        }
    }
}