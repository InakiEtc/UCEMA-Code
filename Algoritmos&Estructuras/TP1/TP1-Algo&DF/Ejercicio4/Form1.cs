namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Algoritmo
        string[,] Ejercicio4()
        {
            string[,] matriz;
            matriz = new string[5, 5]{
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i == j && i < 3) || (i + j == 4 && i < 3) || (j == 2 && i >= 2))  matriz[i, j] = "*";
                }
            }
            return matriz;
        }

        // Impresion de la matriz
        private void button1_Click(object sender, EventArgs e)
        {
            string[,] matriz = Ejercicio4();
            listView1.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    listView1.Items.Add(matriz[i, j]);
                }
            }
        }
    }
}
