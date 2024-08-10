using Microsoft.VisualBasic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ManejoAhorroPers
{
    public partial class Form1 : Form
    {
        Banco ban;
        public Form1()
        {
            InitializeComponent();
        }
        //TODO: agregar el evento del ejercicio
        private void Form1_Load(object sender, EventArgs e)
        {
            ban = new Banco();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView1.DataSource = ban.RetornarPersonas();

            if (dataGridView1.Rows.Count > 0)
            {
                Persona p = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                dataGridView2.DataSource = ban.RetornarAhorros(p);
                dataGridView3.DataSource = ban.RetornarTotales(p);
            }

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Persona p = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                dataGridView2.DataSource = ban.RetornarAhorros(p);
                dataGridView3.DataSource = ban.RetornarTotales(p);
            }
            catch (Exception) { }
        }
        //TODO: cuando agreggo 2 persona seguidas y clickeo en la segunda, pincha x out of range
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var _dni = Convert.ToInt32(Interaction.InputBox("Ingrese DNI", "Ingresando Persona"));
                if (ban.ExistePersona(_dni) != null)
                {
                    MessageBox.Show("Persona ya existe");
                    return;
                }
                var _nombre = Interaction.InputBox("Ingrese Nombre", "Ingresando Persona");
                var _apellido = Interaction.InputBox("Ingrese Apellido", "Ingresando Persona");
                Persona _p = new Persona(_dni, _nombre, _apellido);
                ban.AgregarPersona(_p);

                DateTime _fecha = DateTime.Now;
                var _ahorro = Convert.ToDecimal(Interaction.InputBox("Ingrese el Ahorro, cuando sea 0 o menor corta", "Ingresando Ahorro"));
                while (_ahorro > 0)
                {
                    _fecha = DateTime.Now;
                    Ahorro _a = new Ahorro(_fecha, _ahorro, _dni);
                    ban.AgregarAhorro(_a);
                    _ahorro = Convert.ToDecimal(Interaction.InputBox("Ingrese el Ahorro, cuando sea 0 o menor corta", "Ingresando Ahorro"));
                }

                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                dataGridView1.DataSource = ban.RetornarPersonas();
                dataGridView2.DataSource = ban.RetornarAhorros(_p);
                dataGridView3.DataSource = ban.RetornarTotales(_p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                    throw new Exception("No hay personas para eliminar");

                Persona p = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                var _nombre = Interaction.InputBox("Ingrese Nombre", "Modificando Persona", p.Nombre);
                var _apellido = Interaction.InputBox("Ingrese Apellido", "Modificando Persona", p.Apellido);
                p.Nombre = _nombre;
                p.Apellido = _apellido;

                ban.ModificarPersona(p);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ban.RetornarPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                    throw new Exception("No hay personas para eliminar");

                Persona p = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                ban.EliminarPersona(p);

                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                dataGridView1.DataSource = ban.RetornarPersonas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var _dni = Convert.ToInt32(Interaction.InputBox("Ingrese DNI que desea buscar:", "Buscando por DNI"));
                var _perAux = ban.RetornaPersonaDNI(Convert.ToInt32(_dni));
                MessageBox.Show(_perAux.ToString(), "Busqueda de DNI");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                    throw new Exception("No hay personas para ordenar");

                if(button4.Text == "ASC")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ban.RetornarPersonasAsc();                  
                    button4.Text = "DESC";
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ban.RetornarPersonasDesc();
                    button4.Text = "ASC";
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
