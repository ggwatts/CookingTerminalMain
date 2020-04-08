using System;
using System.Collections.Generic;
using System.Text;

namespace CookingTerminalMain.Models
{

   public class OrderModel
    {
        public int OrderID { get; set; }
        public int Status { get; set; }
        public float Price { get; set; }

        public List<BackendHandler.Pizza> PizzaList { get; set; }
        public List<BackendHandler.Extra> ExtraList { get; set; }

    }
}
