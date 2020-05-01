using System.Collections.Generic;
using System;
namespace E3
{
    public class Album
    {

        List<Figurita> album=new List<Figurita>();
        public void AgregarFigurita(Figurita figu)
        {
            foreach (Figurita aux in album)
            {
                if (aux.nombre!=figu.nombre)
                {
                    if(aux.numerofigurita!=figu.numerofigurita)
                    {
                        album.Add(figu);
                    }
                }
            }
        }
        public int CuantosDelanteros ()
        {
            int cont=0;
            foreach(Figurita aux in album)
            {
                if (aux.posicion=="delantero")
                {
                    cont++;
                }
            }
            return cont;
        }
        public bool EstaCompleto()
        {
            int aux=0;
            aux=album.Count;
            return aux==352;
        }
    }
}