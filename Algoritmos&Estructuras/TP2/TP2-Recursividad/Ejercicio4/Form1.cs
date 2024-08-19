using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public int[] Fibonacci(int n)
        {
            // func recursiva que devuelva un array con los n primeros numeros de fibonacci
            if(n == 0)
            {
               return new int[] { 0 };
            }
            else if (n == 1)
            {
                return new int[] { 0, 1 };
            }
            else
            {
                int[] fib = Fibonacci(n - 1);
                int[] fib2 = new int[fib.Length + 1];
                Array.Copy(fib, fib2, fib.Length);
                fib2[fib2.Length - 1] = fib[fib.Length - 1] + fib[fib.Length - 2];
                return fib2;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Interaction.InputBox("Ingrese el n: "));
            int[] fib = Fibonacci(n);
            string fibo = "";
            for(int i = 0; i < fib.Length; i++)
            {
                fibo += fib[i] + ", ";
            }

            MessageBox.Show("Fibonacci hasta n: " + fibo);
        }
    }
}
