﻿using System;
using System.Collections.Generic;
namespace E6
{
    class Program
    {
        static string ingreso(){
            string palabra;
            Console.WriteLine("Ingrese lo que busca:");
            palabra=Console.ReadLine();
            return palabra;
        }
        static void mostrar(Peliteca lapeliteca)
        {
            Console.WriteLine("\nPelículas:");
            lapeliteca.aux.ForEach(i => Console.WriteLine("Nombre: "+ i.Nombre +" / Género: "+ i.Genero +" / Director:"+ i.Director +" / Año:"+ i.Año));
            
        }
        static void Main(string[] args)
        {
            int numero=1;
            int año=0;
            Peliteca lapeliteca = new Peliteca();
            while(numero!=0){
                Console.WriteLine("\n\n¿Cómo desea buscar las películas?");
                Console.WriteLine("1_Por género.\n2_Por nombre.\n3_Por año.\n4_Por director.\n5_Cuantas peliculas hay en total.\n6_Cuantas hay de un genero en especifico.\n0_Salir.");
                numero=Int32.Parse(Console.ReadLine());

                switch(numero){
                    case 1:
                        lapeliteca.porGenero(ingreso());
                        mostrar(lapeliteca);
                        break;
                    case 2:
                        lapeliteca.porNombre(ingreso());
                        mostrar(lapeliteca);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el año:");
                        año=Int32.Parse(Console.ReadLine());
                        lapeliteca.porAño(año);
                        mostrar(lapeliteca);
                        break;
                    case 4:
                        lapeliteca.porDirector(ingreso());
                        mostrar(lapeliteca);
                        break;
                    case 5:
                        Console.WriteLine("Hay "+ lapeliteca.peliculas.Count +" películas en la peliteca.");
                        break;
                    case 6:
                        lapeliteca.porGenero(ingreso());
                        Console.WriteLine("Hay "+ lapeliteca.aux.Count +" películas de este género.");
                        break;

                }

            }
        }
        
    }
}