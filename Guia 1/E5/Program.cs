using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision=1,lado1=0,lado2=0,lado3=0;
            Triangulo triangulo=new Triangulo(3,4,5);
            Console.WriteLine("ingrese 1 para ingresar los lados de un triangulo");
            Console.WriteLine("ingrese 2 para ver si es escaleno");
            Console.WriteLine("ingrese 3 para ver si es equilatero");
            Console.WriteLine("ingrese 4 para ver si es isoceles");
            Console.WriteLine("ingrese 5 para ver si es un triangulo rectangulo");
            Console.WriteLine("ingrese 0 para salir");
            while(decision!=0)
            {
                decision=Int32.Parse(Console.ReadLine());
                if (decision==1)
                {
                    Console.WriteLine("ingrese los 3 lados");
                    lado1=Int32.Parse(Console.ReadLine());
                    lado2=Int32.Parse(Console.ReadLine());  
                    lado3=Int32.Parse(Console.ReadLine()); 
                }
                else
                {
                    if(decision==2)
                    {
                        Console.WriteLine("Es escaleno?"+triangulo.EsEscaleno(lado1,lado2,lado3));
                    }
                    else
                    {
                        if(decision==3)
                        {
                            Console.WriteLine("es equilatero?"+triangulo.EsEquilatero(lado1,lado2,lado3));
                        }
                        else
                        {
                            if(decision==4)
                            {
                                Console.WriteLine("es isoceles?"+triangulo.esIsoceles(lado1,lado2,lado3));
                            }
                            else
                            {
                                if(decision==5)
                                {
                                    Console.WriteLine("es triangulo rectangulo?"+triangulo.esTriangulorectangulo(lado1,lado2,lado3));
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("ingrese otro numero");
            }
        }
    }
}
