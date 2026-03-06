using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : IForma
    {
        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
        }

        public decimal Lado { get; set; }

        public FormaCodigo Codigo => FormaCodigo.TrianguloEquilatero;

        public decimal CalcularArea()
        {
            return (decimal)((Math.Sqrt(3) / 4) * Math.Pow((double)Lado, 2));
        }

        public decimal CalcularPerimetro()
        {
            return Lado * 3;
        }
    }
}
