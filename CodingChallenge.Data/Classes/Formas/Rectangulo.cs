using CodingChallenge.Data.Interface;
using CodingChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        private readonly decimal _base;
        private readonly decimal _altura;
        public string NombreFormaPlural { get => Res.Rectangulos; }
        public string NombreFormaSingular { get => Res.Rectangulo; }

        public Rectangulo(decimal pBase, decimal pAltura)
        {
            this._base = pBase;
            this._altura = pAltura;
        }
        public decimal CalcularArea()
        {
            return (decimal) this._base * this._altura;
        }

        public decimal CalcularPerimetro()
        {
            return (decimal) this._base * 2 + this._altura * 2;
        }
    }
}
