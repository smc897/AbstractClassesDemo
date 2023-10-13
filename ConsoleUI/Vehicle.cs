using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public String Year { get; set; } = "default";
        public String Make { get; set; } = "default";
        public String Model { get; set; } = "default";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() {
            Console.WriteLine("The car is virtually driving...");
        }

    }
}
