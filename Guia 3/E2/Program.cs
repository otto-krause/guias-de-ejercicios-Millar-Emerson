using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contratistas> contratistas=new List<Contratistas>();
            int presupuesto,horasdetrabajo;
            Console.WriteLine("ingrese el presupuesto y las horas de trabajo");
            presupuesto=Int32.Parse(Console.ReadLine());
            horasdetrabajo=Int32.Parse(Console.ReadLine());
            Constructora constructora=new Constructora(presupuesto,horasdetrabajo);
            Console.WriteLine("Alcanza el presupuesto?="+constructora.Alcanza(horasdetrabajo));
        }
    }
}
