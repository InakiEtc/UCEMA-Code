using Microsoft.VisualBasic;

namespace PilaBase
{
    public partial class Form1 : Form
    {
        Pila pila, pilac;
        public Form1()
        {
            InitializeComponent();
            pila=new Pila();
            pilac= new Pila();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            if (pila.Ver()!=null) { OtoA(); AtoO(); }
        }
        private void OtoA()
        {
            OtoARecursiva(pila);
        }
        private void OtoARecursiva(Pila pPila)
        {
            listBox1.Items.Add(pPila.Ver().Id);
            pilac.Apilar(pPila.Desapilar());
            if (pPila.Ver()!=null) OtoARecursiva(pPila);

        }
        private void AtoO()
        {
            AtoORecursiva(pilac);
        }
        private void AtoORecursiva(Pila pPila)
        {
            pila.Apilar(pPila.Desapilar());
            if (pPila.Ver()!=null) AtoORecursiva(pPila);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pila.Apilar(new Nodo(Interaction.InputBox("Id: ")));
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nodo d = pila.Desapilar();
            if (d!=null)
            {

                Mostrar();
                MessageBox.Show(d.Id);
            }
            else { MessageBox.Show("Pila vacía !!!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nodo d = pila.Ver();
            if (d!=null)
            {
                MessageBox.Show(d.Id);
            }
            else { MessageBox.Show("Pila vacía !!!"); }
        }
    }
}
