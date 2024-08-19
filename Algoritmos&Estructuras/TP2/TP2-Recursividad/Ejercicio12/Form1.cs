using Microsoft.VisualBasic;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int f(int x)
        {
            if (x > 100) 
            { 
                return (x - 10); 
            }
            else 
            { 
                return (f(f(x + 11))); 
            }
        }

        // En todos los casos que x<=100, la funcion f(x) devolvera 91.
        // En el caso que x>100, la funcion f(x) devolvera x-10. Ej: x=120 -> f(120) = 110
        // Es la función recursiva McCarthy 91

        // Si x = 95:
        // f(95) llama a f(f(106)).
        // f(106) devuelve 106 - 10 = 96.
        // Luego, f(95) se convierte en f(96), que continúa llamando hasta alcanzar un resultado, pero eventualmente, la cadena de recursiones llega a 91.
        // Si x = 101:
        // Como x > 100, directamente retorna 101 - 10 = 91.

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Interaction.InputBox("ingrese un numero"));
            int resultado = f(x);
            MessageBox.Show("El resultado es: " + resultado);

        }
    }
}
