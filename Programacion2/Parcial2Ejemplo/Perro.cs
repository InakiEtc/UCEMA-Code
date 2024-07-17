using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Ejemplo
{
    internal abstract class Perro
    {
        public int Legajo {  get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Perro(int pLegajo, string pNombre,int pEdad )
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Edad = pEdad;
        }
    }

    
}
