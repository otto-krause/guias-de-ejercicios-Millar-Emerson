using System;
namespace E7
{
    public class Celular
    {
        bool NFC,Bluethoot;
        int memoria,apps;
        public Celular (bool NFC,bool Bluethoot,int memoria,int apps)
        {
            this.apps=apps;
            this.Bluethoot=Bluethoot;
            this.memoria=memoria;
            this.NFC=NFC;
        }
        public void MemoriaDisponible(int memoria,int apps,int megapixeles,int fotos)
        {
            int total,peso,count;
            peso=(megapixeles)*3;
            total=(peso*fotos)+(70*apps);
            total=memoria-total;
        }
        public bool TeCargaLaSUBE ()
        {
            return NFC;
        }
    }
    public class Camara
    {  
        int megapixeles,fotos;
        public Camara (int megapixeles,int fotos)
        {
            this.megapixeles=megapixeles;
            this.fotos=fotos;
        }
        public void pesoPorFoto (int megapixeles)
        {
            int peso;
            peso=(1000000*megapixeles)*3;
            Console.WriteLine("Peso en bytes="+peso);
        }
        public void PesoTotalDeFotos (int megapixeles,int fotos)
        {
            int peso,total;
            peso=(1000000*megapixeles)*3;
            total=peso*fotos;
            Console.WriteLine("Peso total de todas las fotos="+total);
        }   
    }
}