﻿using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=1,count=0;
            List<int> numeros=new List<int>();
            while(numero>0)
            {
                Console.WriteLine("ingrese un numero");
                numero=Int32.Parse(Console.ReadLine());
                numeros.Add(numero);
            }
            numeros.Remove(0);
            foreach(int num in numeros)
            {
                Console.WriteLine("elemento="+num);
                count++;
            }
            Console.WriteLine("cantidad de numero ingresados="+numeros.Count);
            Console.WriteLine("primer elemento="+numeros[0]);
            numeros.Reverse();
            Console.WriteLine("ultimo elemento="+numeros[0]);            
        }
    }
}
