using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Ejemplo
{
    internal class PerroMestizo : Perro
    {
        public int AnioAdopcion {  get; set; }

        public PerroMestizo(int pLegajo, string pNombre, int pEdad, int pAnioAdopcion) : base(pLegajo,pNombre,pEdad)
        {
            AnioAdopcion = pAnioAdopcion;
        }

        public PerroMestizo(PerroMestizo p) : this(p.Legajo,p.Nombre,p.Edad,p.AnioAdopcion) { }
    }
}
