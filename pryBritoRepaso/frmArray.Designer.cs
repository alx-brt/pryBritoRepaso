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
            ltsResultado = new ListBox();
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
            // ltsResultado
            // 
            ltsResultado.FormattingEnabled = true;
            ltsResultado.Location = new Point(12, 50);
            ltsResultado.Name = "ltsResultado";
            ltsResultado.Size = new Size(179, 109);
            ltsResultado.TabIndex = 2;
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 171);
            Controls.Add(ltsResultado);
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
        private ListBox ltsResultado;
    }
}