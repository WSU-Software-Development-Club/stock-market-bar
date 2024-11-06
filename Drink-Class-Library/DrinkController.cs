using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Class_Library
{
    public class DrinkController
    {
        // Basic constructor - needs adjusted
        public DrinkController() { Console.WriteLine("Project Linked");  }

        // add in drink controller functionality here
        // the UI class currently already has this class being created as an object

        public List<Tuple<string, double>> InitializeDrinkDemoList()
        {
            List<Tuple<string, double>> tempList = new List<Tuple<string, double>>();
            tempList.Add(new Tuple<string, double>("Bud Lite", 3.45));
            tempList.Add(new Tuple<string, double>("Corona Extra", 4.25));
            tempList.Add(new Tuple<string, double>("Pabst Blue Ribbon", 3.75));
            tempList.Add(new Tuple<string, double>("Coors Lite", 2.85));
            tempList.Add(new Tuple<string, double>("Guiness", 4.55));

            return tempList;
        }
    }
}
