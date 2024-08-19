using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<(T1, T2)> Aparear<T1, T2>(List<T1> unaLista, List<T2> otra)
        {
            if (unaLista.Count == 0 || otra.Count == 0)
            {
                return new List<(T1, T2)>();
            }
            else
            {
                var primerPar = (unaLista[0], otra[0]);
                var restoPares = Aparear(unaLista.GetRange(1, unaLista.Count - 1), otra.GetRange(1, otra.Count - 1));
                restoPares.Insert(0, primerPar);

                return restoPares;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista1 = new List<int> { 1, 2, 3 };
            var lista2 = new List<char> { 'a', 'b', 'c' };

            var resultado = Aparear(lista1, lista2);
            var resultadoString = "";
            for (int i = 0; i < resultado.Count; i++)
            {
                resultadoString += $"({resultado[i].Item1}, {resultado[i].Item2})";
                if (i < resultado.Count - 1)
                {
                    resultadoString += ", ";
                }
            }
            MessageBox.Show($"[ {resultadoString} ]");

        }
    }
}
