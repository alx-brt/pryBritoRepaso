using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryBritoRepaso
{
    public partial class frmArray : Form
    {
        public frmArray()
        {
            InitializeComponent();
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboGrupo.Text)
            {
                case "Grupo A":
                    ltsResultado.Items.Clear();
                    ltsResultado.Items.Add("Juan");
                    ltsResultado.Items.Add("Pedro");
                    ltsResultado.Items.Add("Maria");
                    break;
                case "Grupo B":
                    ltsResultado.Items.Clear();
                    ltsResultado.Items.Add("B-Juan");
                    ltsResultado.Items.Add("B-Pedro");
                    ltsResultado.Items.Add("B-Maria");
                    break;
                case "Grupo C":
                    ltsResultado.Items.Clear();
                    ltsResultado.Items.Add("C-Juan");
                    ltsResultado.Items.Add("C-Pedro");
                    ltsResultado.Items.Add("C-Maria");
                    break;
            }
        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            cboGrupo.Items.Add("Grupo A");
            cboGrupo.Items.Add("Grupo B");
            cboGrupo.Items.Add("Grupo C");
        }
    }
}
