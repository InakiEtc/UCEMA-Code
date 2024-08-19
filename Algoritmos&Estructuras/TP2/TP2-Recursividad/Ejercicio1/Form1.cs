using Microsoft.VisualBasic;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Escribir una función recursiva que devuelva la suma de los primeros N enteros
        public int SumaN(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + SumaN(n - 1);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Interaction.InputBox("Ingrese Numero para sumar hasta ese num."));
            int suma = SumaN(n);
            MessageBox.Show("La suma de los primeros " + n + " enteros es: " + suma);
        }
    }
}
