using System;
namespace E5
{
    public class Triangulo
    {   
        int lado1,lado2,lado3;
        public Triangulo(int lado1,int lado2,int lado3)
        {
            this.lado1=lado1;
            this.lado2=lado2;
            this.lado3=lado3;
        }
        public bool EsEscaleno(int lado1,int lado2,int lado3)
        {
            return lado1!=lado2 && lado1!=lado3 && lado2!=lado3 && lado2!=lado1 && lado3!=lado1 && lado3!=lado2;
        }
        public bool esIsoceles(int lado1,int lado2,int lado3)
        {
            return lado1==lado2 && lado1!=lado3 || lado1==lado3 && lado1!=lado2 || lado2==lado1 && lado2!=lado3 || lado2==lado3 && lado2!=lado1 || lado3==lado1 && lado3!=lado2 || lado3==lado2 && lado3!=lado1;
        }
        public bool EsEquilatero(int lado1,int lado2,int lado3)
        {
            return lado1==lado2 && lado1==lado3;
        }
        public bool esTriangulorectangulo(int lado1,int lado2,int lado3)
        {
            int hipotenusa=0,count=0,catetos=0;
            if (lado1>lado2 && lado1>lado3)
            {
                hipotenusa=lado1*lado1;
                catetos=(lado2*lado2)+(lado3*lado3);
                if (hipotenusa==catetos)
                {
                    count=1;
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
                        count=1;
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
                            count=1;
                        }
                    }
                }
            }
            return count==1;
        }
    }
}