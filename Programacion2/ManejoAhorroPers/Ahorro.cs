using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoAhorroPers
{
    internal class Ahorro
    {
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public int PersonaDNI { get; set; }

        public Ahorro(DateTime fecha, decimal monto, int personaDNI)
        {
            Fecha = fecha;
            Monto = monto;
            PersonaDNI = personaDNI;
        }
    }
}
