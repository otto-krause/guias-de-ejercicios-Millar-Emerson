using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision=1;
            Empresa Drink=new Empresa();
            Console.WriteLine("ingrese 1 para tener una noche de risas\n2 para tener una noche de sustos\n3 para ver a los monstruos mas respetables\n4 para ver cuanta energia genero la empresa");
            while(decision!=0)
            {
                decision=Int32.Parse(Console.ReadLine());
                switch(decision)
                {
                    case 1:
                    Drink.NochedeRisas();
                    break;
                    case 2:
                    Drink.NochedeSustos();
                    break;
                    case 3:
                    foreach(monster_energy x in Drink.Respetables())
                    {
                        Console.WriteLine(x.Name()+" "+x.Respeto());
                    }
                    break;
                    case 4:
                    Console.WriteLine(Drink.Energia());
                    break;
                }
            }
        }
    }
}
