using System.Collections.Generic;
namespace E2
{
    public class Medico
    {
        public string nombre,apellido,especialidad;
        public int turnoss;
        public Medico(string apellido,string nombre, string especialidad,int turnoss)
        {
            this.nombre=nombre;
            this.especialidad=especialidad;
            this.apellido=apellido;
            this.turnoss=turnoss;
        }
        public bool EstaDiponible (int turnoss)
        {
            return turnoss<50;
        }
    }
}