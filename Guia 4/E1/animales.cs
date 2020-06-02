namespace E1
{
    public abstract class animales
    {
        protected int energia;

        public animales(int energia)
        {
            this.energia = energia;
        }
        public abstract void comer ();
        public abstract void jugar();
        public void dormir()
        {
            energia+=100;
        }
        public int Energia()
        {
            return energia;
        }
    }
}