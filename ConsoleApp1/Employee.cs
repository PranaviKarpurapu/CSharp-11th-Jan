using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public  int emp_id;
        public string emp_name;
        public string emp_des;

        public Employee() { }
        public Employee(int emp_id, string emp_name, string emp_des)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name ;
            this.emp_des = emp_des;
        }

        //public override bool Equals(object obj)
        //{
        //    Employee e1 = (Employee)obj;
        //    if (e1==this.emp_id)
        //    {

        //    }


        public override string ToString()
        {
            return "\nEmployee ID  : " + this.emp_id + "\nNAME   : " + this.emp_name + "\nDESIGNATION : " + this.emp_des;
        }
    }
}
