using Microsoft.VisualBasic;

namespace ListaSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lse = new ListaSE();
        }
        ListaSE lse;
        private void button1_Click(object sender, EventArgs e)
        {
            lse.AgregarAlPrincipio(new Nodo(Interaction.InputBox("Id: ")));
            Mostrar(lse);
        }
        private void Mostrar(ListaSE pLSE)
        {
            listBox1.Items.Clear();
            Nodo aux = pLSE.RetornaPrimero();
            while (aux != null)
            {
                listBox1.Items.Add(aux.Id);
                aux = aux.Siguiente;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lse.AgregarAlFinal(new Nodo(Interaction.InputBox("Id: ")));
            Mostrar(lse);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lse.Cantidad().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                lse.AgregarPosicionN(new Nodo(Interaction.InputBox("Id: ")), Convert.ToInt32(Interaction.InputBox("Posición: ")));
                Mostrar(lse);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(lse.RetornaNodoPosN(Convert.ToInt32(Interaction.InputBox("Posición: "))).Id);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                lse.EliminarAlPrincipio();
                Mostrar(lse);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                lse.EliminarAlFinal();
                Mostrar(lse);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                lse.EliminarPosicionN(Convert.ToInt32(Interaction.InputBox("Posición: ")));
                Mostrar(lse);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button9_Click(object sender, EventArgs e)
        { 
            try
            {
                lse.SwapNodos(Convert.ToInt32(Interaction.InputBox("Posición 1: ")), Convert.ToInt32(Interaction.InputBox("Posición 2: ")));
                Mostrar(lse);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
