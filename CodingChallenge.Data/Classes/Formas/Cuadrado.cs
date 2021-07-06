using CodingChallenge.Data.Interface;
using CodingChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal _lado;
        public string NombreFormaPlural { get => Res.Cuadrados; }
        public string NombreFormaSingular { get => Res.Cuadrado; }
        public Cuadrado(decimal pLado)
        {
            this._lado = pLado;
        }
        public decimal CalcularArea()
        {
            return (decimal) this._lado * this._lado;
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)this._lado * 4;
        }
    }
}
