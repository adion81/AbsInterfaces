using System;
using System.Collections.Generic;
using AbsInterface.Interfaces;
using AbsInterface.Models;

namespace AbsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Truck chevy = new Truck("Chevy","Silverado",4,6);

            Car lunchbox = new Car("Toyota","Prius",4);

            MotorCycle harley = new MotorCycle("Harley Davidson","Roadster",2);

            MotorCycle spyder = new MotorCycle("Fia","Spyder",3);

            List<IRidable> myRides = new List<IRidable>();
            myRides.Add(chevy);
            myRides.Add(lunchbox);
            myRides.Add(harley);
            myRides.Add(spyder);

            foreach(IRidable ride in myRides)
            {
                ride.Travel(5.60);
            }

        }
    }
}
