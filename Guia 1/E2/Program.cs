using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0,num=0,num1=0,total=0;
            Console.WriteLine("ingrese dos numeros enteros");
            num=int.Parse(Console.ReadLine()); 
            num1=int.Parse(Console.ReadLine());
            for(i=0;i<num;i++)
            {
                total=total+num;
            }
            i=0;
            Console.WriteLine(num+"."+num1+"="+total);
            while(num>=num1 && num>0)
            {
                i++;
                num-=num1;
            }
            Console.WriteLine("resto="+num);
            Console.WriteLine("cociente="+i);
        }
    }
}
