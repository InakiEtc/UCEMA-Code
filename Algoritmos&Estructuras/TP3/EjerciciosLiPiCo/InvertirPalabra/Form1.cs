using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace InvertirPalabra
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


        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = Interaction.InputBox("Ingrese la palabra a invertir: ");

            for(int i=0; i < palabra.Length; i++)
            {
                pila.Apilar(new Nodo(palabra[i].ToString()));
            }
            Mostrar();
        }

        private void Mostrar()
        {
            textBox1.Text = "";
            ActualizarListBox(pila, textBox1);
        }

        private void ActualizarListBox(Pila pila, TextBox textBox)
        {
            Nodo auxNodo = pila.Ver();
            Pila auxPila = new Pila();
            string cadena = "";

            while (auxNodo != null)
            {
                cadena += auxNodo.Id + "";
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                auxNodo = pila.Ver();
            }
            textBox.Text = cadena;
        }
    }
}
