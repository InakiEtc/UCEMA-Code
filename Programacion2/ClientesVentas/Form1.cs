using Microsoft.VisualBasic;
using System.Net;

namespace ClientesVentas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            emp = new Empresa();
        }
        Empresa emp;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(Interaction.InputBox("Ingrese el Legajo", "DNI"));
            string nombre = Interaction.InputBox("Ingrese el Nombre", "Nombre");
            string apellido = Interaction.InputBox("Ingrese el Apellido", "Apellido");
            if (radioButton1.Checked)
            {
                ClienteNacional c = new ClienteNacional(legajo, nombre, apellido);
                emp.AgregarCliente(c);
            }
            else
            {
                ClienteInternacional c = new ClienteInternacional(legajo, nombre, apellido);
                emp.AgregarCliente(c);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = emp.GetClientes();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                double monto = double.Parse(Interaction.InputBox("Ingrese el Monto", "Monto"));
                int legajo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                emp.AsignarVenta(legajo, monto);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = emp.GetClientes();
            }
        }
    }
}
