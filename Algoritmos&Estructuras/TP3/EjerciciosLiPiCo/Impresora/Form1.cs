using Timer = System.Windows.Forms.Timer;

namespace Impresora
{
    public partial class Form1 : Form
    {
        Cola impresora1, impresora2;
        int idTrabajos, tpImpr1, tpImpr2;        
        public Form1()
        {
            InitializeComponent();
            impresora1 = new Cola();
            impresora2 = new Cola();
            idTrabajos = 1;
            tpImpr1 = 0;
            tpImpr2 = 0;
        }

        private void ActualizarListBox(Cola cola, ListBox listBox)
        {
            Nodo auxNodo = cola.Ver();
            Cola auxCola = new Cola();

            while (auxNodo != null)
            {
                listBox.Items.Add($"{auxNodo.Id} - {auxNodo.Paginas} Paginas");
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

            textBox1.Text = impresora1.Cantidad().ToString();
            textBox2.Text = impresora2.Cantidad().ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Nodo nuevoNodo = new Nodo(idTrabajos.ToString());
            Random random = new Random();
            nuevoNodo.Paginas = random.Next(1, 6);

            if (nuevoNodo.Paginas % 2 == 0)
            {
                impresora1.Encolar(nuevoNodo);
            }
            else
            {
                impresora2.Encolar(nuevoNodo);
            }
            idTrabajos++;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            ActualizarListBox(impresora1, listBox1);
            ActualizarListBox(impresora2, listBox2);

            if (impresora1.Cantidad() == 1)
            {
                ProcesarSiguienteTrabajo(impresora1, timer2);
            }
            if (impresora2.Cantidad() == 1)
            {
                ProcesarSiguienteTrabajo(impresora2, timer3);
            }
        }
        private void ProcesarSiguienteTrabajo(Cola colaImpresion, Timer timer)
        {
            if (colaImpresion.Cantidad() > 0)
            {
                Nodo trabajoActual = colaImpresion.Ver();
                int tiempoProcesamiento = trabajoActual.Paginas * 1000; // 1 segundo por cada página

                timer.Interval = tiempoProcesamiento;
                timer.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (impresora1.Cantidad() > 0)
            {
                impresora1.Desencolar();
                listBox1.Items.Clear();
                ActualizarListBox(impresora1, listBox1);
                tpImpr1++;
                textBox3.Text = tpImpr1.ToString();
                timer2.Stop();

                if (impresora1.Cantidad() > 0)
                {
                    ProcesarSiguienteTrabajo(impresora1,timer2);
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (impresora2.Cantidad() > 0)
            {
                impresora2.Desencolar();
                listBox2.Items.Clear();
                ActualizarListBox(impresora2, listBox2);
                tpImpr2++;
                textBox4.Text = tpImpr2.ToString();
                timer3.Stop();

                if (impresora2.Cantidad() > 0)
                {
                    ProcesarSiguienteTrabajo(impresora2, timer3);
                }
            }
        }
    }
}
