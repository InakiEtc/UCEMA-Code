namespace EjercicioDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte dado1, dado2, resultado;
        Byte[] resultados = new Byte[11];
        Random rnd = new Random();
        //hace que  el label4 muestre el valor del hScrollBar1 desde el inicio
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = $"{hScrollBar1.Value} ms";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dado1 = (byte)rnd.Next(1, 7);
            dado2 = (byte)rnd.Next(1, 7);
            label1.Text = dado1.ToString();
            label2.Text = dado2.ToString();
            resultado = Convert.ToByte(dado1 + dado2);
            label3.Text = $"Total: {resultado.ToString()}";
            if (resultado >= 2 && resultado <= 12) resultados[resultado - 2]++;

            textBox1.Text = $"El 2 salio : {resultados[0]} veces\r\n" +
                            $"El 3 salio : {resultados[1]} veces\r\n" +
                            $"El 4 salio : {resultados[2]} veces\r\n" +
                            $"El 5 salio : {resultados[3]} veces\r\n" +
                            $"El 6 salio : {resultados[4]} veces\r\n" +
                            $"El 7 salio : {resultados[5]} veces\r\n" +
                            $"El 8 salio : {resultados[6]} veces\r\n" +
                            $"El 9 salio : {resultados[7]} veces\r\n" +
                            $"El 10 salio : {resultados[8]} veces\r\n" +
                            $"El 11 salio : {resultados[9]} veces\r\n" +
                            $"El 12 salio : {resultados[10]} veces\r\n";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = hScrollBar1.Value;
            label4.Text = $"{hScrollBar1.Value} ms";
        }
    }
}
