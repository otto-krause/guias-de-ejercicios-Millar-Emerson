using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision=0,lado1=0,lado2=0,lado3=0;
            Console.WriteLine("ingrese 1 para ingresar los lados de un triangulo");
            Console.WriteLine("ingrese 2 para ver si es escaleno");
            Console.WriteLine("ingrese 3 para ver si es equilatero");
            Console.WriteLine("ingrese 4 para ver si es isoceles");
            Console.WriteLine("ingrese 5 para ver si es un triangulo rectangulo");
            Console.WriteLine("ingrese 0 para salir");
            while(decision=!0)
            {
                decision=Int32.Parse(Console.ReadLine());
                if (decision==1)
                {
                    Console.WriteLine("ingrese los 3 lados");
                    lado1=Int32.Parse(Console.ReadLine());
                    lado2=Int32.Parse(Console.ReadLine());  
                    lado3=Int32.Parse(Console.ReadLine()); 
                    Triangulo Usuario=new Triangulo(lado1,lado2,lado3);
                }
                else
                {
                    if(decision==2)
                    {
                        esEscaleno();
                    }
                    else
                    {
                        if(decision==3)
                        {
                            esEquilatero();
                        }
                        else
                        {
                            if(decision==4)
                            {
                                esIsoceles();
                            }
                            else
                            {
                                if(decision==5)
                                {
                                    esTrianguloRectangulo();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
