using System;
namespace E7
{
    public class Celular
    {
        public bool NFC,Bluethoot;
        public int memoria,app,count;
        public Celular (bool NFC,bool Bluethoot,int memoria,int app)
        {
            this.app=app;
            this.Bluethoot=Bluethoot;
            this.memoria=memoria;
            this.NFC=NFC;
        }
        public int MemoriaDisponible(int memoria,int app,int megapixel,int fotos)
        {
            int total,peso;
            peso=(megapixel)*3;
            total=(peso*fotos)+(70*app);
            total=memoria-total;
            return total;
        }
        public bool TeCargaLaSUBE ()
        {
            return NFC;
        }
    } 
}