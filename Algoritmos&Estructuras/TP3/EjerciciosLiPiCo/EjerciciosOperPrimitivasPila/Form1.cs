using Microsoft.VisualBasic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EjerciciosOperPrimitivasPila
{
    public partial class Form1 : Form
    {
        Pila pila;
        public Form1()
        {
            InitializeComponent();
            pila = new Pila();
            for (int i = 0; i < 10; i++)
            {
                pila.Apilar(new Nodo(i.ToString()));
            }
        }

        private void button1_Click(object sender, EventArgs e) // a. Imprimir el contenido de una pila de enteros sin cambiar su contenido. 
        {
            Nodo auxNodo = pila.Ver();
            Pila auxPila = new Pila();

            listBox1.Items.Clear();
            // Mover nodos de la torre a una pila auxiliar y actualizar el ListBox
            while (auxNodo != null)
            {
                listBox1.Items.Add(auxNodo.Id);
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
        private void button2_Click(object sender, EventArgs e) // b. Colocar en el fondo de una pila un nuevo elemento. 
        {
            Pila auxPila = new Pila();
            Nodo auxNodo = pila.Ver();

            while (auxNodo != null)
            {
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                auxNodo = pila.Ver();
            }

            pila.Apilar(new Nodo(Interaction.InputBox("Introduzca un nuevo elemento")));

            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }
        }
        private void button3_Click(object sender, EventArgs e) // c. Calcular el número de elementos de una pila sin modificar su contenido.
        {
            Nodo auxNodo = pila.Ver();
            Pila auxPila = new Pila();
            int contador = 0;

            while (auxNodo != null)
            {
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                contador++;
                auxNodo = pila.Ver();
            }

            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }

            MessageBox.Show("La pila tiene " + contador + " elementos.");
        }
        private void button4_Click(object sender, EventArgs e) // d. Eliminar de una pila todas las ocurrencias de un elemento dado.
        {
            Pila auxPila = new Pila();
            Nodo auxNodo = pila.Ver();
            string elemento = Interaction.InputBox("Introduzca el elemento a eliminar");

            while (auxNodo != null)
            {
                pila.Desapilar();
                if (auxNodo.Id != elemento)
                {
                    auxPila.Apilar(auxNodo);
                }
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
        private void button5_Click(object sender, EventArgs e) // e. Intercambiar los valores del tope y el fondo de una pila.  
        {
            Pila auxPila = new Pila();
            Nodo tope = pila.Ver();
            Nodo fondo = null;

            pila.Desapilar();
            Nodo auxNodo = pila.Ver();
            while (auxNodo != null)
            {
                pila.Desapilar();
                if (pila.Ver() == null)
                {
                    fondo = auxNodo;
                }
                else
                {
                    auxPila.Apilar(auxNodo);
                }
                auxNodo = pila.Ver();
            }

            pila.Apilar(tope);
            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                if (auxNodo != fondo)
                {
                    pila.Apilar(auxNodo);
                }
                auxNodo = auxPila.Ver();
            }
            pila.Apilar(fondo);
        }
        private void button6_Click(object sender, EventArgs e) // f. Duplicar el contenido de una pila.
        {
            Pila auxPila = new Pila();
            Pila auxPila1 = new Pila();
            Nodo auxNodo = pila.Ver();

            while (auxNodo != null)
            {
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                auxPila1.Apilar(auxNodo);
                auxNodo = pila.Ver();
            }

            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }

            auxNodo = auxPila1.Ver();
            while (auxNodo != null)
            {
                auxPila1.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila1.Ver();
            }
        }
        private void button7_Click(object sender, EventArgs e) // g. Verificar si el contenido de una pila de caracteres es un palíndromo.
        {
            Pila auxPila = new Pila();
            Pila auxPila1 = new Pila();
            Nodo auxNodo = pila.Ver();
            bool palindromo = true;

            while (auxNodo != null)
            {
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                auxPila1.Apilar(auxNodo);
                auxNodo = pila.Ver();
            }

            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }

            auxPila = pila;
            auxNodo = auxPila1.Ver();
            Nodo auxNodo1 = auxPila.Ver();

            while (auxNodo != null)
            {
                if (auxNodo.Id == auxNodo1.Id)
                {
                    auxPila.Desapilar();
                    auxPila1.Desapilar();
                    auxNodo = auxPila1.Ver();
                    auxNodo1 = auxPila.Ver();
                }
                else
                {
                    palindromo = false;
                    break;
                }
            }

            if (palindromo)
            {
                MessageBox.Show("La pila es un palíndromo.");
            }
            else
            {
                MessageBox.Show("La pila no es un palíndromo.");
            }
        }
        private void button8_Click(object sender, EventArgs e) // h. Calcular la suma de una pila de enteros sin modificar su contenido.
        {
            Pila auxPila = new Pila();
            Nodo auxNodo = pila.Ver();
            int suma = 0;

            while (auxNodo != null)
            {
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                suma += int.Parse(auxNodo.Id);
                auxNodo = pila.Ver();
            }

            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }

            MessageBox.Show("La suma de los elementos de la pila es " + suma + ".");
        }
        private void button9_Click(object sender, EventArgs e) // i.Calcular el máximo de una pila de números reales.
        {
            Pila auxPila = new Pila();
            Nodo auxNodo = pila.Ver();
            double maximo =double.Parse(auxNodo.Id);

            while (auxNodo != null)
            {
                pila.Desapilar();
                auxPila.Apilar(auxNodo);
                if (double.Parse(auxNodo.Id) > maximo)
                {
                    maximo = double.Parse(auxNodo.Id);
                }
                auxNodo = pila.Ver();
            }

            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                pila.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }

            MessageBox.Show("El máximo de los elementos de la pila es " + maximo + ".");

        }
    }
}
