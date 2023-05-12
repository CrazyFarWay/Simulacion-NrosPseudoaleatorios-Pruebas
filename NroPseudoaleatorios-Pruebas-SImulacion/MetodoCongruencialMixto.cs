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
    public partial class MetodoCongruencialMixto : Form
    {
        GeneradorNumeros generadorNumeros = new GeneradorNumeros();

        public MetodoCongruencialMixto()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            int digitosDeseados = int.Parse(digitosDeseadosTextBox.Text);
            int semilla = int.Parse(semillaTextBox.Text);
            int constanteMultiplicativa = int.Parse(constanteMultiplicativaTextBox.Text);
            int constanteAditiva = int.Parse(constanteAditivaTextBox.Text);
            int modulo = int.Parse(moduloTextBox.Text);
            double[] resultados = generadorNumeros.calcularCongruencialMixto(digitosDeseados, semilla, constanteMultiplicativa, constanteAditiva, modulo);
            resultRichTextBox.Text = "";

            for (int i = 0; i < resultados.Length; i++)
            {
                resultRichTextBox.AppendText(resultados[i].ToString() + "\n");
            }
        }
    }
}
