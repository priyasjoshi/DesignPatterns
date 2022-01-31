﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{ 
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() {
            name = "Chigaco style Deep Dish Cheese Pizza ";
            //dough = "Extra Thick Crust Dough";
            //sauce = "Plum Tomato Sauce";
            //toppings.Add("Lot of Shredded Mozzarella Cheese");
        }
        public new void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
