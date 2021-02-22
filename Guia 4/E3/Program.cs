using System;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";

            string nombreDelJuego;
            int añoDeLanzamiento;
            string nombreDeLaConsola;

            int horasJugadas;
 
            Jugador Emerson = new Jugador("Emerson");

            while (opcion != "Salir"){

                Console.WriteLine("1_Adquirir un juego\n2_Ver el juego mas nuevo\n3_Ver el juego mas viejo\n4_Ver la consola mas usada\n_5_Jugar en una consola");
                opcion = Console.ReadLine();
                switch (opcion){
                    case "1":
                        Console.WriteLine("Ingrese nombre del juego, año de lanzamiento y nombre de la consola");
                        nombreDelJuego = Console.ReadLine();
                        añoDeLanzamiento = Int32.Parse(Console.ReadLine());
                        nombreDeLaConsola = Console.ReadLine();
                        Juego juego = new Juego(nombreDelJuego,añoDeLanzamiento,nombreDeLaConsola);
                        Emerson.adquirirJuego(juego);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nombre de la consola de la que quiere ver el juego mas reciente");
                        nombreDeLaConsola = Console.ReadLine();
                        foreach (var i in Emerson.Consolas){
                            if (nombreDeLaConsola == i.ToString() ) Console.WriteLine("El juego mas nuevo es: " + i.elMasNuevo());
                        }
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el nombre de la consola de la que quiere ver el juego mas viejo");
                        nombreDeLaConsola = Console.ReadLine();
                        foreach (var i in Emerson.Consolas){
                            if (nombreDeLaConsola == i.ToString() ) Console.WriteLine("El juego mas viejo es: " + i.elMasViejo());
                        }
                        break;
                    case "4":
                        Console.WriteLine(Emerson.laMasUsada());
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el nombre de la consola en la que quiere jugar y las horas que jugo");
                        nombreDeLaConsola = Console.ReadLine();
                        horasJugadas = Int32.Parse(Console.ReadLine());
                        foreach (var i in Emerson.Consolas){
                            if (nombreDeLaConsola == i.ToString()) i.jugar(horasJugadas);
                        }
                        break;
                    default:
                        opcion = "Salir";
                        break;
                }
            }
        }
    }
}