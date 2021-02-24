using System;
using System.Collections.Generic;
using System.Linq;
namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> conocimientos1 = new List<string>{"Programación","Arroz","manipulación","cartillo","expiración","Actuación","falso","verdadero"};

            Persona pablo = new Persona(conocimientos1);

            Console.WriteLine("\nLos Ultimos 5 conocimientos adquiridos:");
            pablo.ultimos5Conocimientos().ForEach(i => Console.WriteLine(i));

            Console.WriteLine("\nLos primeros 4 conocimientos en orden alfabetico:");
            pablo.primeros4Conocimientos().ForEach(j => Console.WriteLine(j));

            Console.WriteLine("\n"+ pablo.cuantosTienenCion() +" palabras contienen 'ción'.");
            


        }
    }
}