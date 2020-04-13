using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision=1,num=0,num1=0;
            Console.WriteLine("ingrese 1 para ver la secuencia fibonacci");
            Console.WriteLine("ingrese 2 para ver el factorial del numero");
            Console.WriteLine("ingrese 3 para ver el mayor de dos numeros");
            Console.WriteLine("ingrese 4 para ver el menor de dos numeros");
            Console.WriteLine("ingrese 5 para ver el cubo de un numero");
            Console.WriteLine("ingrese 0 para salir");
            while(decision!=0)
            {
                decision=Int32.Parse(Console.ReadLine());
                if(decision==1)
                {
                    Console.WriteLine("ingrese un numero entero");
                    num=Int32.Parse(Console.ReadLine());
                    Matematica.Fibonacci(num);
                }
                else
                {
                    if(decision==2)
                    {
                        Console.WriteLine("ingrese un numero entero");
                        num=Int32.Parse(Console.ReadLine());
                        Matematica.Factorial(num);
                    }
                    else
                    {
                        if(decision==3)
                        {
                            Console.WriteLine("ingrese dos numeros enteros");
                            num=Int32.Parse(Console.ReadLine());
                            num1=Int32.Parse(Console.ReadLine());
                            Console.Write("el mayor es=");
                            Matematica.Mayor(num,num1);
                        }
                        else
                        {
                            if(decision==4)
                            {
                                Console.WriteLine("ingrese dos numeros enteros");
                                num=Int32.Parse(Console.ReadLine());
                                num1=Int32.Parse(Console.ReadLine());
                                Console.Write("el menor es=");
                                Matematica.Menor(num,num1);
                            }
                            else
                            {
                                if(decision==5)
                                {
                                    Console.WriteLine("ingrese un numero entero");
                                    num=Int32.Parse(Console.ReadLine());
                                    Matematica.Cubo(num);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
