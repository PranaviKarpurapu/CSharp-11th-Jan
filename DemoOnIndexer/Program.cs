using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Year = 2019;
            c[0] = "Maruthi";
            c[1] = "Honda";
            c[2] = "Benz";
            c.Display();


            Console.ReadKey();
        }
    }
}
