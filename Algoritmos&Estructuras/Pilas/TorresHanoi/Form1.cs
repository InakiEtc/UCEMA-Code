using Microsoft.VisualBasic;

namespace TorresHanoi
{
    public partial class Form1 : Form
    {
        Pila torre1, torre2, torre3;
        int contadorDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) // Boton Empezar/Reiniciar
        {
            torre1 = new Pila();
            torre2 = new Pila();
            torre3 = new Pila();
            contadorDiscos = 0;

            int cant = Convert.ToInt32(Interaction.InputBox("Ingrese cuantos discos quiere usar"));
            for (int i = cant; i >= 1; i--)
            {
                Nodo disco = new Nodo(i.ToString());
                torre1.Apilar(disco);
            }
            Mostrar();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            ActualizarListBox(torre1, listBox1);
            ActualizarListBox(torre2, listBox2);
            ActualizarListBox(torre3, listBox3);

            textBox1.Text = contadorDiscos.ToString();

            if (JuegoTerminado())
            {
                MessageBox.Show("¡Felicidades! Has completado el juego en " + contadorDiscos.ToString() + " intentos");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
            }
        }
        private void ActualizarListBox(Pila torre, ListBox listBox)
        {
            Nodo auxNodo = torre.Ver();
            Pila auxPila = new Pila();

            // Mover nodos de la torre a una pila auxiliar y actualizar el ListBox
            while (auxNodo != null)
            {
                listBox.Items.Add(auxNodo.Id);
                torre.Desapilar();
                auxPila.Apilar(auxNodo);
                auxNodo = torre.Ver();
            }

            // Restaurar los nodos a la torre original desde la pila auxiliar
            auxNodo = auxPila.Ver();
            while (auxNodo != null)
            {
                auxPila.Desapilar();
                torre.Apilar(auxNodo);
                auxNodo = auxPila.Ver();
            }
        }
        private void button1_Click(object sender, EventArgs e) // Mover de 1 a 2
        {
            try
            {
                if (torre1.Ver() != null)
                {
                    if (torre2.Ver() == null || Convert.ToInt32(torre1.Ver().Id) < Convert.ToInt32(torre2.Ver().Id))
                    {
                        torre2.Apilar(torre1.Desapilar());
                        contadorDiscos++;
                        Mostrar();
                    }
                    else
                    {
                        throw new Exception("Movimiento no permitido");
                    }
                }
                else { throw new Exception("No hay discos en la torre 1"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button5_Click(object sender, EventArgs e) // Mover de 1 a 3
        {
            try
            {
                if (torre1.Ver() != null)
                {
                    if (torre3.Ver() == null || Convert.ToInt32(torre1.Ver().Id) < Convert.ToInt32(torre3.Ver().Id))
                    {
                        torre3.Apilar(torre1.Desapilar());
                        contadorDiscos++;
                        Mostrar();
                    }
                    else
                    {
                        throw new Exception("Movimiento no permitido");
                    }
                }
                else { throw new Exception("No hay discos en la torre 1"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button2_Click(object sender, EventArgs e) // Mover de 2 a 1
        {
            try
            {
                if (torre2.Ver() != null)
                {
                    if (torre1.Ver() == null || Convert.ToInt32(torre2.Ver().Id) < Convert.ToInt32(torre1.Ver().Id))
                    {
                        torre1.Apilar(torre2.Desapilar());
                        contadorDiscos++;
                        Mostrar();
                    }
                    else
                    {
                        throw new Exception("Movimiento no permitido");
                    }
                }
                else { throw new Exception("No hay discos en la torre 2"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button6_Click(object sender, EventArgs e) // Mover de 2 a 3
        {
            try
            {
                if (torre2.Ver() != null)
                {
                    if (torre3.Ver() == null || Convert.ToInt32(torre2.Ver().Id) < Convert.ToInt32(torre3.Ver().Id))
                    {
                        torre3.Apilar(torre2.Desapilar());
                        contadorDiscos++;
                        Mostrar();
                    }
                    else
                    {
                        throw new Exception("Movimiento no permitido");
                    }
                }
                else { throw new Exception("No hay discos en la torre 2"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void button3_Click(object sender, EventArgs e) // Mover de 3 a 1
        {
            try
            {
                if (torre3.Ver() != null)
                {
                    if (torre1.Ver() == null || Convert.ToInt32(torre3.Ver().Id) < Convert.ToInt32(torre1.Ver().Id))
                    {
                        torre1.Apilar(torre3.Desapilar());
                        contadorDiscos++;
                        Mostrar();
                    }
                    else
                    {
                        throw new Exception("Movimiento no permitido");
                    }
                }
                else { throw new Exception("No hay discos en la torre 3"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button7_Click(object sender, EventArgs e) // Mover de 3 a 2
        {
            try
            {
                if (torre3.Ver() != null)
                {
                    if (torre2.Ver() == null || Convert.ToInt32(torre3.Ver().Id) < Convert.ToInt32(torre2.Ver().Id))
                    {
                        torre2.Apilar(torre3.Desapilar());
                        contadorDiscos++;
                        Mostrar();
                    }
                    else
                    {
                        throw new Exception("Movimiento no permitido");
                    }
                }
                else { throw new Exception("No hay discos en la torre 3"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private bool JuegoTerminado()
        {
            return torre1.Ver() == null && torre2.Ver() == null;
        }
    }
}
