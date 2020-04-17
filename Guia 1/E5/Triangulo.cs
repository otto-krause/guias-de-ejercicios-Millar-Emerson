using System;
namespace E5
{
    public class Triangulo
    {   
        public static bool EsEscaleno(int lado1,int lado2,int lado3)
        {
            return lado1!=lado2 && lado1!=lado3 && lado2!=lado3;
        }
        public static bool esIsoceles(int lado1,int lado2,int lado3)
        {
            return lado1==lado2 || lado2==lado3 || lado3==lado1;
        }
        public static Boolean EsEquilatero(int lado1,int lado2,int lado3)
        {
            return lado1==lado2 && lado1==lado3;
        }
        public static bool esTriangulorectangulo(int lado1,int lado2,int lado3)
        {
            int hipotenusa=0,cont=0,catetos=0;
            if (lado1>lado2 && lado1>lado3)
            {
                hipotenusa=lado1*lado1;
                catetos=(lado2*lado2)+(lado3*lado3);
                if (hipotenusa==catetos)
                {
                    cont=1;
                }
            }
            else
            {
                if(lado2>lado1 && lado2>lado3)
                {
                    hipotenusa=lado2*lado2;
                    catetos=(lado1*lado1)+(lado3*lado3);
                    if (hipotenusa==catetos)
                    {
                        cont=1;
                    }
                }
                else
                {
                    if(lado3>lado1 && lado3>lado2)
                    {
                        hipotenusa=lado3*lado3;
                        catetos=(lado1*lado1)+(lado2*lado2);
                        if (hipotenusa==catetos)
                        {
                            cont=1;
                        }
                    }
                }
            }
            return cont==1;
        }
    }
}