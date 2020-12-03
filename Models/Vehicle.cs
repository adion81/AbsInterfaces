using System;
using AbsInterface.Interfaces;

namespace AbsInterface.Models
{
    public abstract class MotorVehicle : IVocalize
    {
        public int NumOfWheels;
        public int NumOfDoors;
        public string Make;
        public string Model;

        public int Miles;

        public MotorVehicle(string make, string model, int doors,int wheels)
        {
            NumOfWheels = wheels;
            NumOfDoors = doors;
            Make = make;
            Model = model;
            Miles = 0;
        }

        public string Noise {get;set;}

        public virtual void MakeNoise()
        {
            Console.WriteLine(Noise);
        }





    }
}