using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;

namespace ListaDeAlumnos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            la = new ListadoAlumnos();
        }
        ListadoAlumnos la;
        string tipoAntiguedad = "a";
        //ver si se puede agregar datetimepicker tipo modals
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int legajo = int.Parse(Interaction.InputBox("Ingrese legajo del alumno", "Legajo"));
                if (legajo <= 0 || la.VerificarLegajo(new Alumno { Legajo = legajo })) throw new Exception("El legajo ya existe o es invalido.");
                string nombre = Interaction.InputBox("Ingrese nombre del alumno", "Nombre");
                if (nombre == "") throw new Exception("Debe ingresar un nombre");
                string apellido = Interaction.InputBox("Ingrese apellido del alumno", "Apellido");
                if (apellido == "") throw new Exception("Debe ingresar un apellido");
                DateTime fechaNacimiento = DateTime.Parse(Interaction.InputBox("Ingrese fecha de nacimiento del alumno", "Fecha de Nacimiento"));
                DateTime fechaIngreso = DateTime.Parse(Interaction.InputBox("Ingrese fecha de ingreso del alumno", "Fecha de Ingreso"));
                if (fechaIngreso < fechaNacimiento) throw new Exception("La fecha de ingreso no puede ser menor a la fecha de nacimiento");
                int cantMateriasAprobadas = int.Parse(Interaction.InputBox("Ingrese cantidad de materias aprobadas del alumno", "Cantidad de Materias Aprobadas"));
                if (cantMateriasAprobadas < 0 || cantMateriasAprobadas > 36) throw new Exception("Debe ingresar una cantidad de materias aprobadas valida");

                Alumno a = new Alumno(legajo, nombre, apellido, fechaNacimiento, fechaIngreso, cantMateriasAprobadas);
                la.AgregarAlumno(a);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = la.ListarAlumnos();
                dataGridView1.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    la.BorrarAlumno(dataGridView1.SelectedRows[0].DataBoundItem as Alumno);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = la.ListarAlumnos();
                    dataGridView1.Refresh();
                    dataGridView1_SelectionChanged(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    var alumno = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;
                    alumno.Nombre = Interaction.InputBox("Ingrese nombre del alumno", "Modificando Nombre", alumno.Nombre);
                    alumno.Apellido = Interaction.InputBox("Ingrese apellido del alumno", "Modificando Apellido", alumno.Apellido);
                    alumno.FechaNacimiento = DateTime.Parse(Interaction.InputBox("Ingrese fecha de nacimiento del alumno", "Modificando Fecha de Nacimiento", alumno.FechaNacimiento.ToString()));
                    alumno.FechaIngreso = DateTime.Parse(Interaction.InputBox("Ingrese fecha de ingreso del alumno", "Modificando Fecha de Ingreso", alumno.FechaIngreso.ToString()));
                    alumno.Activo = bool.Parse(Interaction.InputBox("Ingrese si el alumno esta activo", "Modificando Activo", alumno.Activo.ToString()));
                    alumno.CantMateriasAprobadas = int.Parse(Interaction.InputBox("Ingrese cantidad de materias aprobadas del alumno", "Modificando Cantidad de Materias Aprobadas", alumno.CantMateriasAprobadas.ToString()));

                    la.ModificarAlumno(alumno);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = la.ListarAlumnos();
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {

                    var alumno = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;
                    textBox1.Text = alumno.CalcularAntiguedad(tipoAntiguedad).ToString();
                    textBox2.Text = alumno.GetMateriasNoAprobadas().ToString();
                    textBox3.Text = alumno.GetEdadDeIngreso().ToString();
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            catch (Exception ex) { }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tipoAntiguedad = "a";
            }
            dataGridView1_SelectionChanged(null, null);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tipoAntiguedad = "m";
            }
            dataGridView1_SelectionChanged(null, null);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                tipoAntiguedad = "d";
            }
            dataGridView1_SelectionChanged(null, null);
        }
    }
}
