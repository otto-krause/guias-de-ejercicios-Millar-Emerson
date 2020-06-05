using System.Collections.Generic;
namespace E2
{
    public abstract class monster_energy
    {
        protected int respeto;
        protected string nombre;
        public monster_energy(int respeto,string nombre)
        {
            this.respeto=respeto;
            this.nombre=nombre;
        }
        public int Respeto()
        {
            return respeto;
        }
        public string Name()
        {
            return nombre;
        }
        public abstract void reir();
        public abstract void asustar();
    }
}