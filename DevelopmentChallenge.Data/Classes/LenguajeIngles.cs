using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class LenguajeIngles : ILenguajeReporte
    {
        public string Cabecera()
        {
            return "<h1>Shapes report</h1>";
        }

        public string FooterTotalArea(decimal totalArea)
        {
            return $"Area {totalArea:#.##}";
        }

        public string FooterTotalFormas(int cantidad)
        {
            return $"{cantidad} shapes ";
        }

        public string FooterTotalPerimetro(decimal totalPerimetro)
        {
            return $"Perimeter {totalPerimetro:#.##} ";
        }

        public string MensajeListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string ObtenerLinea(FormaCodigo codigo, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {TraducirForma(codigo, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
        }

        public string TraducirForma(FormaCodigo codigo, int cantidad)
        {
            switch (codigo)
            {
                case FormaCodigo.Cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";
                case FormaCodigo.Circulo:
                    return cantidad == 1 ? "Circle" : "Circles";
                case FormaCodigo.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case FormaCodigo.Rectangulo:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
                case FormaCodigo.Trapecio:
                    return cantidad == 1 ? "Trapeze" : "Trapezoids";
            }

            return string.Empty;
        }
    }
}
