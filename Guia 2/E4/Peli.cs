namespace E4
{
    public class Peli
    {
        public string nombre,genero,director;
        public int anio;

        public Peli(string nombre, string genero, string director, int anio)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.director = director;
            this.anio = anio;
        }
        public string GetInfo()
        {
            return nombre+"/"+genero+"/"+director+"/"+anio;
        }
    }
}