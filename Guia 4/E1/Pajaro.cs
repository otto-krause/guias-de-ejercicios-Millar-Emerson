namespace E1
{
    public class Pajaro:animales
    {
        public Pajaro (int energia): base(energia)
        {
        }
        public override void comer()
        {
            energia+=10;
        }
        public override void jugar()
        {
            energia-=5;
        }
    }
}