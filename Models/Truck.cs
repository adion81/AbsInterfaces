using AbsInterface.Interfaces;

namespace AbsInterface.Models
{
    public class Truck : MotorVehicle, IRidable
    {
        public Truck(string make, string model, int doors, int wheels) : base(make, model, doors, wheels)
        {
            Noise = "HONK";
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