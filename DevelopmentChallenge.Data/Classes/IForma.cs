namespace DevelopmentChallenge.Data.Classes
{
    public interface IForma
    {
        decimal CalcularArea();

        decimal CalcularPerimetro();

        FormaCodigo Codigo { get; }
    }
}
