namespace E2
{
    public class Plomero: Contratistas
    {
        private string nombre,tipo;
        private int horas,edad;
        public Plomero (string nombre, string tipo,int edad)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.edad=edad;
        }
        public void Trabajar(int horasdetrabajo)
        {
            horas=horasdetrabajo;
        }
        public int Cobrar (int horas)
        {
            int cobro=0;
            cobro=horas*80;
            return cobro;
        }
    }
}