using System.Collections.Generic;
namespace E4
{
    public class Peliteca
    {
        List<Peli> pelis=new List<Peli>();
        public Peliteca()
        {
            pelis.Add(new Peli("El Rey Leon","infantil","Rob Minkoff",1994));
            pelis.Add(new Peli ("Parasite","drama","Bong Joon-ho",2019));
            pelis.Add(new Peli("Kimi no na wa","drama","Makoto Shinkai",2016));
        }
        public int Total()
        {
            int aux;
            aux=pelis.Count;
            return aux;
        }
        public string BuscarGenero (string genero)
        {
            foreach(Peli aux in pelis)
            {
                if(aux.genero==genero)
                {
                    return aux.GetInfo();
                }
            }
            return null;
        }
        public int CuantasPelis()
        {
            return pelis.Count;
        }
        public int PelisporGenere(string genero)
        {
            int count=0;
            foreach (Peli aux in pelis)
            {
                if (aux.genero==genero)
                {
                    count++;
                }
            }
            return count;
        }
        public string BuscarNombre(string nombre)
        {
            foreach(Peli aux in pelis)
            {
                if(aux.nombre==nombre)
                {
                    return aux.GetInfo();
                }
            }
            return null;
        }
        public string BuscarDirector(string director)
        {
            foreach(Peli aux in pelis)
            {
                if(aux.director==director)
                {
                    return aux.GetInfo();
                }
            }
            return null;
        }
        public string BuscarAnio(int anio)
        {
            foreach(Peli aux in pelis)
            {
                if(aux.anio==anio)
                {
                    return aux.GetInfo();
                }
            }
            return null;
        }
    }
}