using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Interface
{
   public interface IFormaGeometrica
    {
        string NombreFormaSingular { get; }
        string NombreFormaPlural { get; }

        decimal CalcularArea();
        decimal CalcularPerimetro();
      
    }
}
