namespace E6
{
    public class Matematica
    {
        public static int Fibonacci(int num)
        {
            int a=0, b=1, i, auxiliar=0;  
            for (i=0;i<=num;i++)  
            {
                auxiliar = a;
                a = b; 
                b = auxiliar + a; 
            }
            return a;
        }
        public static int Factorial(int num)
        {
            int i=0,total=1;
            for (i=1;i<=num;i++)
            {
                total=total*i;
            }
            return total;
        }
        public static string Mayor (int num,int num1)
        {
            var r=num>num1? "num1 es mayor": "num2 es mayor";
            return r;
        }
        public static string Menor (int num,int num1)
        {
            var r=num<num1? "num1 es menor": "num2 es menor";
            return r;
        }
        public static int Cubo(int num)
        {
            return num*3;
        }
    }
}