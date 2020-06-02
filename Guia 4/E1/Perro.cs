namespace E1
{
    public class Perro:animales
    {
        public Perro(int energia): base(energia)
        {

        }
        public override void comer()
        {
            energia+=15;
        }
        public override void jugar()
        {
            energia-=20;
        }
    }
}