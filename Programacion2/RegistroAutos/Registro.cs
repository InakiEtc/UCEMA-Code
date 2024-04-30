namespace RegistroAutos
{
    internal class Registro
    {
        List<Auto> autos { get; set; }
        List<Persona> personas { get; set; }

        public Registro()
        {
            autos = new List<Auto>();
            personas = new List<Persona>();
        }

        public void AgregarAuto(Auto pAuto)
        {
            autos.Add(new Auto { Patente = pAuto.Patente, Marca = pAuto.Marca, Modelo = pAuto.Modelo, Color = pAuto.Color, Anio = pAuto.Anio, Precio = pAuto.Precio });
        }
        public void AgregarPersona(Persona pPersona)
        {
            personas.Add(new Persona { DNI = pPersona.DNI, Nombre = pPersona.Nombre, Apellido = pPersona.Apellido });
        }
        public void BorrarAuto(Auto pAuto)
        {
            try
            {
                var auto = autos.Find(a => a.Patente == pAuto.Patente);
                if (auto == null) throw new Exception("No se encontró el auto a borrar");
                autos.Remove(auto);
                
                foreach (var persona in personas)
                {
                    var autoPersona = persona.Autos.Find(a => a.Patente == pAuto.Patente);
                    if (autoPersona != null) persona.Autos.Remove(autoPersona);
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public void BorrarPersona(Persona pPersona)
        {
            try
            {
                var persona = personas.Find(a => a.DNI == pPersona.DNI);
                if (persona == null) throw new Exception("No se encontró la persona a borrar");
                personas.Remove(persona);
                
                foreach (var auto in autos)
                {
                    if (auto.Dueno != null && auto.Dueno.DNI == pPersona.DNI) auto.Dueno = null;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public void ModificarAuto(Auto pAuto)
        {
            try
            {
                var auto = autos.Find(a => a.Patente == pAuto.Patente);
                if (auto == null) throw new Exception("No se encontró el auto a modificar");
                auto.Marca = pAuto.Marca;
                auto.Modelo = pAuto.Modelo;
                auto.Color = pAuto.Color;
                auto.Anio = pAuto.Anio;
                auto.Precio = pAuto.Precio;
                if (pAuto.Dueno != null) auto.Dueno = pAuto.Dueno;

                foreach (var persona in personas)
                {
                    var autoPersona = persona.Autos.Find(a => a.Patente == pAuto.Patente);
                    if (autoPersona != null)
                    {
                        autoPersona.Marca = pAuto.Marca;
                        autoPersona.Modelo = pAuto.Modelo;
                        autoPersona.Color = pAuto.Color;
                        autoPersona.Anio = pAuto.Anio;
                        autoPersona.Precio = pAuto.Precio;
                        if (pAuto.Dueno != null) autoPersona.Dueno = pAuto.Dueno;
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public void ModificarPersona(Persona pPersona)
        {
            try
            {
                var persona = personas.Find(a => a.DNI == pPersona.DNI);
                if (persona == null) throw new Exception("No se encontró la persona a modificar");
                persona.Nombre = pPersona.Nombre;
                persona.Apellido = pPersona.Apellido;
                if (pPersona.Autos != null) persona.Autos = pPersona.Autos;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool VerificarPatente(Auto pAuto)
        {
            return autos.Exists(a => a.Patente == pAuto.Patente);
        }
        public bool VerificarDNI(Persona pPersona)
        {
            return personas.Exists(a => a.DNI == pPersona.DNI);
        }
        public List<Auto> ListarAutos()
        {            
            List<Auto> autosAux = new List<Auto>();
            foreach (var auto in autos)
            {
                autosAux.Add(new Auto { Patente = auto.Patente, Marca = auto.Marca, Modelo = auto.Modelo, Color = auto.Color, Anio = auto.Anio, Precio = auto.Precio });
            }
            return autosAux;
        }
        public List<Persona> ListarPersonas()
        {
            List<Persona> personasAux = new List<Persona>();
            foreach (var persona in personas)
            {
                personasAux.Add(new Persona { DNI = persona.DNI, Nombre = persona.Nombre, Apellido = persona.Apellido, Autos = persona.Autos });
            }
            return personasAux;
        }
        public object ListarAutosconDueno()
        {            
            var at = from a in autos select new { Patente = a.Patente, Marca = a.Marca, Modelo = a.Modelo, Color = a.Color, Anio = a.Anio, Precio = a.Precio,
                DNI = (a.Dueno == null) ? "" : a.Dueno.DNI.ToString(), Nombre = (a.Dueno == null) ? "" : a.Dueno.Apellido + ", " + a.Dueno.Nombre
            };
            return at.ToList();
        }
        public object ListarAutosxPersona(Persona pPersona)
        {
            var at = from a in pPersona.Autos select new { Patente = a.Patente, Marca = a.Marca, Modelo = a.Modelo, Color = a.Color, 
                Anio = a.Anio, Precio = a.Precio };
            return at.ToList();
        }
    }
}
