namespace RegistroAutos
{
    internal class Persona
    {
        public Persona(int dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            
        }
        public Persona()
        {
            Autos = new List<Auto>();
        }

        ~Persona()
        {
            Console.WriteLine($"Liberada La persona {DNI}");
        }

        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Auto> Autos { get; set; }
        public int Cantidad_de_Autos()
        {
            return Autos.Count;
        }

    }
}
