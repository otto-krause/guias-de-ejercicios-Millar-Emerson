namespace E2
{
    public class Amigables:monster_energy
    {
        public Amigables(int respeto,string nombre): base(respeto,nombre)
        {
            
        }
        public override void asustar()
        {
            respeto++;
        }
        public override void reir()
        {
            respeto+=7;
        }
    }
}