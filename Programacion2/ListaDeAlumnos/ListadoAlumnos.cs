namespace ListaDeAlumnos
{
    internal class ListadoAlumnos
    {
        public List<Alumno> alumnos { get; set; }
        public ListadoAlumnos() { 
            alumnos = new List<Alumno>();
        }
        public void AgregarAlumno(Alumno pAlumno)
        {
            alumnos.Add(new Alumno { Legajo = pAlumno.Legajo, Nombre = pAlumno.Nombre, Apellido = pAlumno.Apellido, FechaNacimiento = pAlumno.FechaNacimiento, FechaIngreso = pAlumno.FechaIngreso, Activo = pAlumno.Activo, CantMateriasAprobadas = pAlumno.CantMateriasAprobadas });
        }
        public void BorrarAlumno(Alumno pAlumno)
        {
            try
            {
                var alumno = alumnos.Find(a => a.Legajo == pAlumno.Legajo);
                if (alumno == null) throw new Exception("No se encontró el alumno a borrar");
                alumnos.Remove(alumno);
            }
            catch (Exception ex) { throw ex; }            
        }
        public void ModificarAlumno(Alumno pAlumno)
        {
            try
            {
                var alumno = alumnos.Find(a => a.Legajo == pAlumno.Legajo);
                if (alumno == null) throw new Exception("No se encontró el alumno a modificar");
                alumno.Nombre = pAlumno.Nombre;
                alumno.Apellido = pAlumno.Apellido;
                alumno.FechaNacimiento = pAlumno.FechaNacimiento;
                alumno.FechaIngreso = pAlumno.FechaIngreso;
                alumno.Activo = pAlumno.Activo;
                alumno.CantMateriasAprobadas = pAlumno.CantMateriasAprobadas;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool VerificarLegajo(Alumno pAlumno)
        {
            return alumnos.Exists(a => a.Legajo == pAlumno.Legajo);
        }
        public List<Alumno> ListarAlumnos()
        {
            List<Alumno> alumnosAux = new List<Alumno>();
            foreach (var alumno in alumnos)
            {
                alumnosAux.Add(new Alumno { Legajo = alumno.Legajo, Nombre = alumno.Nombre, Apellido = alumno.Apellido, FechaNacimiento = alumno.FechaNacimiento, FechaIngreso = alumno.FechaIngreso, Activo = alumno.Activo, CantMateriasAprobadas = alumno.CantMateriasAprobadas });
            }
            return alumnos;
        }
    }
}
