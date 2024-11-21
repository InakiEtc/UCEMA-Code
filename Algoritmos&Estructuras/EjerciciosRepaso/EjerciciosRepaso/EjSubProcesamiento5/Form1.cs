using Microsoft.VisualBasic;
using System.Collections.Concurrent;

namespace EjSubProcesamiento5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var tam = int.Parse(Interaction.InputBox("Ingrese el tamaño del vector", "Tamaño del vector", "0"));
            var part = int.Parse(Interaction.InputBox("Ingrese la cantidad de particiones", "Particiones", "0"));

            if (tam % part != 0)
            {
                MessageBox.Show("El tamaño del vector no es divisible por la cantidad de particiones");
                return;
            }

            var hilos = new Thread[part];
            var vector = new int[tam];
            var resultados = new ConcurrentBag<int>();

            for (int i = 0; i < tam; i++)
            {
                //vector[i] = new Random().Next(1, 10);
                vector[i] = 1;
            }

            for (int i = 0; i < part; i++)
            {
                var inicio = i * (tam / part);
                var fin = inicio + (tam / part);

                hilos[i] = new Thread(() => SumarSubElementos(vector, resultados, inicio, fin));
                hilos[i].Start();
                hilos[i].Join();
            }

            var sumaTotal = 0;
            foreach (var suma in resultados)
            {
                sumaTotal += suma;
            }
            listBox1.Items.Add("La suma total es: " + sumaTotal);
        }

        private void SumarSubElementos(int[] vector, ConcurrentBag<int> resultados, int inicio, int fin)
        {
            var suma = 0;
            for(int i = inicio; i < fin; i++)
            {
                suma += vector[i];
            }
            resultados.Add(suma);
        }
    }
}
