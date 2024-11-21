using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDEC
{
    internal class Nodo : ICloneable
    {
        public Nodo(string pId = "") { Id=pId; }
        public string Id { get; set; }
        public Nodo? Anterior { get; set; }
        public Nodo? Siguiente { get; set; }

        public object Clone()
        {
            object auxNodo = this.MemberwiseClone();
            ((Nodo)auxNodo).Anterior=null;
            ((Nodo)auxNodo).Siguiente=null;
            return auxNodo;
        }
        public Nodo CloneTipado()
        {
            return (Nodo)Clone();
        }
    }
}
