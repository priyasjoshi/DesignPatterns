using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class MarinaraSauce : Sauce
    {
        public void CreateSauce()
        {
            Console.WriteLine("Adding Marinara Sauce...");
        }
    }
}
