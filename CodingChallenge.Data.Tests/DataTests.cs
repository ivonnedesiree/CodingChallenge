using System;
using System.Collections.Generic;
using CodingChallenge.Data;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Interface;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
       public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), TiposIdiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), TiposIdiomas.Ingles));
        }
     
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            IFormaGeometrica fcuadrado = new Cuadrado(5);

            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(fcuadrado)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, TiposIdiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {  
                new FormaGeometrica(new Cuadrado(5)),
                new FormaGeometrica(new Cuadrado(1)),
                new FormaGeometrica(new Cuadrado(3))
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, TiposIdiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }
        public void TestResumenListaConUnRectangulo()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(new Rectangulo(6,4)) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, TiposIdiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectangulo | Area 24 | Perimetro 32 <br/>TOTAL:<br/>1 formas Perimetro 32 Area 24", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectanguloEnPortugues()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new FormaGeometrica(new Rectangulo(5,3)),
                new FormaGeometrica(new Rectangulo(5,3)),
                new FormaGeometrica(new Rectangulo(4,2))
            };

            var resumen = FormaGeometrica.Imprimir(rectangulos, TiposIdiomas.Portugues);

            Assert.AreEqual("<h1>Relatório de formas</h1>3 Retângulos | Area 38 | Perímetro 44 <br/>TOTAL:<br/>3 formas Perímetro 44 Area 38", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {

            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(new Cuadrado(5)),
                new FormaGeometrica(new Circulo(3)),
                new FormaGeometrica(new TrianguloEquilatero(4)),
                new FormaGeometrica(new Cuadrado(2)),
                new FormaGeometrica(new TrianguloEquilatero(9)) ,
                new FormaGeometrica(new Circulo(2.75m)) ,
                new FormaGeometrica(new TrianguloEquilatero(4.2m))
            };

            var resumen = FormaGeometrica.Imprimir(formas, TiposIdiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
               new FormaGeometrica(new Cuadrado(5)),
                new FormaGeometrica(new Circulo(3)),
                new FormaGeometrica(new TrianguloEquilatero(4)),
                new FormaGeometrica(new Cuadrado(2)),
                new FormaGeometrica(new TrianguloEquilatero(9)) ,
                new FormaGeometrica(new Circulo(2.75m)) ,
                new FormaGeometrica(new TrianguloEquilatero(4.2m))
            };

            var resumen = FormaGeometrica.Imprimir(formas, TiposIdiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
