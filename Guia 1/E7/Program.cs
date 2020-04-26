using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular A30S=new Celular(false,true,64000,104);
            Camara Camara_A30=new Camara(25,794);
            int decision;
            Console.WriteLine("ingrese 1 si quiere saber el peso por foto");
            Console.WriteLine("ingrese 2 si quiere saber si pode cargar la sube");
            Console.WriteLine("ingrese 3 si quiere saber el peso total de las fotos");
            Console.WriteLine("ingrese 4 si quiere saber la memoria total disponible");
            decision=Int32.Parse(Console.ReadLine());
            switch(decision)
            {
                case 1: 
                    Camara_A30.pesoPorFoto();
                    break;
                    case 2:
                        Console.WriteLine("Tenes NFC??"+A30S.TeCargaLaSUBE());
                        break;
                        case 3:
                            Camara_A30.PesoTotalDeFotos();
                            break;
                            case 4:
                                Console.WriteLine("Memoria disponible"+A30S.MemoriaDisponible(2,2,3,5));
                                break;

            }
        }
    }
}
