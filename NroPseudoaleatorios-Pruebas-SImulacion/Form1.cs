using System.Windows.Forms;

namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            int digitosDeseados = int.Parse(digitosDeseadosTextBox.Text);
            int semilla = int.Parse(semillaTextBox.Text);
            double[] resultados = controller.calcularParteCentralCuadrado(digitosDeseados, semilla);
            resultRichTextBox.Text = "";

            for (int i = 0; i < resultados.Length; i++)
            {
                resultRichTextBox.AppendText(resultados[i].ToString() + "\n");
            }
        }
    }
}