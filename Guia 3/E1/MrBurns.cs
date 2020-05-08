namespace E1
{
    public class MrBurns
    {
        private bool TieneRiqueza;

        public MrBurns()
        {
            TieneRiqueza = true;
        }

        public bool esMillonario()
        {
            return TieneRiqueza;
        }
        public void DespojarsusRiquezas()
        {
           TieneRiqueza=false; 
        }
    }
}