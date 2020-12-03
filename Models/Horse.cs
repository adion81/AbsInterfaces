using AbsInterface.Interfaces;

namespace AbsInterface.Models
{
    public class Horse : Animal, IRidable
    {
        public string ManeColor;

        public double Height;

        
        public Horse(string name, int limbs, string furColor,double height,string mane) : base(name, limbs, furColor)
        {
            Height= height;
            ManeColor = mane;
        }

        public double DistanceTraveled {get;set;}
        public bool IsTraveling {get;set;}

        public int EnergySource {get;set;}

        public void Travel(double miles)
        {
            DistanceTraveled += miles;
        }
    }
}