using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    internal class Bus : Vehichle
    {
        public override void Drive()
        {
            Console.WriteLine("Drive -- Like the Bus");
        }
    }
}
