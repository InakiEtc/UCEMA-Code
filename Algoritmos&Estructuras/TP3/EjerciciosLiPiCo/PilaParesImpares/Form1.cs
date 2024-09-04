namespace PilaParesImpares
{
    public partial class Form1 : Form
    {
        Pila pila, pilaPar, pilaImpar;
        public Form1()
        {
            InitializeComponent();
            pila=new Pila();
            pilaPar= new Pila();
            pilaImpar = new Pila();

            for (int i = 1; i <= 10; i++)
            {
                pila.Apilar(new Nodo(i.ToString()));
            }
            Mostrar();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            ActualizarListBox(pila, listBox1);
            ActualizarListBox(pilaPar, listBox2);
            ActualizarListBox(pilaImpar, listBox3);
        }
        private void ActualizarListBox(Pila pila, ListBox listBox)
        {
            Nodo auxNodo = pila.Ver();
            Pila auxPila = new Pila();

            // Mover nodos de la torre a una pila auxiliar y actualizar el ListBox
            while (auxNodo != null)
            {
                listBox.Items.Add(auxNodo.Id);
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                auxNodo = pila.Ver();
            }

            // Restaurar los nodos a la torre original desde la pila auxiliar
            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }
        }
        private void SepararParesImpares(Pila pila)
        {
            Nodo auxNodo = pila.Ver();
            Pila auxPila = new Pila();

            while (auxNodo != null)
            {
                if (Convert.ToInt32(auxNodo.Id) % 2 == 0)
                {
                    pilaPar.Apilar(new Nodo(auxNodo.Id));
                }
                else
                {
                    pilaImpar.Apilar(new Nodo(auxNodo.Id));
                }
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                auxNodo = pila.Ver();
            }

            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SepararParesImpares(pila);
            Mostrar();
        }
    }
}
