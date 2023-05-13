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
    public partial class SeleccionarMetodo : Form
    {
        public SeleccionarMetodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodoCuadrado ventana = new MetodoCuadrado();
            ventana.ShowDialog();
        }

        private void botonMetodoLehmer_Click(object sender, EventArgs e)
        {
            MetodoLehmer ventana = new MetodoLehmer();
            ventana.ShowDialog();
        }

        private void botonMetodoCongruencialMixto_Click(object sender, EventArgs e)
        {
            MetodoCongruencialMixto ventana = new MetodoCongruencialMixto();
            ventana.ShowDialog();
        }

        private void botonMetodoCongruencialAditivo_Click(object sender, EventArgs e)
        {
            MetodoCongruencialAditivo ventana = new MetodoCongruencialAditivo();
            ventana.ShowDialog();
        }

        private void botonMetodoCongruencialMultiplicativo_Click(object sender, EventArgs e)
        {
            MetodoCongruencialMultiplicativo ventana = new MetodoCongruencialMultiplicativo();
            ventana.ShowDialog();
        }
    }
}
