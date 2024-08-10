using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoAhorroPers
{
    internal class Banco
    {
        List<Persona> personaList;
        DAO dao;

        public Banco()
        {
            personaList = new List<Persona>();
            dao = new DAO();
            dao.CargarDatos(personaList);
        }
        public Persona ExistePersona(int dni)
        {
            Persona p = personaList.Find(x => x.DNI == dni);
            if (p != null)
                return p;
            return null;
        }
        public List<Persona> RetornarPersonas()
        {
            return personaList;
        }
        public void AgregarPersona(Persona p)
        {
            personaList.Add(p);
            dao.GuardarPersonaDB(p);
        }
        public void AgregarAhorro(Ahorro a)
        {
            personaList.Find(personaList => personaList.DNI == a.PersonaDNI).AgregarAhorro(a); 
            dao.GuardarAhorroDB(a);
        }
        public void ModificarPersona(Persona p)
        {
            Persona _paux = personaList.Find(x => x.DNI == p.DNI);
            if (_paux != null)
            {
                personaList.Remove(_paux);
                personaList.Add(p);
                dao.ActualizarPersonaDB(p);
            }
        }
        public void EliminarPersona(Persona p)
        {
            Persona _paux = personaList.Find(x => x.DNI == p.DNI);
            if (_paux != null)
            {
                personaList.Remove(_paux);
                dao.EliminarPersonaDB(_paux);
                dao.EliminarAhorrosDB(_paux);
            }                
        }
        public List<Ahorro> RetornarAhorros(Persona p)
        {
            return p.ahorros;
        }
        public object RetornarTotales(Persona p)
        {
            var _totales = (from a in personaList
                            where a.DNI == p.DNI
                            group a by a.DNI into g
                            select new
                            {
                                Nombre = g.First().Nombre,
                                Apellido = g.First().Apellido,
                                Total = g.Sum(x => x.ahorros.Sum(y => y.Monto))
                            }).ToList();
            return _totales;
        }
        public string RetornaPersonaDNI(int pDni)
        {
            var _persona = personaList.Find(x => x.DNI == pDni);
            if (_persona != null)
            {
                return $"DNI: {_persona.DNI}{Environment.NewLine}" +
                       $"NOMBRE: {_persona.Nombre}{ Environment.NewLine }" +
                       $"APELLIDO: {_persona.Apellido}{Environment.NewLine}";
            }
            else
            {
                throw new Exception("No existe la persona");
            }
        }

        public object RetornarPersonasAsc()
        {
            var _personas = (from p in personaList
                             orderby p.ahorros.Sum(x => x.Monto) ascending
                             select new Persona(p.DNI, p.Nombre, p.Apellido)).ToList();                             
            return _personas;
        }

        public object RetornarPersonasDesc()
        {
            var _personas = (from p in personaList
                             orderby p.ahorros.Sum(x => x.Monto) descending
                             select new Persona(p.DNI, p.Nombre, p.Apellido)).ToList();
            return _personas;
        }
    }
}
