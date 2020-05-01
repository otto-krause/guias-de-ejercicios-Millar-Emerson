using System;
using System.Collections.Generic;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Album mundial=new Album();
            string nombre,posicion,pais;
            int numerofigurita,decision=1;
            while(decision!=0)
            {
                Console.WriteLine("ingrese 1 si quiere ingresar una figurita");
                Console.WriteLine("ingrese 2 si quiere saber cuantos delanteros hay");
                Console.WriteLine("ingrese 4 si quiere saber si esta completo");
                decision=Int32.Parse(Console.ReadLine());
                switch(decision)
                {
                    case 1:
                        Console.WriteLine("ingrese el nombre, posicion, pais y numero de figurita");
                        nombre=Console.ReadLine();
                        posicion=Console.ReadLine();
                        pais=Console.ReadLine();
                        numerofigurita=Int32.Parse(Console.ReadLine());
                        Figurita figu=new Figurita(nombre,pais,posicion,numerofigurita);
                        break;
                    case 2:
                        Console.WriteLine("Cantidad de delanteros="+mundial.CuantosDelanteros());
                        break;
                    case 4:
                        Console.WriteLine("Esta completo?"+mundial.EstaCompleto());
                        break;
                }
            }
        }
    }
}
