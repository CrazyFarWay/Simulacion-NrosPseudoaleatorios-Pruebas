using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    public partial class MetodoCongruencialAditivo : Form
    {
        GeneradorNumeros generadorNumeros = new GeneradorNumeros();

        public MetodoCongruencialAditivo()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            int digitosDeseados = int.Parse(digitosDeseadosTextBox.Text);

            // Obtener semillas del RichTextBox
            string contenidoRichTextBox = semillasRichTextBox.Text;
            string[] lineas = contenidoRichTextBox.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<Int64> arrayEnteros = new List<Int64>();

            for (int i = 0; i < lineas.Length; i++)
            {
                Int64 numero;
                if (Int64.TryParse(lineas[i], out numero))
                {
                    arrayEnteros.Add(numero);
                }
            }

            Int64[] semillas = arrayEnteros.ToArray();
            int modulo = int.Parse(moduloTextBox.Text);
            double[] resultados = generadorNumeros.calcularCongruencialAditivo(digitosDeseados, semillas, modulo);
            resultRichTextBox.Text = "";

            for (int i = 0; i < resultados.Length; i++)
            {
                resultRichTextBox.AppendText(resultados[i].ToString() + "\n");
            }
        }

        private void MetodoCongruencialAditivo_Load(object sender, EventArgs e)
        {

        }
    }
}
