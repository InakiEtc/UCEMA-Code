using Microsoft.VisualBasic;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Programe un método recursivo que transforme un número
        //expresado en notación binaria a un número entero.
        private int BinarioAEntero(string binario, int i)
        {
            if (i == binario.Length)
            {
                return 0;
            }
            else
            {

                return (int)Math.Pow(2, binario.Length - i - 1) * (binario[i] - '0') + BinarioAEntero(binario, i + 1);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string binario = Interaction.InputBox("Ingrese un número binario");
            int entero = BinarioAEntero(binario, 0);
            MessageBox.Show("El binario "+binario+" en decimal es: "+entero.ToString());

        }
    }
}
