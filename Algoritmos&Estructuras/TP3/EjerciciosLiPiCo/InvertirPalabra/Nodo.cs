namespace InvertirPalabra
{
    internal class Nodo : ICloneable
    {
        public Nodo(string pId = "") { Id=pId; }
        public string Id { get; set; }
        public Nodo? ApuntaA { get; set; }

        public object Clone()
        {
            object auxNodo = this.MemberwiseClone();
            ((Nodo)auxNodo).ApuntaA=null;
            return auxNodo;
        }
        public Nodo CloneTipado()
        {
            return (Nodo)Clone();
        }
    }
}
