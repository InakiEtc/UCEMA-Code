using Microsoft.VisualBasic;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //implemente una función recursiva que nos diga si una cadena es palíndromo.
        public bool esPalindromo(string cadena)
        {
            if (cadena.Length <= 1)
            {
                return true;
            }
            else
            {
                if (cadena[0] == cadena[cadena.Length - 1])
                {
                    return esPalindromo(cadena.Substring(1, cadena.Length - 2));
                }
                else
                {
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = Interaction.InputBox("Introduce una cadena");
            if (esPalindromo(cadena))
            {
                MessageBox.Show("Es palíndromo");
            }
            else
            {
                MessageBox.Show("No es palíndromo");
            }

        }
    }
}
