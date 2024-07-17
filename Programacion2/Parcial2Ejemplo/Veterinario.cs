using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public List<dynamic> RetornarPerros()
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

        public object RetornarAscendente()
        {
            var _perrosList = RetornarPerros();            
            var aux = (from dynamic p in _perrosList
                       orderby p.Nombre ascending
                       select new
                       {
                           Legajo = p.Legajo,
                           Nombre = p.Nombre,
                           Edad = p.Edad,
                           Raza = p.Raza,
                           Subraza = p.SubRaza,
                           adopcion = p.AnioAdopcion
                       }).ToList();
            return aux;
        }

        public object RetornarDescendente()
        {
            var _perrosList = RetornarPerros();
            var aux = (from dynamic p in _perrosList
                       orderby p.Nombre descending
                       select new
                       {
                           Legajo = p.Legajo,
                           Nombre = p.Nombre,
                           Edad = p.Edad,
                           Raza = p.Raza,
                           Subraza = p.SubRaza,
                           adopcion = p.AnioAdopcion
                       }).ToList();
            return aux;
        }

        public string RetornaPerroLegajo(int pLegajo)
        {

            var perrM = perrosMestizo.Find(p => p.Legajo == pLegajo);
            if (perrM == null)
            {
                var perrR = perrosRaza.Find(p => p.Legajo == pLegajo);
                if (perrR == null)
                {
                    throw new Exception("No se encontro el perro");
                }
                else
                {       
                    return $"PERRO RAZA: {Environment.NewLine}" +
                            $"Legajo: {perrR.Legajo} {Environment.NewLine}" +
                            $"Nombre: {perrR.Nombre} {Environment.NewLine}" +
                            $"Edad: {perrR.Edad} {Environment.NewLine}" +
                            $"Raza: {perrR.Raza} {Environment.NewLine}" +
                            $"SubRaza: {perrR.SubRaza} {Environment.NewLine}";
                }
            }
            else
            {
                return $"PERRO MESTIZO: {Environment.NewLine}" +
                            $"Legajo: {perrM.Legajo} {Environment.NewLine}" +
                            $"Nombre: {perrM.Nombre} {Environment.NewLine}" +
                            $"Edad: {perrM.Edad} {Environment.NewLine}" +                          
                            $"AnioAdop: {perrM.AnioAdopcion} {Environment.NewLine}";
            }            
        }
    }
}
