using Microsoft.VisualBasic;
using System.Reflection;

namespace EjReflection3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        object calculadora;
        MethodInfo[] metodos;
        Type objetType = typeof(Calculadora);

        private void Form1_Load(object sender, EventArgs e)
        {
            var assembly = objetType.Assembly;
            calculadora = assembly.CreateInstance(objetType.FullName, false, BindingFlags.ExactBinding, null, new object[] { }, null, null);

            metodos = objetType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
            foreach (MethodInfo mi in metodos)
            {
                comboBox1.Items.Add(mi.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var clas = comboBox1.SelectedItem.ToString();

                int n1 = int.Parse(Interaction.InputBox("Numero 1: "));
                int n2 = int.Parse(Interaction.InputBox("Numero 2: "));

                //var assembly = objetType.Assembly;
                var metodo = objetType.GetMethod(clas);
                var resultado = metodo.Invoke(calculadora, new object[] { n1,n2 });

                listBox1.Items.Add($"Resultado de {clas}, {n1} y {n2} => {resultado}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
