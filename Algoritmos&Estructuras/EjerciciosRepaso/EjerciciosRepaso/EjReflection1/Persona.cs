using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjReflection1
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }

        public Persona() { }
        public Persona(string nombre, int edad, string email)
        {
            Nombre = nombre;
            Edad = edad;
            Email = email;
        }

    }
}
