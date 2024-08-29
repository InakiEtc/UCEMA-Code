using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Natatorio
{
    public partial class Form1 : Form
    {
        Cola colaInicial, colaH, colaM;
        public Form1()
        {
            InitializeComponent();
            colaInicial = new Cola();
            colaH = new Cola();
            colaM = new Cola();
        }
        private void ActualizarListBox(Cola cola, ListBox listBox)
        {
            Nodo auxNodo = cola.Ver();
            Cola auxCola = new Cola();

            while (auxNodo != null)
            {
                listBox.Items.Add(auxNodo.Id);
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
            string sexo = Interaction.InputBox("Ingrese Sexo (H/M): ");

            Nodo nuevoNodo = new Nodo(id);
            nuevoNodo.Sexo = sexo;

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
                if (auxNodo.Sexo == "H")
                {
                    colaH.Encolar(auxNodo);
                }
                else
                {
                    colaM.Encolar(auxNodo);
                }
                auxCola.Desencolar();
                colaInicial.Encolar(auxNodo);
                auxNodo = auxCola.Ver();
            }
            

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            ActualizarListBox(colaInicial, listBox1);
            ActualizarListBox(colaH, listBox2);
            ActualizarListBox(colaM, listBox3);
        }
    }
}
