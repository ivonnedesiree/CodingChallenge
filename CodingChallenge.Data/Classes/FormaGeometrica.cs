/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
     public class FormaGeometrica
    {
    
        private readonly IFormaGeometrica _IformaGeometrica;
        public string NombreFormaPlural { get => this._IformaGeometrica.NombreFormaPlural; }
        public string NombreFormaSingular { get => this._IformaGeometrica.NombreFormaSingular; }
        
        public FormaGeometrica(IFormaGeometrica pIFormaGeometrica)
        {
            this._IformaGeometrica = pIFormaGeometrica;
        }

        public decimal CalcularArea()
        {
            return this._IformaGeometrica.CalcularArea();
        }
        public decimal CalcularPerimetro()
        {
            return this._IformaGeometrica.CalcularPerimetro();
        }

        public static string Imprimir(List<FormaGeometrica> forma, string idioma)
        {
          return  ImprimirFormaGeometrica.Imprimir(forma, idioma);
        }

    }
}
