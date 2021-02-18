using System.Collections.Generic;
namespace E2
{
    public class Constructora
    {
        public int presupuesto,horasdetrabajo;
        private Contratistas empleado;
        List<Contratistas> trabajadores=new List<Contratistas>();

        public Constructora(int presupuesto, int horasdetrabajo)
        {
            this.presupuesto = presupuesto;
            this.horasdetrabajo = horasdetrabajo;
        }
        public bool Alcanza(int horas)
        {
            int plata=0;
            foreach(Contratistas x in trabajadores)
            {
                plata+=empleado.Cobrar(horas);
            }
            return presupuesto>=plata;
        }
    }
}