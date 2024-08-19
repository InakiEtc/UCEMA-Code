using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Policy;
using Microsoft.VisualBasic;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Escribir una función recursiva SumaHasta(n, desde) -> numero.
        //Debe retornar la suma de los números desde el valor  “desde” hasta los N consecutivos a él.
        //Por ejemplo. SumaHasta(5,10) = 10 +11 +12 + 13 + 14  => 60.
        
        public int SumaHasta(int n, int desde)
        {
            if(n == 1)
            {
                return desde;
            }
            else
            {
                return desde + SumaHasta(n - 1, desde + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Interaction.InputBox("Ingrese el n: "));
            int desde = Convert.ToInt32(Interaction.InputBox("Ingrese el desde: "));
            int suma = SumaHasta(n, desde);
            MessageBox.Show("Suma hasta n: " + suma);

        }
    }
}
