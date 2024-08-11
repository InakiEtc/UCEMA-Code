using Microsoft.VisualBasic;

namespace Ejercicio10
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
            int count = 0;

            for (int i = 2; count != num; i++)
            {
                esPrimo = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    serie += i + " ";   
                    count++;
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
