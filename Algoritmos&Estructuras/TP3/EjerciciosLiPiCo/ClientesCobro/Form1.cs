using Microsoft.VisualBasic;

namespace ClientesCobro
{
    public partial class Form1 : Form
    {
        Cola cola;
        int dineroCobrado,dineroaCobrar,clientesCobrados,clientesSinCobrar = 0;

        public Form1()
        {
            InitializeComponent();
            cola = new Cola();
        }
        private void ActualizarListBox(Cola cola, ListBox listBox)
        {
            Nodo auxNodo = cola.Ver();
            Cola auxCola = new Cola();

            while (auxNodo != null)
            {
                listBox.Items.Add($"{auxNodo.Id} - {auxNodo.Importe}");
                cola.Desencolar();
                auxCola.Encolar(auxNodo);
                auxNodo = cola.Ver();
            }

            auxNodo = auxCola.Ver();
            while (auxNodo != null)
            {
                auxCola.Desencolar();
                cola.Encolar(auxNodo);
                auxNodo = auxCola.Ver();
            }
            textBox1.Text = dineroaCobrar.ToString();
            textBox2.Text = dineroCobrado.ToString();
            textBox3.Text = clientesCobrados.ToString();
            textBox4.Text = clientesSinCobrar.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Ingrese Id: ");
            int importe = Int32.Parse(Interaction.InputBox("Ingrese el importe a cobrar: "));

            Nodo nuevoNodo = new Nodo(id);
            nuevoNodo.Importe = importe;

            cola.Encolar(nuevoNodo);
            listBox1.Items.Clear();            
            dineroaCobrar += importe;
            clientesSinCobrar++;
            ActualizarListBox(cola, listBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Nodo auxNodo = cola.Ver();
            if (auxNodo != null)
            {
                cola.Desencolar();
                dineroCobrado += auxNodo.Importe;
                dineroaCobrar -= auxNodo.Importe;
                clientesCobrados++;
                clientesSinCobrar--;
            }
            listBox1.Items.Clear();
            ActualizarListBox(cola, listBox1);
        }
    }
}
