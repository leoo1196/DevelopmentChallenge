namespace DevelopmentChallenge.Data.Classes
{
    public class LenguajeItaliano : ILenguajeReporte
    {
        public string Cabecera()
        {
            return "<h1>Rapporto sui forme</h1>";
        }

        public string FooterTotalArea(decimal totalArea)
        {
            return $"Zona {totalArea:#.##}";
        }

        public string FooterTotalFormas(int cantidad)
        {
            return $"{cantidad} forme ";
        }

        public string FooterTotalPerimetro(decimal totalPerimetro)
        {
            return $"Perimetro {totalPerimetro:#.##} ";
        }

        public string MensajeListaVacia()
        {
            return "<h1>Elenco vuoto di forme!</h1>";
        }

        public string ObtenerLinea(FormaCodigo codigo, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {TraducirForma(codigo, cantidad)} | Zona {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }

        public string TraducirForma(FormaCodigo codigo, int cantidad)
        {
            switch (codigo)
            {
                case FormaCodigo.Cuadrado:
                    return cantidad == 1 ? "Piazza" : "Piazze";
                case FormaCodigo.Circulo:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                case FormaCodigo.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case FormaCodigo.Rectangulo:
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
                case FormaCodigo.Trapecio:
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
            }

            return string.Empty;
        }
    }
}
