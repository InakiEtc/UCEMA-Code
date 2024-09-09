using Microsoft.VisualBasic;

namespace ListaSEC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lsec = new ListaSEC();
        }
        ListaSEC lsec;
        private void button1_Click(object sender, EventArgs e)
        {
            lsec.AgregarAlPrincipio(new Nodo(Interaction.InputBox("Id: ")));
            Mostrar(lsec);
        }
        private void Mostrar(ListaSEC pLSEC)
        {
            listBox1.Items.Clear();
            Nodo aux = pLSEC.RetornaPrimero();
            if (aux != null)
            {
                do
                {
                    listBox1.Items.Add(aux.Id);
                    aux = aux.Siguiente;
                } while (aux != pLSEC.RetornaPrimero());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsec.AgregarAlFinal(new Nodo(Interaction.InputBox("Id: ")));
            Mostrar(lsec);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lsec.Cantidad().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                lsec.AgregarPosicionN(new Nodo(Interaction.InputBox("Id: ")), Convert.ToInt32(Interaction.InputBox("Posición: ")));
                Mostrar(lsec);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(lsec.RetornaNodoPosN(Convert.ToInt32(Interaction.InputBox("Posición: "))).Id);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                lsec.EliminarAlPrincipio();
                Mostrar(lsec);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                lsec.EliminarAlFinal();
                Mostrar(lsec);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                lsec.EliminarPosicionN(Convert.ToInt32(Interaction.InputBox("Posición: ")));
                Mostrar(lsec);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button9_Click(object sender, EventArgs e)
        { 
            try
            {
                lsec.SwapNodos(Convert.ToInt32(Interaction.InputBox("Posición 1: ")), Convert.ToInt32(Interaction.InputBox("Posición 2: ")));
                Mostrar(lsec);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
