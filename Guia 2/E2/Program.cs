using System.Collections.Generic;
using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string especialidad;
            Console.WriteLine("ingrese la especialidad del medico");
            Clinica clinica=new Clinica();
            Console.WriteLine("ingrese el especialista con el quiere ser usted tratado");
            especialidad=Console.ReadLine();
            clinica.Turnos(especialidad);
        }
    }
}
