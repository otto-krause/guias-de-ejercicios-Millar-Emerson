using System.Collections.Generic;
namespace E2
{
    public class Medico
    {
        public string nombre,apellido,especialidad;
        public int turnos;
        public Medico(string apellido,string nombre, string especialidad,int turnos)
        {
            this.nombre=nombre;
            this.especialidad=especialidad;
            this.apellido=apellido;
            this.turnos=turnos;
        }
        public bool EstaDiponible (int turnos)
        {
            return turnos<50;
        }
    }
}