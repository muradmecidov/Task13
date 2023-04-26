using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    internal class Car : Vehichle
    {
        public override void Drive()
        {
            Console.WriteLine("Drive -- Like the Car");
        }

        public static bool operator > (Car car1, Bus bus1)
        {
            return car1.Price > bus1.Price;
        }

        public static bool operator <(Car car1, Bus bus1)
        {
            return car1.Price < bus1.Price;
        }

    }
}
