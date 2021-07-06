using CodingChallenge.Data.Interface;
using CodingChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _radio;
        public string NombreFormaPlural { get => Res.Circulos; }
        public string NombreFormaSingular { get => Res.Circulo; }
    
        public Circulo(decimal pRadio)
        {
            this._radio = pRadio;
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (this._radio / 2) * (this._radio / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * this._radio;
        }

    }
}
