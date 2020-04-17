using System;
namespace E6
{
    public class Matematica
    {
        public static void Fibonacci(int num)
        {
            int a=0, b=1, i, auxiliar=0;  
            for (i=0;i<=num;i++)  
            {
                auxiliar = a;
                a = b; 
                b = auxiliar + a; 
                Console.WriteLine(a);
            }
        }
        public static void Factorial(int num)
        {
            int i=0,total=1;
            for (i=1;i<=num;i++)
            {
                total=total*i;
            }
            Console.WriteLine("factorial:"+total);
        }
        public static void Mayor (int num,int num1)
        {
            Console.WriteLine(num>num1? "num1 es mayor a num2":"num2 es mayor a num1");
        }
        public static void Menor (int num,int num1)
        {
            Console.WriteLine(num<num1? "num1 es menor a num2":"num2 es menor a num1");
        }
        public static void Cubo(int num)
        {
            num=num*num*num;
            Console.WriteLine("el cubo="+num);
        }
    }
}