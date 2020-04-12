using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            Console.WriteLine("ingrese un numero");
            num=int.Parse(Console.ReadLine());
            static void numeropar(int num){
                if (num%2==0)
                {
                    Console.WriteLine("el numero es par");
                }
                else{
                    Console.WriteLine("no es par");
                }
            }
            static void numeroprimo(int num){
                int i=0,cont=0;
                for (i=1;i<=num;i++)
                {
                    if(num%i==0)
                    {
                        cont++;
                    }
                }
                if (cont==2)
                {
                    Console.WriteLine("es un numero primo");
                }
                else
                {
                    Console.WriteLine("no es primo");
                }
            }
            numeropar(num);
            numeroprimo(num);
        }
    }
}
