using System;
using System.Collections.Generic;
using System.Text;

namespace CookingTerminalMain.ViewModels.ModelViewModels
{
    public class PizzaViewModel : BaseViewModel
    {

        public int PizzaID { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public int PizzabaseID { get; set; }
        public string Pizzabase { get; set; }
        public int PizzaIndex { get; set; }
        public List<int> StandardIngredientsDeffinition { get; set; }
        public List<BackendHandler.Condiment> PizzaIngredients { get; set; }

        public List<int> IndexDishList { get; set; }
        public bool IsDishCooked { get; set; }
    }
}
