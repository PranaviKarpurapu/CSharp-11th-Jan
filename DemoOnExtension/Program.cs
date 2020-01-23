using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnExtension
{
    //Helper class must be static
    static class StringHelper   //by using extension method we can extend the functionality
    {
        public static string FirstCaseChange(this string name) //'this' should be used to refer paramater
        {
            char[] input = name.ToCharArray();
            input[0] = Char.IsUpper(input[0]) ? Char.ToLower(input[0]) : Char.ToUpper(input[0]);
            return new string(input);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Welcome";
            Console.WriteLine(name.FirstCaseChange());
            var anonymoustype = new { property1 = "Ajay", property2 = 12, property3 = true };
            Console.WriteLine(anonymoustype.GetType());
            Console.ReadKey();


        }
    }
}
