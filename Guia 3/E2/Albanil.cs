namespace E2
{
    public class Albanil: Contratistas
    {
        private string nombre,tipo;
        private int horas,edad;
        private bool titulo;

        public Albanil (string nombre, string tipo,int edad,bool titulo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.edad=edad;
            this.titulo=titulo;
        }
        public void Trabajar(int horasdetrabajo)
        {
            horas=horasdetrabajo;
        }
        public int Cobrar(int horas)
        {
            int cobro=0;
            if(edad>20 && edad<30)
            {
                cobro=horas*50;
            }
            else
            {
                if(edad>30 && edad<50)
                {
                    cobro=horas*90;
                }
                else
                {
                    if(edad>50)
                    {
                        cobro=horas*120;
                    }
                }
            }
            if(titulo==true)
            {
                cobro+=50;
            }
            return cobro;
        }
    }
}