namespace _1.Probabilidad_de_ocurrencia
{
    internal class SimboloProb
    {
        char caracter;
        double probabilidad;

        public SimboloProb(char caracter, double probabilidad)
        {
            this.Caracter = caracter;
            this.Probabilidad = probabilidad;
        }

        public char Caracter { get => caracter; set => caracter = value; }
        public double Probabilidad { get => probabilidad; set => probabilidad = value; }

        public override string ToString()
        {
            return caracter + ": " + probabilidad.ToString("#.####") ;
        }
    }
}