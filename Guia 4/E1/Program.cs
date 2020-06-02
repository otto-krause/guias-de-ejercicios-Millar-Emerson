using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision=1;
            animales clifford=new Perro(30);
            animales loco=new Pajaro(20);
            Console.WriteLine("ingrese 1 para hacer jugar al perro\n 2 para hacer jugar al pajaro\n 3 para darle de comer al perro\n 4 para darle de comer al pajaro\n 5 para ir a dormir\n 0 para salir\n");
            while(decision!=0)
            {
                decision=Int32.Parse(Console.ReadLine());
                switch(decision)
                {
                    case 1:
                    clifford.jugar();
                    Console.WriteLine("energia del perro="+clifford.Energia());
                    break;
                    case 2:
                    loco.jugar();
                    Console.WriteLine("energia del pajaro="+loco.Energia());
                    break;
                    case 3:
                    loco.comer();
                    Console.WriteLine("energia del pajaro="+loco.Energia());
                    break;
                    case 4:
                    clifford.comer();
                    Console.WriteLine("energia del perro="+clifford.Energia());
                    break;
                    case 5:
                    clifford.dormir();
                    loco.dormir();
                    Console.WriteLine("energia del perro="+clifford.Energia());
                    Console.WriteLine("energia del pajaro="+loco.Energia());
                    break;
                }
            }
        }
    }
}
