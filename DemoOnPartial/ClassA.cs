using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnPartial
{
    partial class ClassA
    {
        partial void setData()
        {
            Console.WriteLine("setData Printing\nData is assigned using partial");
        }
    }
}
