using Microsoft.VisualBasic;

namespace RegistroAutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            r = new Registro();
        }
        Registro r;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.MultiSelect = false;
        }
        //Agrega una persona
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(Interaction.InputBox("Ingrese DNI de la persona", "DNI"));
                if (dni <= 0 || r.VerificarDNI(new Persona { DNI = dni })) throw new Exception("El DNI ya existe o es invalido.");
                string nombre = Interaction.InputBox("Ingrese nombre de la persona", "Nombre");
                if (nombre == "") throw new Exception("Debe ingresar un nombre");
                string apellido = Interaction.InputBox("Ingrese apellido de la persona", "Apellido");
                if (apellido == "") throw new Exception("Debe ingresar un apellido");

                Persona p = new Persona(dni, nombre, apellido);
                r.AgregarPersona(p);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = r.ListarPersonas();                
                dataGridView1.Refresh();                
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = r.ListarAutosconDueno();
                dataGridView4.Refresh();
                dataGridView1_SelectionChanged(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Modifica una persona
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    var persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                    persona.Nombre = Interaction.InputBox("Ingrese nombre de la persona", "Modificando Nombre", persona.Nombre);
                    persona.Apellido = Interaction.InputBox("Ingrese apellido de la persona", "Modificando Apellido", persona.Apellido);

                    r.ModificarPersona(persona);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = r.ListarPersonas();
                    dataGridView1.Refresh();
                    dataGridView1_SelectionChanged(null, null);
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = r.ListarAutosconDueno();
                    dataGridView4.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Borra una persona
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    r.BorrarPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = r.ListarPersonas();
                    dataGridView1.Refresh();
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = r.ListarAutos();
                    dataGridView2.Columns[dataGridView2.Columns.Count - 1].Visible = false;
                    dataGridView2.Refresh();
                    dataGridView1_SelectionChanged(null, null);
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = r.ListarAutosconDueno();
                    dataGridView4.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Agrega un auto
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = Interaction.InputBox("Ingrese patente del auto", "Patente");
                if (patente == "" || r.VerificarPatente(new Auto { Patente = patente })) throw new Exception("Debe ingresar una patente");
                string marca = Interaction.InputBox("Ingrese marca del auto", "Marca");
                if (marca == "") throw new Exception("Debe ingresar una marca");
                string modelo = Interaction.InputBox("Ingrese modelo del auto", "Modelo");
                if (modelo == "") throw new Exception("Debe ingresar un modelo");
                string color = Interaction.InputBox("Ingrese color del auto", "Color");
                if (color == "") throw new Exception("Debe ingresar un color");
                int anio = int.Parse(Interaction.InputBox("Ingrese año del auto", "Año"));
                if (anio <= 0) throw new Exception("Debe ingresar un año valido");
                float precio = float.Parse(Interaction.InputBox("Ingrese precio del auto", "Precio"));
                if (precio <= 0) throw new Exception("Debe ingresar un precio valido");

                Auto a = new Auto(patente, marca, modelo, color, anio, precio);
                r.AgregarAuto(a);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = r.ListarAutos();
                dataGridView2.Columns[dataGridView2.Columns.Count - 1].Visible = false;
                dataGridView2.Refresh();
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = r.ListarAutosconDueno();
                dataGridView4.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Modifica un auto
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    var auto = dataGridView2.SelectedRows[0].DataBoundItem as Auto;
                    auto.Marca = Interaction.InputBox("Ingrese marca del auto", "Modificando Marca", auto.Marca);
                    auto.Modelo = Interaction.InputBox("Ingrese modelo del auto", "Modificando Modelo", auto.Modelo);
                    auto.Color = Interaction.InputBox("Ingrese color del auto", "Modificando Color", auto.Color);
                    auto.Anio = int.Parse(Interaction.InputBox("Ingrese año del auto", "Modificando Año", auto.Anio.ToString()));
                    auto.Precio = float.Parse(Interaction.InputBox("Ingrese precio del auto", "Modificando Precio", auto.Precio.ToString()));

                    r.ModificarAuto(auto);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = r.ListarAutos();
                    dataGridView2.Columns[dataGridView2.Columns.Count - 1].Visible = false;
                    dataGridView2.Refresh();
                    dataGridView1_SelectionChanged(null, null);
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = r.ListarAutosconDueno();
                    dataGridView4.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Borra un auto
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    r.BorrarAuto(dataGridView2.SelectedRows[0].DataBoundItem as Auto);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = r.ListarAutos();
                    dataGridView2.Columns[dataGridView2.Columns.Count - 1].Visible = false;
                    dataGridView2.Refresh();
                    dataGridView1_SelectionChanged(null, null);
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = r.ListarAutosconDueno();
                    dataGridView4.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Asigna un auto a una persona
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0 && dataGridView2.Rows.Count > 0)
                {
                    var persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                    var auto = dataGridView2.SelectedRows[0].DataBoundItem as Auto;
                    if (auto.Dueno != null) throw new Exception("El auto ya tiene dueño");
                    
                    auto.Dueno = persona; 
                    persona.Autos.Add(auto);
                    r.ModificarAuto(auto);
                    r.ModificarPersona(persona);

                    dataGridView1_SelectionChanged(null, null);
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = r.ListarAutosconDueno();
                    dataGridView4.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Muestra los autos con dueño
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    var persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = r.ListarAutosxPersona(persona);
                    dataGridView3.Refresh();
                }
                else
                {
                    dataGridView3.DataSource = null;
                    dataGridView3.Refresh();
                }
            }
            catch (Exception ex) { }
        }
    }
}
