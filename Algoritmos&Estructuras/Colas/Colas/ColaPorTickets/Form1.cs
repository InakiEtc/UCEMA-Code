using Microsoft.VisualBasic;

namespace ColaPorTickets
{
    public partial class Form1 : Form
    {
        Cola colaInicial, colaFinal, colaColados;
        int ticket = 1;
        public Form1()
        {
            InitializeComponent();
            colaInicial = new Cola();
            colaFinal = new Cola();
            colaColados = new Cola();
        }
        private void ActualizarListBox(Cola cola, ListBox listBox)
        {
            Nodo auxNodo = cola.Ver();
            Cola auxCola = new Cola();

            while (auxNodo != null)
            {
                string ticketDisplay = auxNodo.Ticket == 0 ? "" : auxNodo.Ticket.ToString();
                listBox.Items.Add($"{auxNodo.Id} - {ticketDisplay}");
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Ingrese Id: ");

            Nodo nuevoNodo = new Nodo(id);

            // 25% de probabilidad de no asignar ticket
            Random random = new Random();
            if (random.Next(1, 101) <= 75) // 75%
            {
                nuevoNodo.Ticket = ticket;
                ticket++;
            }
            else
            {
                nuevoNodo.Ticket = 0; // No se asigna ticket
            }

            colaInicial.Encolar(nuevoNodo);
            listBox1.Items.Clear();
            ActualizarListBox(colaInicial, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nodo auxNodo = colaInicial.Ver();
            Cola auxCola = new Cola();

            while (auxNodo != null)
            {
                colaInicial.Desencolar();
                auxCola.Encolar(auxNodo);
                auxNodo = colaInicial.Ver();
            }

            auxNodo = auxCola.Ver();
            while (auxNodo != null)
            {
                if (auxNodo.Ticket == 0)
                {
                    colaColados.Encolar(auxNodo);
                }
                else
                {
                    colaFinal.Encolar(auxNodo);
                }
                auxCola.Desencolar();
                colaInicial.Encolar(auxNodo);
                auxNodo = auxCola.Ver();
            }


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            ActualizarListBox(colaInicial, listBox1);
            ActualizarListBox(colaFinal, listBox2);
            ActualizarListBox(colaColados, listBox3);
        }
    }
}
