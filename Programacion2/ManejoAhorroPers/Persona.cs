using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoAhorroPers
{
    internal class Persona : Cliente
    {
        public List<Ahorro> ahorros = new List<Ahorro>();
       
        public Persona(int dni, string nombre, string apellido) : base(dni, nombre, apellido)
        {                        
            ahorros = new List<Ahorro>();
        }
        public void AgregarAhorro(Ahorro a)
        {
            ahorros.Add(a);
        }
    }
}
