using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            Car c = new Car()
            {
                Year = "2004",
                Make = "Ford",
                Model = "Focus",
                HasTrunk = true
            };
            Motorcycle m = new Motorcycle()
            {
                Year = "2004",
                Make = "Honda",
                Model = "bike",
                HasSideCart = true
            };
            Vehicle vc = new Car() {
                Year = "2004",
                Make = "Ford",
                Model = "Focus",
                HasTrunk = true
            };
            Vehicle vm = new Motorcycle() {
                Year = "2004",
                Make = "Honda",
                Model = "bike",
                HasSideCart = true
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(c);
            vehicles.Add(m);
            vehicles.Add(vc);
            vehicles.Add(vm);
            foreach (Vehicle v in vehicles) {
                Console.WriteLine($"Year: {v.Year}");
                Console.WriteLine($"Make: {v.Make}");
                Console.WriteLine($"Model: {v.Model}");
                
            }


            // Call each of the drive methods for one car and one motorcycle
            c.DriveAbstract();
            c.DriveVirtual();
            m.DriveAbstract();
            m.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
