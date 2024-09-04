using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaBase
{
    internal class Pila
    {
        Nodo Centinela;
        public Pila() { Centinela=new Nodo(); Centinela.ApuntaA=null; }
        public void Apilar(Nodo pNodo)
        {
            if (Centinela.ApuntaA==null) // Pila vacía
            { Centinela.ApuntaA=pNodo.CloneTipado(); }
            else // Tiene nodos
            {
                Nodo auxNodo = pNodo.CloneTipado();
                auxNodo.ApuntaA = Centinela.ApuntaA;
                Centinela.ApuntaA=auxNodo;

            }
        }
        public Nodo? Desapilar()
        {
            Nodo? auxNodo = Centinela.ApuntaA;
            // Si se retorna un nodo procedemos a cambiar el puntero del centinela para que
            // apunte al nodo que queda en la cima de la pila. Si no hay más nodos apunta a null
            // Luego rompemos la referencia del nodo que retornamos con su ApuntaA=null.
            if (auxNodo!=null)
            {
                Centinela.ApuntaA=auxNodo.ApuntaA;
                auxNodo.ApuntaA=null;
            }
            return auxNodo;
        }
        public Nodo? Ver()
        {
            Nodo? auxNodo = Centinela.ApuntaA;
            if (auxNodo !=null)
            {
                auxNodo=auxNodo.CloneTipado();
            }
            return auxNodo;
        }
      
    }
}

