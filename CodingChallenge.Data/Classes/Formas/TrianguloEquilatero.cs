using CodingChallenge.Data.Interface;
using CodingChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal _lado;
        public string NombreFormaPlural { get => Res.Triangulos; }
        public string NombreFormaSingular { get => Res.Triangulo; }
        public TrianguloEquilatero(decimal plado)
        {
            this._lado = plado;
        }
        public decimal CalcularArea()
        {
            return (decimal) (Math.Sqrt(3) / 4) * this._lado * this._lado;
        }

        public decimal CalcularPerimetro()
        {
            return (decimal) this._lado * 3;
        }
    }
}
