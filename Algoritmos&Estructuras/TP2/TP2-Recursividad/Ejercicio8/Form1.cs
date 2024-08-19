using Microsoft.VisualBasic;
using System.Numerics;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Escribir una función recursiva Mayúsculas(unString) -> otro string
        //igual pero en mayusculas.Tratar el strings como un vector de
        //caracteres.Ejemplo Mayúscula(“hola”) -> Hola.
        public string Mayusculas(string unString)
        {
            if (unString.Length == 0)
            {
                return "";
            }
            else
            {
                return Mayusculas(unString.Substring(0, unString.Length - 1)) + char.ToUpper(unString[unString.Length - 1]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string unString = Interaction.InputBox("Ingrese un string");
            string resultado = Mayusculas(unString);
            MessageBox.Show(resultado);

        }
    }
}
