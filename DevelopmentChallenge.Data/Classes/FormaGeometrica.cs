/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<IForma> formas, ILenguajeReporte lenguaje)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(lenguaje.MensajeListaVacia());
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(lenguaje.Cabecera());

                var resultadoSumatorias = formas
                    .GroupBy(forma => forma.Codigo)
                    .Select(group =>
                    {
                        var cantidadFormas = group.Count();
                        var areaTotal = group.Sum(e => e.CalcularArea());
                        var perimetroTotal = group.Sum(e => e.CalcularPerimetro());

                        return new { cantidadFormas, areaTotal, perimetroTotal, codigo = group.Key };
                    })
                    .ToList();

                foreach (var resultado in resultadoSumatorias)
                {
                    sb.Append(lenguaje.ObtenerLinea(resultado.codigo, resultado.cantidadFormas, resultado.areaTotal, resultado.perimetroTotal));
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(lenguaje.FooterTotalFormas(resultadoSumatorias.Sum(e => e.cantidadFormas)));
                sb.Append(lenguaje.FooterTotalPerimetro(resultadoSumatorias.Sum(e => e.perimetroTotal)));
                sb.Append(lenguaje.FooterTotalArea(resultadoSumatorias.Sum(e => e.areaTotal)));
            }

            return sb.ToString();
        }
    }
}
