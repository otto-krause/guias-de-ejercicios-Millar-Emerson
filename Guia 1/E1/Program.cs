using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 10 numeros");
            int[] vector=new int [10];
            int sum=0,i=0,aux=0,j=0;
            int menor=100000;
            float avg=0;
            for (i=0;i<10;i++)
            {
                vector[i]=int.Parse(Console.ReadLine());
                sum+=vector[i];
                if(menor>vector[i])
                {
                    menor=vector[i];
                }
            }
            avg=sum/10;
            for (i=0;i<10;i++)
            {
                for(j=0;j<10;j++)
                {
                    if(vector[i]<vector[j])
                    {
                        aux=vector[i];
                        vector[i]=vector[j];
                        vector[j]=aux;
                    }
                }
            }
            Console.WriteLine("Vector ordenado=");
            for(i=0;i<10;i++)
            {
                Console.WriteLine("|"+vector[i]+"|");
            }
            Console.WriteLine("suma de los elementos="+sum);
            Console.WriteLine("promedio="+avg);
            Console.WriteLine("elemento menor="+menor);
        }
    }
}
