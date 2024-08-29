namespace ColaConPrioridad
{
    internal class Cola
    {
        Nodo Centinela;
        public Cola() { Centinela=new Nodo(); Centinela.Siguiente=null; }
        public void Encolar(Nodo pNodo)
        {
            Nodo nodoClonado = pNodo.CloneTipado();
            if (Centinela.Siguiente == null) // Cola vacía
            { Centinela.Siguiente= nodoClonado; }
            else // Tiene nodos
            {
                Nodo? auxNodo= RetornaUltimo(nodoClonado.Prioridad);
                if (auxNodo != null)
                {
                    if(auxNodo.Prioridad <= nodoClonado.Prioridad)
                    {
                        nodoClonado.Siguiente = auxNodo.Siguiente; 
                        auxNodo.Siguiente = nodoClonado;
                    }
                    else
                    {
                        nodoClonado.Siguiente = Centinela.Siguiente; 
                        Centinela.Siguiente = nodoClonado;
                    }                   
                }
            }
        }
        public Nodo? Desencolar()
        { 
            Nodo? auxNodo = Centinela.Siguiente;
            if (auxNodo!=null) 
            { 
                Centinela.Siguiente=auxNodo.Siguiente;
                auxNodo.Siguiente=null;
            }
            return auxNodo;
        }
        public Nodo? Ver()
        {
            Nodo? auxNodo = Centinela.Siguiente;
            if (Centinela.Siguiente !=null)
            { 
                auxNodo=Centinela.Siguiente.CloneTipado();
            }
            return auxNodo;
        }
        private Nodo? RetornaUltimo(int pPrioridad)
        {
            Nodo? auxNodo = Centinela.Siguiente;
            if (auxNodo != null)
            {
                while (auxNodo.Siguiente != null && auxNodo.Siguiente.Prioridad <= pPrioridad)
                {
                    auxNodo = auxNodo.Siguiente;
                }
            }
            return auxNodo;
        }   
    }
}
