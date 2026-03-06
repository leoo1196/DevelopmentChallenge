using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class LenguajeCastellano : ILenguajeReporte
    {
        public string Cabecera()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string FooterTotalArea(decimal totalArea)
        {
            return $"Area {totalArea:#.##}";
        }

        public string FooterTotalFormas(int cantidad)
        {
            return $"{cantidad} formas ";
        }

        public string FooterTotalPerimetro(decimal totalPerimetro)
        {
            return $"Perimetro {totalPerimetro:#.##} ";
        }

        public string MensajeListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string ObtenerLinea(FormaCodigo codigo, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {TraducirForma(codigo, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }

        public string TraducirForma(FormaCodigo codigo, int cantidad)
        {
            switch (codigo)
            {
                case FormaCodigo.Cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case FormaCodigo.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case FormaCodigo.TrianguloEquilatero:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case FormaCodigo.Rectangulo:
                    return cantidad == 1 ? "Rectangulo" : "Rectangulos";
                case FormaCodigo.Trapecio:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
            }

            return string.Empty;
        }
    }
}
