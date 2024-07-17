using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;

namespace Parcial2Ejemplo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter ad_p;
        SqlCommandBuilder cb;
        DataSet ds;
        DataTable dt_p;
        string strconn = "Data Source=DESKTOP-Q88V9OO\\SQLEXPRESS;Initial Catalog=Parcial2Ejemplo;Integrated Security=True;Trust Server Certificate=True";
        Veterinario vet;

        private void buildCommands(SqlDataAdapter pAdapter)
        {
            cb = new SqlCommandBuilder(pAdapter);
            pAdapter.InsertCommand = cb.GetInsertCommand();
            pAdapter.UpdateCommand = cb.GetUpdateCommand();
            pAdapter.DeleteCommand = cb.GetDeleteCommand();
        }
        private void fillDataTables()
        {
            dt_p.Clear();

            ad_p.Fill(dt_p);

            dt_p.PrimaryKey = [dt_p.Columns["Legajo"]];
        }
        private void loadFromDatabase()
        {
            foreach (DataRow perrRow in dt_p.Rows)
            {
                if (perrRow["SubRaza"] != DBNull.Value)
                {
                    PerroRaza _perroRaza = new PerroRaza(Convert.ToInt32(perrRow["Legajo"]),
                                                            Convert.ToString(perrRow["Nombre"]),
                                                            Convert.ToInt32(perrRow["Edad"]),
                                                            Convert.ToString(perrRow["Raza"]),
                                                            Convert.ToString(perrRow["SubRaza"]));
                    vet.AgregarRaza(_perroRaza);
                }
                else
                {
                    PerroMestizo _perroMestizo = new PerroMestizo(Convert.ToInt32(perrRow["Legajo"]),
                                                              Convert.ToString(perrRow["Nombre"]),
                                                              Convert.ToInt32(perrRow["Edad"]),
                                                              Convert.ToInt32(perrRow["AnioAdopcion"]));
                    vet.AgregarMestizo(_perroMestizo);
                }
            }

        }

        public Form1()
        {
            InitializeComponent();

            con = new SqlConnection(strconn);
            ad_p = new SqlDataAdapter("select * from Perros", con);
            cb = new SqlCommandBuilder(ad_p);
            buildCommands(ad_p);

            ds = new DataSet("Veterinario");
            dt_p = new DataTable("Perros");
            ds.Tables.Add(dt_p);

            vet = new Veterinario();
            fillDataTables();
            loadFromDatabase();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var _legajo = Interaction.InputBox("Ingrese legajo");
                if (!Information.IsNumeric(_legajo))
                    throw new Exception("Legajo debe ser numerico");

                var _Nombre = Interaction.InputBox("Ingrese Nombre");

                var _edad = Interaction.InputBox("Ingrese Edad");
                if (!Information.IsNumeric(_edad))
                    throw new Exception("edad debe ser numerico");

                if (radioButton1.Checked)
                {
                    var _anio = Interaction.InputBox("Ingrese Anio de Adopcion");
                    if (!Information.IsNumeric(_anio))
                        throw new Exception("anio debe ser numerico");

                    PerroMestizo _p = new PerroMestizo(Int32.Parse(_legajo), _Nombre, Int32.Parse(_edad), Int32.Parse(_anio));
                    vet.AgregarMestizo(_p);

                    dataGridView1.DataSource = null;
                    dataGridView2.DataSource = null;
                    dataGridView3.DataSource = null;
                    dataGridView1.DataSource = vet.RetornarPerros();
                    dataGridView2.DataSource = vet.RetornarRaza();
                    dataGridView3.DataSource = vet.RetornarMestizos();

                    DataRow _pRow = dt_p.NewRow();
                    _pRow["Legajo"] = _p.Legajo;
                    _pRow["Nombre"] = _p.Nombre;
                    _pRow["Edad"] = _p.Edad;
                    _pRow["AnioAdopcion"] = _p.AnioAdopcion;

                    dt_p.Rows.Add(_pRow);
                    ad_p.Update(dt_p);
                }
                else
                {
                    var _raza = Interaction.InputBox("Ingrese Raza");
                    var _subraza = Interaction.InputBox("Ingrese SubRaza");

                    PerroRaza _p = new PerroRaza(Int32.Parse(_legajo), _Nombre, Int32.Parse(_edad), _raza, _subraza);
                    vet.AgregarRaza(_p);

                    dataGridView1.DataSource = null;
                    dataGridView2.DataSource = null;
                    dataGridView3.DataSource = null;
                    dataGridView1.DataSource = vet.RetornarPerros();
                    dataGridView2.DataSource = vet.RetornarRaza();
                    dataGridView3.DataSource = vet.RetornarMestizos();

                    DataRow _pRow = dt_p.NewRow();
                    _pRow["Legajo"] = _p.Legajo;
                    _pRow["Nombre"] = _p.Nombre;
                    _pRow["Edad"] = _p.Edad;
                    _pRow["Raza"] = _p.Raza;
                    _pRow["SubRaza"] = _p.SubRaza;

                    dt_p.Rows.Add(_pRow);
                    ad_p.Update(dt_p);
                }

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
                    throw new Exception("No hay perros para modificar");

                Perro _perr;
                int _legajo;
                if (dataGridView1.SelectedRows[0].Cells[5].Value != "---")
                {
                    _legajo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    _perr = vet.RetornarRaza().Find(x => x.Legajo == _legajo);
                }
                else
                {
                    _legajo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    _perr = vet.RetornarMestizos().Find(x => x.Legajo == _legajo);
                }

                var _Nombre = Interaction.InputBox("Ingrese Nombre", _perr.Nombre);

                var _edad = Interaction.InputBox("Ingrese Edad", _perr.Edad.ToString());
                if (!Information.IsNumeric(_edad))
                {
                    throw new Exception("edad debe ser numerico");
                }

                var _raza = string.Empty;
                var _subraza = string.Empty;
                var _anio = string.Empty;
                if (_perr is PerroMestizo)
                {
                    _anio = Interaction.InputBox("Ingrese Anio de Adopcion");
                    if (!Information.IsNumeric(_anio))
                    {
                        throw new Exception("anio debe ser numerico");
                    }
                    PerroMestizo _p = new PerroMestizo(_legajo, _Nombre, Int32.Parse(_edad), Int32.Parse(_anio));
                    vet.ModificarMestizo(_p);
                }
                else
                {
                    _raza = Interaction.InputBox("Ingrese Raza");
                    _subraza = Interaction.InputBox("Ingrese SubRaza");
                    PerroRaza _p = new PerroRaza(_legajo, _Nombre, Int32.Parse(_edad), _raza, _subraza);
                    vet.ModificarRaza(_p);
                }

                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                dataGridView1.DataSource = vet.RetornarPerros();
                dataGridView2.DataSource = vet.RetornarRaza();
                dataGridView3.DataSource = vet.RetornarMestizos();

                DataRow _perroSeleccionadoRow = dt_p.Rows.Find(_legajo);
                _perroSeleccionadoRow["Nombre"] = _Nombre;
                _perroSeleccionadoRow["Edad"] = _edad;
                if (_perr is PerroMestizo)
                {
                    _perroSeleccionadoRow["AnioAdopcion"] = _anio;
                }
                else
                {
                    _perroSeleccionadoRow["Raza"] = _raza;
                    _perroSeleccionadoRow["SubRaza"] = _subraza;
                }
                ad_p.Update(dt_p);

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
                    throw new Exception("No hay perros para eliminar");

                int _legajo;
                if (dataGridView1.SelectedRows[0].Cells[5].Value != "---")
                {
                    _legajo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    PerroRaza _perr = vet.RetornarRaza().Find(x => x.Legajo == _legajo);
                    vet.BorrarRaza(_perr);
                }
                else
                {
                    _legajo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    PerroMestizo _perr = vet.RetornarMestizos().Find(x => x.Legajo == _legajo);
                    vet.BorrarMestizo(_perr);
                }

                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                dataGridView1.DataSource = vet.RetornarPerros();
                dataGridView2.DataSource = vet.RetornarRaza();
                dataGridView3.DataSource = vet.RetornarMestizos();

                DataRow _perroSeleccionadoRow = dt_p.Rows.Find(_legajo);
                _perroSeleccionadoRow.Delete();
                ad_p.Update(dt_p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                throw new Exception("No hay perros para ordernar");

            if (button4.Text == "Asc")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = vet.RetornarAscendente();
                button4.Text = "Desc";
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = vet.RetornarDescendente();
                button4.Text = "Asc";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var legajo = Interaction.InputBox("Ingrese el legajo que desea buscar: ", "Buscando por Legajo");
                if (!Information.IsNumeric(legajo)) throw new Exception("Debe ser numerico..");

                var perroaux = vet.RetornaPerroLegajo(Convert.ToInt32(legajo));
                MessageBox.Show(perroaux.ToString(), "Busqueda de legajo");
            }
            catch (Exception) { }
        }
    }
}
