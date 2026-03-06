namespace DevelopmentChallenge.Data.Classes
{
    public interface ILenguajeReporte
    {
        string Cabecera();

        string FooterTotalFormas(int cantidad);

        string FooterTotalArea(decimal totalArea);

        string FooterTotalPerimetro(decimal totalPerimetro);

        string MensajeListaVacia();

        string ObtenerLinea(FormaCodigo codigo, int cantidad, decimal area, decimal perimetro);

        string TraducirForma(FormaCodigo codigo, int cantidad);
    }
}
