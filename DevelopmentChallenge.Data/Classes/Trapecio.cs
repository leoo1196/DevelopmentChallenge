namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : IForma
    {
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal lado1, decimal lado2, decimal altura)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Lado1 = lado1;
            Lado2 = lado2;
            Altura = altura;
        }

        public decimal BaseMayor { get; set; }
        public decimal BaseMenor { get; set; }
        public decimal Lado1 { get; set; }
        public decimal Lado2 { get; set; }
        public decimal Altura { get; set; }

        public FormaCodigo Codigo => FormaCodigo.Trapecio;

        public decimal CalcularArea()
        {
            return ((BaseMayor + BaseMenor) / 2) * Altura;
        }

        public decimal CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + Lado1 + Lado2;
        }
    }
}
