using System;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class ShapesTests
    {
        private const double Tolerance = 1e-6;

        [Test]
        public void Circulo_AreaPerimetro_CalculatedCorrectly()
        {
            var circulo = new Circulo(2m); // diametro 2 -> radio 1

            var area = (double)circulo.CalcularArea();
            var perimetro = (double)circulo.CalcularPerimetro();

            Assert.AreEqual(Math.PI, area, Tolerance);
            Assert.AreEqual(Math.PI * 2, perimetro, Tolerance);
        }

        [Test]
        public void Cuadrado_AreaPerimetro_CalculatedCorrectly()
        {
            var cuadrado = new Cuadrado(5m);

            var area = cuadrado.CalcularArea();
            var perimetro = cuadrado.CalcularPerimetro();

            Assert.AreEqual(25m, area);
            Assert.AreEqual(20m, perimetro);
        }

        [Test]
        public void Rectangulo_AreaPerimetro_CalculatedCorrectly()
        {
            var rectangulo = new Rectangulo(3m, 4m);

            var area = rectangulo.CalcularArea();
            var perimetro = rectangulo.CalcularPerimetro();

            Assert.AreEqual(12m, area);
            Assert.AreEqual(14m, perimetro);
        }

        [Test]
        public void Trapecio_AreaPerimetro_CalculatedCorrectly()
        {
            // baseMayor 10, baseMenor 6, lados 4 y 4, altura 5
            var trapecio = new Trapecio(10m, 6m, 4m, 4m, 5m);

            var area = trapecio.CalcularArea(); // ((10+6)/2)*5 = 40
            var perimetro = trapecio.CalcularPerimetro(); // 10+6+4+4 = 24

            Assert.AreEqual(40m, area);
            Assert.AreEqual(24m, perimetro);
        }

        [Test]
        public void TrianguloEquilatero_AreaPerimetro_CalculatedCorrectly()
        {
            var triangulo = new TrianguloEquilatero(4m);

            var area = (double)triangulo.CalcularArea(); // sqrt(3)/4 * 16 = 4*sqrt(3)
            var perimetro = (double)triangulo.CalcularPerimetro(); // 12

            Assert.AreEqual(4.0 * Math.Sqrt(3.0), area, Tolerance);
            Assert.AreEqual(12.0, perimetro, Tolerance);
        }
    }
}
