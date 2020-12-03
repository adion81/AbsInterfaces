namespace AbsInterface.Models
{
    public class Bird : Animal
    {
        public int WingSpan;
        public string BeakColor;
        public bool CanFly;
        public Bird(string name, int limbs, string furColor,int wing,string beak,bool fly) : base(name, limbs, furColor)
        {
            WingSpan = wing;
            BeakColor = beak;
            CanFly = fly;
        }
    }
}