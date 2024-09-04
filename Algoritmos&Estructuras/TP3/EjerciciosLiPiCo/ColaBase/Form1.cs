using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;

namespace Cola01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c = new Cola();
            auxc = new Cola();
        }
        Cola c, auxc;
        private void button1_Click(object sender, EventArgs e)
        {
            c.Encolar(new Nodo(Interaction.InputBox("Id: ")));
            Mostrar();
        }
        private void OtoA()
        {
            OtoARecursiva(c);
        }
        private void OtoARecursiva(Cola pCola)
        {
            listBox1.Items.Add(pCola.Ver().Id);
            auxc.Encolar(pCola.Desencolar());
            if (pCola.Ver()!=null) OtoARecursiva(pCola);

        }
        private void AtoO()
        {
            AtoORecursiva(auxc);
        }
        private void AtoORecursiva(Cola pCola)
        {
            c.Encolar(pCola.Desencolar());
            if (pCola.Ver()!=null) AtoORecursiva(pCola);

        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            if (c.Ver()!=null) { OtoA(); AtoO(); }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nodo d = c.Desencolar();
            if (d!=null)
            {

                Mostrar();
                MessageBox.Show(d.Id);
            }
            else { MessageBox.Show("Cola vacía !!!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nodo d = c.Ver();
            if (d!=null)
            {
                MessageBox.Show(d.Id);
            }
            else { MessageBox.Show("Cola vacía !!!"); }
        }
    }
}
