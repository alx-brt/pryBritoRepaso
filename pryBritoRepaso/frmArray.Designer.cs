namespace pryBritoRepaso
{
    partial class frmArray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGrupo = new Label();
            cboGrupo = new ComboBox();
            lstResultado = new ListBox();
            btnCargarNuevos = new Button();
            cboAgregarDato = new ComboBox();
            label1 = new Label();
            txtDato = new TextBox();
            label2 = new Label();
            btnGrabar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(24, 15);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 0;
            lblGrupo.Text = "Grupo";
            // 
            // cboGrupo
            // 
            cboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Location = new Point(70, 12);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(102, 23);
            cboGrupo.TabIndex = 1;
            cboGrupo.SelectedIndexChanged += cboGrupo_SelectedIndexChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(12, 50);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(179, 109);
            lstResultado.TabIndex = 2;
            // 
            // btnCargarNuevos
            // 
            btnCargarNuevos.Location = new Point(12, 165);
            btnCargarNuevos.Name = "btnCargarNuevos";
            btnCargarNuevos.Size = new Size(179, 23);
            btnCargarNuevos.TabIndex = 3;
            btnCargarNuevos.Text = "Sobreescribir array";
            btnCargarNuevos.UseVisualStyleBackColor = true;
            btnCargarNuevos.Click += btnCargarNuevos_Click;
            // 
            // cboAgregarDato
            // 
            cboAgregarDato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgregarDato.FormattingEnabled = true;
            cboAgregarDato.Location = new Point(68, 238);
            cboAgregarDato.Name = "cboAgregarDato";
            cboAgregarDato.Size = new Size(102, 23);
            cboAgregarDato.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 241);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Grupo";
            // 
            // txtDato
            // 
            txtDato.Location = new Point(70, 267);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(100, 23);
            txtDato.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 270);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 7;
            label2.Text = "Dato";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(97, 296);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(38, 326);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(12, 15);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "-";
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 345);
            Controls.Add(lblMensaje);
            Controls.Add(btnGrabar);
            Controls.Add(label2);
            Controls.Add(txtDato);
            Controls.Add(cboAgregarDato);
            Controls.Add(label1);
            Controls.Add(btnCargarNuevos);
            Controls.Add(lstResultado);
            Controls.Add(cboGrupo);
            Controls.Add(lblGrupo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmArray";
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupo;
        private ComboBox cboGrupo;
        private ListBox lstResultado;
        private Button btnCargarNuevos;
        private ComboBox cboAgregarDato;
        private Label label1;
        private TextBox txtDato;
        private Label label2;
        private Button btnGrabar;
        private Label lblMensaje;
    }
}