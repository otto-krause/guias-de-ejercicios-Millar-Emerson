using System.Collections.Generic;
using System;
namespace E2
{
    public class Clinica
    {
        public Clinica()
        {
            List<Medico> medicos=new List <Medico>();
            medicos.Add(new Medico("Cabrera","Gabriel","Ginecologia",30)); 
            medicos.Add(new Medico("Millar","Emerson","Cardiologia",40));
            medicos.Add(new Medico("Sozaki","Brahian","Traumatologia",50));
        }
        public string Turnos (string especialidad)
        {
            foreach (var aux in medicos)
            {
                if (aux.especialidad==especialidad)
                {
                    if(aux.turnoss<50)
                    {
                        Console.WriteLine("El medico"+aux.nombre+"esta disponible");
                        return especialidad;
                    }
                    else
                    {
                        return ("Intente de nuevo mas tardee");
                    }
                }
            }
        }
    }
}