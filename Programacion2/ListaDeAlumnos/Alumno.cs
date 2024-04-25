using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeAlumnos
{
    internal class Alumno
    {
        public Alumno(int legajo, string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso, int cantMateriasAprobadas)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            FechaIngreso = fechaIngreso;
            Activo = true;
            CantMateriasAprobadas = cantMateriasAprobadas;
        }
        public Alumno()
        {           
        }
        ~Alumno()
        {
            MessageBox.Show($"El alumno {Legajo} - {Nombre} {Apellido} ha sido eliminado.");
        }

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Edad {
            get { return DateTime.Now.Year - FechaNacimiento.Year; }
        }
        public bool Activo { get; set; }
        public int CantMateriasAprobadas { get; set; }

        public int CalcularAntiguedad(string unidad)
        {
            var antiguedad = DateTime.Now - FechaIngreso;

            switch (unidad.ToLower())
            {
                case "a":
                    return (antiguedad.Days / 365);
                case "m":
                    return (antiguedad.Days / 30);
                case "d":
                    return antiguedad.Days;
                default:
                    throw new ArgumentException("La unidad debe ser 'años', 'meses' o 'días'.");
            }
        }

        public int GetMateriasNoAprobadas()
        {
            return 36 - CantMateriasAprobadas;
        }

        public int GetEdadDeIngreso()
        {
            return FechaIngreso.Year - FechaNacimiento.Year;
        }
    }
}
