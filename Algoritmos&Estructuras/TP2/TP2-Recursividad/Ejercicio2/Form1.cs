using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Escribir una función recursiva que devuelva los primeros N números pares.
        public int[] Pares(int n)
        {            
            if (n == 0)
            {
                return new int[0];
            }
            else
            {
                int[] pares = Pares(n - 1);
                int[] pares2 = new int[pares.Length + 1];
                Array.Copy(pares, pares2, pares.Length);
                pares2[n-1] = 2 * n;
                return pares2;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Interaction.InputBox("Ingrese Numero para devovler los n numeros pares."));
            int[] pares = Pares(n);
            string mensaje = "";
            for (int i = 0; i < pares.Length; i++)
            {
                mensaje += pares[i] + "-";
            }
            MessageBox.Show("Los primeros "+n+" pares son: "+mensaje);

        }
    }
}
