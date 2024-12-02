using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodItemsApp.Models
{
    public class FoodItems
    {
        public int Id { get; set; }
        public string FoodItemName { get; set; }
        public string FoodItemType {  get; set; }

        public double Price {  get; set; }

    }
}