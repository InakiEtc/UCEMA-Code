using Microsoft.VisualBasic;

namespace ColaConPrioridad
{
    public partial class Form1 : Form
    {
        Cola colaPrioridad;
        public Form1()
        {
            InitializeComponent();
            colaPrioridad = new Cola();
        }
        private void ActualizarListBox(Cola cola, ListBox listBox)
        {
            Nodo auxNodo = cola.Ver();
            Cola auxCola = new Cola();

            while (auxNodo != null)
            {
                listBox.Items.Add($"{auxNodo.Id} - {auxNodo.Prioridad}");
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
            int prioridad = Convert.ToInt32(Interaction.InputBox("Ingrese prioridad: "));

            Nodo nuevoNodo = new Nodo(id);
            nuevoNodo.Prioridad = prioridad;

            colaPrioridad.Encolar(nuevoNodo);
            listBox1.Items.Clear();
            ActualizarListBox(colaPrioridad, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nodo auxNodo = colaPrioridad.Desencolar();
            listBox1.Items.Clear();
            ActualizarListBox(colaPrioridad, listBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //for (int i = 1; i <= 20; i++)
            //{
            //    Nodo nuevoNodo = new Nodo(i.ToString());
            //    nuevoNodo.Prioridad = rnd.Next(1, 4);
            //    colaPrioridad.Encolar(nuevoNodo);
            //}
            //listBox1.Items.Clear();
            //ActualizarListBox(colaPrioridad, listBox1);
        }
    }
}
