using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string genero,nombre,director;
            int decision=1,anio=0;
            Peliteca peliteca=new Peliteca();
            Console.WriteLine("ingrese 1 si quiere buscar por genero");
            Console.WriteLine("ingrese 2 si quiere buscar por nombre");
            Console.WriteLine("ingrese 3 si quiere buscar por anio");
            Console.WriteLine("ingrese 4 si quiere buscar por director");
            Console.WriteLine("ingrese 5 si quiere saber cuantas peliculas hay");
            Console.WriteLine("ingrese 6 si quiere saber cuantas peliculas hay por genero");
            while(decision!=0)
            {
                decision=Int32.Parse(Console.ReadLine());
                switch(decision)
                {
                case 1:
                    Console.WriteLine("ingrese el genere");
                    genero=Console.ReadLine();
                    Console.WriteLine("peliculas="+peliteca.BuscarGenero(genero));
                    break;
                case 2:
                    Console.WriteLine("ingrese el nombre");
                    nombre=Console.ReadLine();
                    Console.WriteLine("peliculas="+peliteca.BuscarNombre(nombre));
                    break;
                case 3:
                    Console.WriteLine("ingrese el anio");
                    anio=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("peliculas="+peliteca.BuscarAnio(anio));
                    break;
                case 4:
                    Console.WriteLine("ingrese el director");
                    director=Console.ReadLine();
                    Console.WriteLine("peliculas"+peliteca.BuscarDirector(director));
                    break;
                case 5:
                    Console.WriteLine("cantidad de peliculas="+peliteca.CuantasPelis());
                    break;
                case 6:
                    Console.WriteLine("ingrese le genere");
                    genero=Console.ReadLine();
                    Console.WriteLine("peliculas por genero="+peliteca.PelisporGenere(genero));
                    break;
                }
            }
        }
    }
}
