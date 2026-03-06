using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : IForma
    {
        public Circulo(decimal diametro)
        {
            Diametro = diametro;
        }

        public decimal Diametro { get; set; }
        public decimal Radio => Diametro / 2;

        public FormaCodigo Codigo => FormaCodigo.Circulo;

        public decimal CalcularArea()
        {
            return (decimal)(Math.PI * Math.Pow((double)Radio, 2));
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Diametro;
        }
    }
}
