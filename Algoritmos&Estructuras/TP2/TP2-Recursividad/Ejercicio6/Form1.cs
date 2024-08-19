using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Escribir un programa que encuentre la suma de los enteros positivos pares desde N hasta 2.
        // Chequear que si N es impar seimprima un mensaje de error.
        public int SumaPares(int n)
        {
            if(n % 2 != 0)
            {
                MessageBox.Show("Error: N es impar.");
                return 0;
            }
            else if(n == 2)
            {
                return 2;
            }
            else
            {
                return n + SumaPares(n - 2);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Interaction.InputBox("Ingrese el n: "));
            int suma = SumaPares(n);
            MessageBox.Show("Suma de los enteros positivos pares desde N hasta 2: " + suma);
        }
    }
}
