namespace RegistroAutos
{
    internal class Auto
    {
        public Auto(string patente, string marca, string modelo, string color, int anio, float precio)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Anio = anio;
            Precio = precio;
        }

        public Auto()
        {
        }
        ~Auto()
        {
            Console.WriteLine($"Liberado Auto {Patente}");
        }

        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public float Precio { get; set; } 
        public Persona Dueno { get; set; }
    }
}
