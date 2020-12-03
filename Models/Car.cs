using AbsInterface.Interfaces;

namespace AbsInterface.Models
{
    public class Car : MotorVehicle , IRidable
    {
        public Car(string make, string model, int doors) : base(make,model,doors,4)
        {
            Noise = "Beep Beep";
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