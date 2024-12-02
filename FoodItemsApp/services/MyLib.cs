using FoodItemsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodItemsApp.services
{
    public class MyLib
    {
        public List<FoodItems> GetFoodItemsList()
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
            return flist;
         }
    }
}