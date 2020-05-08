namespace E1
{
    public class Lenny  : Empleado
    {
        private int cerveza;

        public Lenny()
        {
            this.cerveza = 0;
        }

        public bool EstaDistraido()
        {
            return cerveza>3;
        }
        public void TomarCerveza()
        {
            cerveza++;
        }
    }
}