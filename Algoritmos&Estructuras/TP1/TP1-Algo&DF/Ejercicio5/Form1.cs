namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Algoritmo
        string[,] Ejercico5()
        {
            string[,] matriz;
            int i, j;
           
            i = j = 0;
            matriz = new string[5, 5]{
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" }
            };

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (i == j) matriz[i, j] = "*";
                }
            }
            matriz[i-1, j-1] = "*";
            return matriz;
        }

        // Impresion de la matriz
        private void button1_Click(object sender, EventArgs e)
        {
            string[,] matriz = Ejercico5();
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
