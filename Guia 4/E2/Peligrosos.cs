namespace E2
{
    public class Peligrosos:monster_energy
    {
        public Peligrosos(int respeto,string nombre): base(respeto,nombre)
        {
            
        }
        public override void asustar()
        {
            respeto+=5;
        }
        public override void reir()
        {
            respeto-=2;
        }
    }
}