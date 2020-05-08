using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homero homero=new Homero(4);
            Lenny Lenny=new Lenny();
            PatoBalancin pato=new PatoBalancin();
            MrBurns burns=new MrBurns();
            Planta planta=new Planta(10001, homero,burns);
            string opcion="";
            do{
                Console.WriteLine("1_para ver si la planta esta en peligro\n 2_Homero come donas\n3_ Homero compra donas\n4_Lenny toma cerveza\n5_cambiar a homero\n6_cambiar empleado por Lenny\n7_cambiar empleado por el pato\n8_despojar a Burns de sus riquezas");
                opcion=Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                        Console.WriteLine(planta.EstaenPeligro());
                    break;
                    case "2":
                    homero.comer();
                    break;
                    case "3":
                    homero.comprar();
                    break;
                    case "4":
                    Lenny.TomarCerveza();
                    break;
                    case "5":
                    planta.CambiarEmpleado(homero);
                    break;
                    case "6":
                    planta.CambiarEmpleado(Lenny);
                    break;
                    case "7":
                    planta.CambiarEmpleado(pato);
                    break;
                    case "8":
                    burns.DespojarsusRiquezas();
                    break;
                    default:
                        opcion="salir";
                        break;
                }
            }
            while(opcion!="salir");
        }
    }
}
