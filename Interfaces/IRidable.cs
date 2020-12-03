namespace AbsInterface.Interfaces
{
    public interface IRidable
    {
        double DistanceTraveled {get;set;}

        bool IsTraveling {get;set;}

        int EnergySource {get;set;}

        void Travel(double miles);

    }
}