using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace InvertirNumero
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
            int numero = Convert.ToInt32(Interaction.InputBox("Ingrese el numero a invertir: "));
            string nums = numero.ToString();

            for(int i=0; i < nums.Length; i++)
            {
                pila.Apilar(new Nodo(nums[i].ToString()));
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
