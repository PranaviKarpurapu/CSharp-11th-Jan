using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnFactory
{
    //product interface
    interface Ifactory

    {
        void manufacture(int count);
    }
    //create product interface
    class Bike : Ifactory
    {
        public void manufacture(int count)
        {
            Console.WriteLine("Bike Manufacturing NO: " + count);
        }
    }

    class Car : Ifactory
    {
        public void manufacture(int count)
        {
            Console.WriteLine("Car Manufacturing NO: " + count);
        }
    }
    //creating abstract class
   abstract class VehicleFactory
    {
        public abstract Ifactory GenerateVehicles(string type);

    }
    //actual creation class
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override Ifactory GenerateVehicles(string type)
        {

            if (type == "Bike") return new Bike();

            else return new Car();

            //throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory obj = new ConcreteVehicleFactory();

            Ifactory myVehicle = obj.GenerateVehicles("Bike");
            myVehicle.manufacture(10);

            myVehicle = obj.GenerateVehicles("Car");
            myVehicle.manufacture(20);

            Console.ReadKey();
        }
    }
}
