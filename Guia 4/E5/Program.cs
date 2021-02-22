using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            SerPensante robot = new Robot(50);
            SerPensante humano = new Humano(50);
            SerPensante cyborg = new Cyborg(50);
            string opcion = "";

            while (opcion != "Salir"){
                Console.WriteLine("1_Hacer pensar al Robot\n2_Hacer estudiar al Robot\n3_Hacer pensar al Humano\n4_Hacer estudiar al humano\n5_Hacer pensar al Cyborg\n[6]Hacer estudiar al Cyborg");
                opcion = Console.ReadLine();
                switch (opcion){
                    case "1":
                        Console.WriteLine("Ingrese que penso");
                        opcion = Console.ReadLine();
                        robot.pensar(opcion);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese que estudio");
                        opcion = Console.ReadLine();
                        robot.estudiar(opcion);
                        break;
                    case "3":
                        Console.WriteLine("Ingrese que penso");
                        opcion = Console.ReadLine();
                        humano.pensar(opcion);
                        break;
                    case "4":
                        Console.WriteLine("Ingrese que estudio");
                        opcion = Console.ReadLine();
                        humano.estudiar(opcion);
                        break;
                    case "5":
                        Console.WriteLine("Ingrese que penso");
                        opcion = Console.ReadLine();
                        cyborg.pensar(opcion);
                        break;
                    case "6":
                        Console.WriteLine("Ingrese que estudio");
                        opcion = Console.ReadLine();
                        cyborg.estudiar(opcion);
                        break;
                    default:
                        opcion = "Salir";
                        break;
                }
            }

        }
    }
}