using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryBritoRepaso
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void Calculo_Load(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float monto;
            monto = float.Parse(txtMonto.Text);
            float iva;
            iva = float.Parse(cboIVA.SelectedItem.ToString().Replace("%", "")) / 100;
            float resultado;
            resultado = monto * iva;
            lblResultado.Text = "Resultado: $" + resultado;
        }
    }
}
