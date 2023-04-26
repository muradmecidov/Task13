using ConsoleApp10.Models;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bus bus = new Bus();
            //Vehichle vehichle = bus;
            //Car car1 = new Car();
            //Vehichle vehichle = Car;


            //Vehichle bus = new Bus();
            //Vehichle car = new Car();

            Vehichle vehichle = new Bus() { Price = 3000 };
            Bus bus1 = (Bus)vehichle;
            bus1.Drive();

            if (vehichle is Bus)
            {


                Console.WriteLine("Vehicle is Bus");
            }
            else 
            {
                Console.WriteLine("Vehicle is not Bus");
            }
           



            Vehichle vehichle1 = new Car() { Price = 1000 };
            Car car1 = (Car)vehichle1;
            car1.Drive();
            if (vehichle1 is Car)
            {
               
                Console.WriteLine("Vehicle is Car");
            }
            else
            {
                Console.WriteLine("Vehicle is not Car");
            }

            Console.WriteLine(car1 < bus1);




        }
    }
}