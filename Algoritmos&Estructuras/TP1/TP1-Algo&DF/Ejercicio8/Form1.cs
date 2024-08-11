using Microsoft.VisualBasic;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string serieFibo(int num)
        {
            string serie = "";
            int a = 0;
            int b = 1;
            int c = 0;

            if (num <= 1)
            {
                MessageBox.Show(Text = "El numero debe ser mayor a 1");
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    serie += a + "-";
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            return serie;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Interaction.InputBox("Ingrese el numero para devovler la serie"));
            string serie = serieFibo(num);
            textBox1.Text = serie;
        }
    }
}
