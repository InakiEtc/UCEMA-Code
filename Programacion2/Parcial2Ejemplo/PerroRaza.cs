using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Ejemplo
{
    internal class PerroRaza : Perro
    {
        public string Raza { get; set; }
        public string SubRaza { get; set; }

        public PerroRaza(int pLegajo, string pNombre, int pEdad, string pRaza, string pSubRaza) : base(pLegajo, pNombre, pEdad)
        {
            Raza = pRaza;
            SubRaza = pSubRaza;
        }
    }
}
