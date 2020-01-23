using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnPartial
{
    partial class ClassA     // partial method can be created only in partial class
    {
        partial void setData();  //partial method declaration 
        public void print()
        {
            Console.WriteLine("Class A printing");
            setData();//partial method should be private
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassA();
            obj.print();
            Console.ReadKey();
        }
    }
}
