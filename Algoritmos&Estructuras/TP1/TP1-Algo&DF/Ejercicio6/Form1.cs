namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        int n1, n2, n3;
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            n1 = r.Next(1, 100);
            n2 = r.Next(1, 100);
            n3 = r.Next(1, 100);
            textBox1.Text = n1.ToString() + " - " + n2.ToString() + " - " + n3.ToString();
        }

        List<int> ordernarNumeros(int n1, int n2, int n3)
        {
            List<int> listaOrdenada;
            listaOrdenada = new List<int>();       

            if (n1 > n2) (n1, n2) = (n2, n1);
            if (n1 > n3) (n1, n3) = (n3, n1);
            if (n2 > n3) (n2, n3) = (n3, n2);

            listaOrdenada.AddRange(new List<int> { n1, n2, n3 });

            return listaOrdenada;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> listaOrdenada = ordernarNumeros(n1,n2,n3);
            textBox2.Text = string.Join(" - ", listaOrdenada);
        }
    }
}
