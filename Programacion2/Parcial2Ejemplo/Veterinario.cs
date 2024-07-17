using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Ejemplo
{
    internal class Veterinario
    {
        List<PerroMestizo> perrosMestizo;
        List<PerroRaza> perrosRaza;

        public Veterinario()
        {
            perrosMestizo = new List<PerroMestizo>();
            perrosRaza = new List<PerroRaza>();
        }

        public void AgregarMestizo(PerroMestizo _p)
        {
            perrosMestizo.Add(_p);
        }
        public void AgregarRaza(PerroRaza _p)
        {
            perrosRaza.Add(_p);
        }

        public void BorrarMestizo(PerroMestizo _p)
        {
            perrosMestizo.Remove(_p);
        }
        public void BorrarRaza(PerroRaza _p)
        {
            perrosRaza.Remove(_p);
        }

        public List<PerroMestizo> RetornarMestizos()
        {
            List<PerroMestizo> MestizosCopia = new List<PerroMestizo>();
            MestizosCopia = (from PerroMestizo p in perrosMestizo select p).ToList();
            return MestizosCopia;
        }
        public List<PerroRaza> RetornarRaza()
        {
            List<PerroRaza> RazaCopia = new List<PerroRaza>();
            RazaCopia = (from PerroRaza p in perrosRaza select p).ToList();
            return RazaCopia;
        }

        public object RetornarPerros()
        {
            //hace un linq entre los perros de raza y mestizos pero con todos los campos posibles
            var perros = (from PerroMestizo p in perrosMestizo
                         select new
                         {
                             Legajo = p.Legajo,
                             Nombre = p.Nombre,
                             Edad = p.Edad,
                             AnioAdopcion = p.AnioAdopcion.ToString(),
                             Raza = "---",
                             SubRaza = "---"
                         }).ToList();
            var perros2 = (from PerroRaza p in perrosRaza
                          select new
                          {
                              Legajo = p.Legajo,
                              Nombre = p.Nombre,
                              Edad = p.Edad,
                              AnioAdopcion = "---",
                              Raza = p.Raza,
                              SubRaza = p.SubRaza
                          }).ToList();
            //concatena las dos listas
            var perrosConcatenados = perros.Cast<dynamic>().Concat(perros2);
            return perrosConcatenados.ToList();

        }
        public void ModificarMestizo(PerroMestizo _p)
        {
            var perro = perrosMestizo.Find(x => x.Legajo == _p.Legajo);
            if (perro != null)
            {
                perrosMestizo.Remove(perro);
                perrosMestizo.Add(_p);
            }
        }

        public void ModificarRaza(PerroRaza _p)
        {
            var perro = perrosRaza.Find(x => x.Legajo == _p.Legajo);
            if (perro != null)
            {
                perrosRaza.Remove(perro);
                perrosRaza.Add(_p);
            }
        }

    }
}
