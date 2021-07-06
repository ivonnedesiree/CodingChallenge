using CodingChallenge.Data.Interface;
using CodingChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ImprimirFormaGeometrica
    {
        public ImprimirFormaGeometrica() { }
        
        public static string Imprimir(List<FormaGeometrica> formas, string idioma)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(idioma);
            var sb = new StringBuilder();

            //por defecto es en ingles

            if (!formas.Any())
            {
                sb.Append(String.Concat("<h1>", Res.Lista_vacia_de_formas, "</h1>"));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(String.Concat("<h1>", Res.Reporte_de_formas, "</h1>"));


                List<string> Tiposformas = new List<string>();

                //obtener sumatoria segun el tipo de forma geometrica, dinamicamente

                int cantidadTotal = 0;
                decimal areaTotal = 0;
                decimal perimetroTotal = 0;

                foreach (FormaGeometrica forma in formas)
                {
                    if (Tiposformas.Where(t => t == forma.NombreFormaSingular).Count().Equals(0))
                    {
                        int cantidad = formas.Where(f => f.NombreFormaSingular == forma.NombreFormaSingular).Count();
                        decimal area = formas.Where(f => f.NombreFormaSingular == forma.NombreFormaSingular).Sum(t => t.CalcularArea());
                        decimal perimetro = formas.Where(f => f.NombreFormaSingular == forma.NombreFormaSingular).Sum(t => t.CalcularPerimetro());
                        sb.Append(ObtenerLinea(cantidad, area, perimetro, forma));
                        cantidadTotal += cantidad;
                        areaTotal += area;
                        perimetroTotal += perimetro;

                        Tiposformas.Add(forma.NombreFormaSingular);
                    }
                }

                // FOOTER
                sb.Append(String.Concat(Res.Total.ToUpper(), ":<br/>"));
                sb.Append(String.Concat(cantidadTotal , " " , Res.Formas , " "));
                sb.Append(String.Concat(Res.Perimetro ," ", (perimetroTotal).ToString("#.##") , " "));
                sb.Append(String.Concat(Res.Area, " " , (areaTotal).ToString("#.##")));
            }

            return sb.ToString();
        }
        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica tipo)
        {
            string traduccion = cantidad > 1 ? tipo.NombreFormaPlural : tipo.NombreFormaSingular;

             return $"{cantidad} {traduccion} | {Res.Area} {area:#.##} | {Res.Perimetro} {perimetro:#.##} <br/>";
        }
    }
}
