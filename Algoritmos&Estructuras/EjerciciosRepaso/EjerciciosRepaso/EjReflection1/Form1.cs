using Microsoft.VisualBasic;
using System.Reflection;
using System.Windows.Forms;

namespace EjReflection1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        object persona;
        Type objetoType = typeof(Persona);
        PropertyInfo[] props;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                props = objetoType.GetProperties();
                foreach (PropertyInfo prop in props)
                {
                    listBox1.Items.Add($"{prop.Name}-{prop.PropertyType}");
                }
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
                var clas = listBox1.SelectedItem.ToString().Split('-')[0];
                if (clas != null)
                {
                    if (persona == null)
                    {
                        var asembly = objetoType.Assembly;
                        var fullName = objetoType.FullName;
                        persona = asembly.CreateInstance(fullName, false, BindingFlags.ExactBinding, null, new object[] { }, null, null);
                    }

                    var prop = objetoType.GetProperty(clas);
                    if (prop != null)
                    {
                        var valor = Interaction.InputBox($"Ingrese el valor para {prop.Name}");
                        if (valor != null)
                        {
                            prop.SetValue(persona, Convert.ChangeType(valor, prop.PropertyType));
                            listBox2.Items.Clear();
                            foreach (PropertyInfo p in props)
                            {
                                listBox2.Items.Add($"{p.Name} = {p.GetValue(persona)}");
                            }
                        }
                    }           
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
