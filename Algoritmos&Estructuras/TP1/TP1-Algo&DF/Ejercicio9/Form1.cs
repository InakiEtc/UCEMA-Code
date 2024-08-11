using Microsoft.VisualBasic;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string primos(int num)
        {
            string serie = "";
            bool esPrimo = true;

            for (int i = 2; i <= num; i++)
            {
                esPrimo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo && i > 1)
                {
                    serie += i + "-";
                }
            }
            return serie;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Interaction.InputBox("Ingrese el numero para devovler la serie"));
            string serie = primos(num);
            textBox1.Text = serie;
        }
    }
}
