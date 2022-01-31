using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class PlumTomatoSauce : Sauce
    {
        public void CreateSauce()
        {
            Console.WriteLine("Adding Plum Tomato Sauce...");
        }
    }
}
