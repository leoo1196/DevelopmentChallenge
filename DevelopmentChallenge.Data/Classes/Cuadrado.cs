namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(decimal lado) : base(lado, lado)
        {
        }

        public override FormaCodigo Codigo => FormaCodigo.Cuadrado;
    }
}
