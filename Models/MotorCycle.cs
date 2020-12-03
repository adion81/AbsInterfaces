using System;
using AbsInterface.Interfaces;

namespace AbsInterface.Models
{
    public class MotorCycle : MotorVehicle, IRidable
    {
        public MotorCycle(string make, string model,  int wheels) : base(make, model, 0,wheels )
        {
            Noise = "BWAP BWAP BWAP VRRROOOOOM";
        }

        public double DistanceTraveled {get;set;}

        public bool IsTraveling {get;set;}

        public int EnergySource {get;set;}

        public void Travel(double miles)
        {
            base.MakeNoise();
            IsTraveling= true;
            DistanceTraveled += miles;
        }

        
    }
}