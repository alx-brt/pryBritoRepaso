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

        string[] vectorGrupoA = new string[4];
        string[] vectorGrupoB = new string[3];
        string[] vectorGrupoC = new string[3];


        public frmArray()
        {
            InitializeComponent();
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            switch (cboGrupo.Text)
            {
                case "Grupo A":
                    //ltsResultado.Items.Clear();
                    //ltsResultado.Items.Add("CPU");
                    //ltsResultado.Items.Add("Micro");
                    //ltsResultado.Items.Add("Placa");
                    //ltsResultado.Items.Add("Memoria");

                    for (int indice = 0; indice < vectorGrupoA.Length; indice++)
                    {
                        lstResultado.Items.Add(vectorGrupoA[indice]);
                    }

                    break;

                case "Grupo B":
                    lstResultado.Items.Clear();
                    //ltsResultado.Items.Add("Visual");
                    //ltsResultado.Items.Add("C#");
                    //ltsResultado.Items.Add("Desktop");

                    for (int indice = 0; indice < vectorGrupoB.Length; indice++)
                    {
                        lstResultado.Items.Add(vectorGrupoB[indice]);
                    }

                    break;

                case "Grupo C":
                    lstResultado.Items.Clear();
                    //ltsResultado.Items.Add("Server");
                    //ltsResultado.Items.Add("AWS");
                    //ltsResultado.Items.Add("Cloud");

                    for (int indice = 0; indice < vectorGrupoC.Length; indice++)
                    {
                        lstResultado.Items.Add(vectorGrupoC[indice]);
                    }

                    break;
            }
        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            this.Height = 230;

            cboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;

            cboGrupo.Items.Add("Grupo A");
            cboGrupo.Items.Add("Grupo B");
            cboGrupo.Items.Add("Grupo C");

            cboAgregarDato.Items.Add("Grupo A");
            cboAgregarDato.Items.Add("Grupo B");
            cboAgregarDato.Items.Add("Grupo C");


            vectorGrupoA[0] = "CPU";
            vectorGrupoA[1] = "Micro";
            vectorGrupoA[2] = "Placa";
            vectorGrupoA[3] = "Memoria";

            vectorGrupoB[0] = "Visual";
            vectorGrupoB[1] = "C#";
            vectorGrupoB[2] = "Desktop";

            vectorGrupoC[0] = "Server";
            vectorGrupoC[1] = "AWS";
            vectorGrupoC[2] = "Cloud";

        }

        private void btnCargarNuevos_Click(object sender, EventArgs e)
        {
            this.Height = 400;
        }


        //declaracion global        
        int indiceGrabar = 0;

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (cboAgregarDato.Text)
            {
                case "Grupo A":
                    if (indiceGrabar >= vectorGrupoA.Length)
                    {
                        MessageBox.Show("No quedan más lugares");                        
                    }
                    else
                    {
                        vectorGrupoA[indiceGrabar] = txtDato.Text;
                        indiceGrabar++;
                        lblMensaje.Text = "Almacenado..." + txtDato.Text;
                        txtDato.Text = "";
                    }
                    break;


                case "Grupo B":
                    if (indiceGrabar >= vectorGrupoB.Length)
                    {
                        MessageBox.Show("No quedan más lugares");
                    }
                    else
                    {
                        vectorGrupoB[indiceGrabar] = txtDato.Text;
                        indiceGrabar++;
                        lblMensaje.Text = "Almacenado..." + txtDato.Text;
                        txtDato.Text = "";
                    }
                    break;

                case "Grupo C":
                    if (indiceGrabar >= vectorGrupoC.Length)
                    {
                        MessageBox.Show("No quedan más lugares");
                    }
                    else
                    {
                        vectorGrupoC[indiceGrabar] = txtDato.Text;
                        indiceGrabar++;
                        lblMensaje.Text = "Almacenado..." + txtDato.Text;
                        txtDato.Text = "";
                    }
                    break;


                default:
                    break;

            }
        }
    }
}
