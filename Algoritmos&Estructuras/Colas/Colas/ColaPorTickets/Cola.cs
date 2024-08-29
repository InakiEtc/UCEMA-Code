namespace ColaPorTickets
{
    internal class Cola
    {
        Nodo Centinela;
        public Cola() { Centinela=new Nodo(); Centinela.Siguiente=null; }
        public void Encolar(Nodo pNodo)
        {
            if (Centinela.Siguiente==null) // Cola vacía
            { Centinela.Siguiente=pNodo.CloneTipado(); }
            else // Tiene nodos
            {
                Nodo? auxNodo= RetornaUltimo();
                if (auxNodo!=null) auxNodo.Siguiente=pNodo.CloneTipado();
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
        private Nodo? RetornaUltimo()
        {
            return RetornaUltimoRecursiva(Centinela.Siguiente);
        }
        private Nodo? RetornaUltimoRecursiva(Nodo? pNodo)
        {
            Nodo? auxNodo = pNodo;
            if (auxNodo !=null)
            { 
                if (auxNodo.Siguiente!=null) auxNodo = RetornaUltimoRecursiva(auxNodo.Siguiente);
            }
            return auxNodo;
        }   
    }
}
