namespace AbsInterface.Models
{
    public abstract class Animal
    {
        public string Name;
        public int Age;
        public int Limbs;
        public string FurColor;

        public Animal(string name, int limbs, string furColor)
        {
            Name= name;
            Age = 0;
            Limbs = limbs;
            FurColor = furColor;
        }
    }
}