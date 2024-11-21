using Microsoft.VisualBasic;

namespace ListaDEC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lde = new ListaDEC();
        }
        ListaDEC lde;
        private void button1_Click(object sender, EventArgs e)
        {
            lde.AgregarAlPrincipio(new Nodo(Interaction.InputBox("Id: ")));
            Mostrar(lde);
        }
        private void Mostrar(ListaDEC pLSE)
        {
            listBox1.Items.Clear();
            Nodo aux = pLSE.RetornaPrimero();
            if (aux != null)
            {
                do
                {
                    listBox1.Items.Add(aux.Id);
                    aux = aux.Siguiente;
                } while (aux != pLSE.RetornaPrimero());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lde.AgregarAlFinal(new Nodo(Interaction.InputBox("Id: ")));
            Mostrar(lde);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lde.Cantidad().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                lde.AgregarPosicionN(new Nodo(Interaction.InputBox("Id: ")), Convert.ToInt32(Interaction.InputBox("Posición: ")));
                Mostrar(lde);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(lde.RetornaNodoPosN(Convert.ToInt32(Interaction.InputBox("Posición: "))).Id);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                lde.EliminarAlPrincipio();
                Mostrar(lde);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                lde.EliminarAlFinal();
                Mostrar(lde);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                lde.EliminarPosicionN(Convert.ToInt32(Interaction.InputBox("Posición: ")));
                Mostrar(lde);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button9_Click(object sender, EventArgs e)
        { 
            try
            {
                lde.SwapNodos(Convert.ToInt32(Interaction.InputBox("Posición 1: ")), Convert.ToInt32(Interaction.InputBox("Posición 2: ")));
                Mostrar(lde);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
