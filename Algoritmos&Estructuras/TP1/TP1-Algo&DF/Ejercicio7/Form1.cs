using Microsoft.VisualBasic;

namespace Ejercicio7
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
                while ((a + b) < num)
                {                    
                    serie += c + "-";
                    a = b;
                    b = c;
                    c = a + b;
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
