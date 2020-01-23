 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id,z,id2,id3;
            string name, des;
            List<Employee> lt = new List<Employee>();
            Employee emp = new Employee();
            do
            {
                Console.WriteLine("MENU\n1.Insert\n2.Display\n3.Update\n4.Delete\n\nEnter your option\n");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:

                            Console.WriteLine("Enter Id ");
                            id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter name ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter Designation ");
                            des = (Console.ReadLine());

                            lt.Add(new Employee(id, name, des));
                            
                            Console.WriteLine("Details Inserted");
                        
                        break;

                    case 2:
                        Console.WriteLine("Details of Employees:");
                        foreach (Employee em in lt)
                        {
                            Console.WriteLine(em.ToString());
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter id of employee you want to update");
                        id2 = int.Parse(Console.ReadLine());
                        
                        Employee e_id = lt.Find(op => id2.Equals(op.emp_id));
                       
                            Console.WriteLine("Enter name to update ");
                           e_id.emp_name = Console.ReadLine();
                            Console.WriteLine("Enter Designation to update ");
                           e_id.emp_des = Console.ReadLine();
                           
                        Console.WriteLine("Details Updated\n");
                        break;

                    case 4:
                        Console.WriteLine("Enter id of employee you want to delete");
                        id3 = int.Parse(Console.ReadLine());
                        List<Employee> e_id1 = lt.FindAll(op1 => id3.Equals(op1.emp_id));
                        foreach (Employee v in e_id1)
                        {
                            Employee x = null;
                            foreach (Employee val in lt)
                            {
                                if (val.emp_id.Equals(id3))
                                {
                                    x = val;

                                }
                            }
                            lt.Remove(x);
                        }
                        Console.WriteLine("Details of given is removed\n");

                        break;

                  

                    default: break;



                }
                Console.WriteLine("press 1 if you want Menu again ");
                z = int.Parse(Console.ReadLine());
            } while (z == 1);
            Console.ReadKey();
        }

    }
}
