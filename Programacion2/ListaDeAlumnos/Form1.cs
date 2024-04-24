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
                //error edad cuando se agrega a la
                la.AgregarAlumno(a);
                var listaParaMostrar = la.alumnos.Select(alumno => new
                {
                    Legajo = alumno.Legajo,
                    Nombre = alumno.Nombre,
                    Apellido = alumno.Apellido,
                    Edad = alumno.Edad,
                    FechaNacimiento = alumno.FechaNacimiento,
                    FechaIngreso = alumno.FechaIngreso,
                    Activo = alumno.Activo,
                    CantMateriasAprobadas = alumno.CantMateriasAprobadas
                }).ToList();

                dataGridView1.DataSource = listaParaMostrar;
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
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
