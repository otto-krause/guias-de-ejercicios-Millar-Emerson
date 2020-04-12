namespace E4
{
    public class Gatito
    {
         public string nombre;
        bool vacunas;
        public int energia;
        public Gatito (string nombre,bool vacunas,int energia)
        {
            this.nombre=nombre;
            this.vacunas=vacunas;
            this.energia=energia;
        }
        public bool estaSaludable()
        {
            return vacunas && energia>30;
        }
        public void estajugando(int minutos)
        {
            energia=energia-2*minutos;
        }
        public void estaComiendo()
        {
            energia=energia+50;
        }
    }
}