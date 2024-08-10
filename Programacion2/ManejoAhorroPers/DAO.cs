using System.Data;
using Microsoft.Data.SqlClient;

namespace ManejoAhorroPers
{
    internal class DAO
    {
        SqlConnection con;
        SqlDataAdapter daPersona, daAhorro;
        SqlCommandBuilder cb;

        DataSet ds;
        DataTable dtPersona, dtAhorro;

        public DAO()
        {
            con = new SqlConnection("Data Source=DESKTOP-Q88V9OO\\SQLEXPRESS;Initial Catalog=UCEMA;Integrated Security=True;Trust Server Certificate=True");
            daPersona = new SqlDataAdapter("select * from Personas", con);
            daAhorro = new SqlDataAdapter("select * from Ahorros", con);

            cb = new SqlCommandBuilder(daPersona);
            daPersona.InsertCommand = cb.GetInsertCommand();
            daPersona.UpdateCommand = cb.GetUpdateCommand();
            daPersona.DeleteCommand = cb.GetDeleteCommand();

            cb = new SqlCommandBuilder(daAhorro);
            daAhorro.InsertCommand = cb.GetInsertCommand();
            daAhorro.UpdateCommand = cb.GetUpdateCommand();
            daAhorro.DeleteCommand = cb.GetDeleteCommand();

            ds = new DataSet("Banco");
            dtPersona = new DataTable("Personas");
            dtAhorro = new DataTable("Ahorros");
            ds.Tables.Add(dtPersona);
            ds.Tables.Add(dtAhorro);            
            fillDataTables();
        }
        public void fillDataTables()
        {
            dtPersona.Clear();
            dtAhorro.Clear();

            daPersona.Fill(dtPersona);
            daAhorro.Fill(dtAhorro);

            dtPersona.PrimaryKey = [dtPersona.Columns["DNI"]];
            dtAhorro.PrimaryKey = [dtAhorro.Columns["Fecha"]];
        }

        public void CargarDatos(List<Persona> personas)
        {
            foreach (DataRow PersonaRow in dtPersona.Rows)
            {
                Persona _persona = new Persona(Convert.ToInt32(PersonaRow["DNI"]),
                                               Convert.ToString(PersonaRow["Nombre"]),
                                               Convert.ToString(PersonaRow["Apellido"]));
                personas.Add(_persona);
              
            }
            foreach (DataRow AhorroRow in dtAhorro.Rows)
            {
                Ahorro _ahorro = new Ahorro(Convert.ToDateTime(AhorroRow["Fecha"]),
                                            Convert.ToDecimal(AhorroRow["Monto"]),
                                            Convert.ToInt32(AhorroRow["PersonaDNI"]));
                Persona _pa = personas.Find(x => x.DNI == _ahorro.PersonaDNI);
                if (_pa != null)
                    _pa.AgregarAhorro(_ahorro);
            }
        }

        public void GuardarPersonaDB(Persona p)
        {
            dtPersona.Clear();

            DataRow dr = dtPersona.NewRow();
            dr["DNI"] = p.DNI;
            dr["Nombre"] = p.Nombre;
            dr["Apellido"] = p.Apellido;
            dtPersona.Rows.Add(dr);

            daPersona.Update(dtPersona);
        }        
        public void GuardarAhorroDB(Ahorro a) 
        {
            dtAhorro.Clear();

            DataRow da = dtAhorro.NewRow();
            da["Fecha"] = a.Fecha;
            da["Monto"] = a.Monto;
            da["PersonaDNI"] = a.PersonaDNI;
            dtAhorro.Rows.Add(da);

            daAhorro.Update(dtAhorro);
        }
        public void ActualizarPersonaDB(Persona p)
        {
            DataRow dr = dtPersona.Rows.Find(p.DNI);
            dr["Nombre"] = p.Nombre;
            dr["Apellido"] = p.Apellido;

            daPersona.Update(dtPersona);
        }
        public void EliminarPersonaDB(Persona p)
        {
            DataRow dr = dtPersona.Rows.Find(p.DNI);
            dr.Delete();

            daPersona.Update(dtPersona);
        }
        public void EliminarAhorrosDB(Persona p)
        {
            foreach (DataRow dr in dtAhorro.Rows)
            {
                if (Convert.ToInt32(dr["PersonaDNI"]) == p.DNI)
                    dr.Delete();
            }
            daAhorro.Update(dtAhorro);
        }
    }
}
