using System;
namespace E7
{
    public class Camara
    {
        public int megapixel,fotos;
        public Camara (int megapixel,int fotos)
        {
            this.megapixel=megapixel;
            this.fotos=fotos;
        }
        public int pesoPorFoto ()
        {   
            return fotos*(megapixel*3);
        }
        public void PesoTotalDeFotos ()
        {
            int peso,total;
            peso=(1000000*megapixel)*3;
            total=peso*fotos;
            Console.WriteLine("Peso total de todas las fotos="+total);
        } 
    }
}