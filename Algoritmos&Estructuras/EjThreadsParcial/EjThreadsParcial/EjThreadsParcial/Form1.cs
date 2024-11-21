namespace EjThreadsParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nroPedido = 1;
        Thread Prep1, Prep2, Prep3, Emp1, Emp2, Env1;
        Queue<Pedido> colaEmpaque = new Queue<Pedido>();
        Queue<Pedido> colaEnvio = new Queue<Pedido>();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(nroPedido, this);
            if (Prep1 == null || !Prep1.IsAlive)
            {
                Prep1 = new Thread(() => pedido.enPreparacion());
                Prep1.Start();
                nroPedido++;
                listBox1.Items.Add($"Pedido: {pedido.Id} - En Preparacion ");
            }
            else if (Prep2 == null || !Prep2.IsAlive)
            {
                Prep2 = new Thread(() => pedido.enPreparacion());
                Prep2.Start();
                nroPedido++;
                listBox1.Items.Add($"Pedido: {pedido.Id} - En Preparacion ");
            }
            else if (Prep3 == null || !Prep3.IsAlive)
            {
                Prep3 = new Thread(() => pedido.enPreparacion());
                Prep3.Start();
                nroPedido++;
                listBox1.Items.Add($"Pedido: {pedido.Id} - En Preparacion ");
            }
        }

        public void EncolarPedidoEmp(Pedido pedido)
        {
            string pedidoString = $"Pedido: {pedido.Id}";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().StartsWith(pedidoString))
                {
                    listBox1.Items.RemoveAt(i);
                    break;
                }
            }
            colaEmpaque.Enqueue(pedido);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (colaEmpaque.Count > 0)
            {
                if (Emp1 == null || !Emp1.IsAlive)
                {
                    Pedido pedidoCola = colaEmpaque.Dequeue();
                    Emp1 = new Thread(() => pedidoCola.enEmpaque());
                    Emp1.Start();
                    listBox2.Items.Add($"Pedido: {pedidoCola.Id} - En Empaque ");
                }
                else if (Emp2 == null || !Emp2.IsAlive)
                {
                    Pedido pedidoCola = colaEmpaque.Dequeue();
                    Emp2 = new Thread(() => pedidoCola.enEmpaque());
                    Emp2.Start();
                    listBox2.Items.Add($"Pedido: {pedidoCola.Id} - En Empaque ");
                }
            }
        }
        public void EncolarPedidoEnv(Pedido pedido)
        {
            string pedidoString = $"Pedido: {pedido.Id}";
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString().StartsWith(pedidoString))
                {
                    listBox2.Items.RemoveAt(i);
                    break;
                }
            }
            colaEnvio.Enqueue(pedido);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (colaEnvio.Count > 0)
            {
                if (Env1 == null || !Env1.IsAlive)
                {
                    Pedido pedidoCola = colaEnvio.Dequeue();
                    Env1 = new Thread(() => pedidoCola.enEnvio());
                    Env1.Start();
                    listBox3.Items.Add($"Pedido: {pedidoCola.Id} - En Envio ");
                }
            }
        }

        public void MostrarPedido(Pedido pedido)
        {
            string pedidoString = $"Pedido: {pedido.Id}";
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                if (listBox3.Items[i].ToString().StartsWith(pedidoString))
                {
                    listBox3.Items.RemoveAt(i);
                    break;
                }
            }
            listBox4.Items.Add($"Pedido: {pedido.Id} - Entregado ");
        }
    }
}
