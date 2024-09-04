namespace InvertirPalabra
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

