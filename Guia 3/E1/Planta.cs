namespace E1
{
    public class Planta
    {
        private int BarradeUranio;
        private MrBurns burns;
        private Empleado empleado;

        public Planta(int BarradeUranio, Empleado empleado,MrBurns burns)
        {
            this.BarradeUranio = BarradeUranio;
            this.burns = burns;
            this.empleado=empleado;
        }

        public bool EstaenPeligro()
        {
            return (BarradeUranio>10000 && empleado.EstaDistraido())
            ||  !burns.esMillonario();
        }
        public void CambiarEmpleado(Empleado nuevoEmpleado){
            empleado=nuevoEmpleado;
        }
    }
}