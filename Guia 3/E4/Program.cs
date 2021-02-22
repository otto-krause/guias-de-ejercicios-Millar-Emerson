using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            TragaLibros Gabriel = new TragaLibros();
            TragaLibros Juan = new TragaLibros();
            TragaLibros Emerson = new TragaLibros();

            string opcion = "";
            string titulo;
            string autor;
            string nombre;

            while (opcion != "Salir")
            {
                Console.WriteLine("1_Ingresar lectura nueva\n"+"2_CI de Gabriel\n"+"3_CI de Juan leyo\n"+"4_CI de Emerson leyo");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el titulo, el autor del libro y quien lo leyo");
                        titulo = Console.ReadLine();
                        autor = Console.ReadLine();
                        nombre = Console.ReadLine();
                        Libro libro = new Libro(titulo, autor);
                        switch (nombre)
                        {
                            case "Gabriel":
                                Gabriel.Leer(libro);
                                break;
                            case "Juan":
                                Juan.Leer(libro);
                                break;
                            case "Emerson":
                                Emerson.Leer(libro);
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("El CI de Gabriel es: " + Gabriel.CalcularCI());
                        break;

                    case "3":
                        Console.WriteLine("El CI de Juan es: " + Juan.CalcularCI());
                        break;

                    case "4":
                        Console.WriteLine("El CI de Emerson es: " + Emerson.CalcularCI());
                        break;
                        
                    default:
                        opcion = "Salir";
                        break;
                }
            }
        }
    }
}