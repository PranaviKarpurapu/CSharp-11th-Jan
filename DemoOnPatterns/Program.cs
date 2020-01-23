using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton Employee = new Singleton();
            Singleton Employee = Singleton.GetInstance;
            Employee.print("Employee");
            //Singleton student = new Singleton();
            Singleton Student = Singleton.GetInstance;
            Employee.print("Student");
            
            Console.ReadKey();
        }
    }
}
