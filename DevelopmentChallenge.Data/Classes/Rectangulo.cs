namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : IForma
    {
        public Rectangulo(decimal ancho, decimal alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }

        public decimal CalcularArea()
        {
            return Ancho * Alto;
        }

        public decimal CalcularPerimetro()
        {
            return 2 * (Ancho + Alto);
        }

        public virtual FormaCodigo Codigo => FormaCodigo.Rectangulo;
    }
}
