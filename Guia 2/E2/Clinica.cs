using System.Collections.Generic;
using System;
namespace E2
{
    public class Clinica
    {
        List<Medico> medicos=new List <Medico>();
        public Clinica()
        {
            medicos.Add(new Medico("Cabrera","Gabriel","Ginecologia",30)); 
            medicos.Add(new Medico("Millar","Emerson","Cardiologia",40));
            medicos.Add(new Medico("Sozaki","Brahian","Traumatologia",50));
        }
        public void Turnos (string especialidad)
        {
            foreach (var aux in medicos)
            {
                if (aux.especialidad==especialidad)
                {
                    if(aux.turnos<50)
                    {
                        Console.WriteLine("El medico "+ aux.nombre +" esta disponible");
                    }
                    else
                    {
                        Console.WriteLine("intentelo mas tarde");
                    }
                }
                else
                {
                    Console.WriteLine("intentelo mas tarde");
                }
            }
        }
    }
}