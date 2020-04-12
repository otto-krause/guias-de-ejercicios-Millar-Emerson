using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision=1,minutos=0;
            Gatito batman=new Gatito("batman",true,50);
            Console.WriteLine("ingrese 1 si quiere saber si quiere saber que el gatito esta saludable");
            Console.WriteLine("ingrese 2 si quiere saber el nombre del gatito");
            Console.WriteLine("ingrese 3 si quiere que el gatito juegue");
            Console.WriteLine("ingrese 4 si quiere que el gatito coma");
            Console.WriteLine("ingrese 0 si quiere salir");
            while (decision!=0)
            {
                decision=Int32.Parse(Console.ReadLine());
                if (decision==1)
                {
                   Console.WriteLine ("El gatito esta vacunado? " +batman.estaSaludable());
                }
                else
                {
                if(decision==2)
                  {
                    Console.WriteLine("nombre del gatito="+ batman.nombre);
                  }
                  else
                  {
                    if(decision==3)
                    {
                      Console.WriteLine("energia del gatito= "+ batman.energia);
                        Console.WriteLine("ingrese los minutos de juego");
                        minutos=Int32.Parse(Console.ReadLine());
                        batman.estajugando(minutos);
                        Console.WriteLine("energia del gatito= "+ batman.energia);
                    }
                    else
                    {
                        if (decision==4)
                        {
                            Console.WriteLine("energia del gatito= "+ batman.energia);
                            batman.estaComiendo();
                            Console.WriteLine("el gatito ya comio, energia del gatito= "+ batman.energia);
                        }
                    }
                  }
                }
            }
        }
    }
}
