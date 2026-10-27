namespace pryBritoRepaso
{
    partial class Calculo
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
            lblIVA = new Label();
            btnCalcular = new Button();
            txtMonto = new TextBox();
            lblMonto = new Label();
            cboIVA = new ComboBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(40, 59);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(24, 15);
            lblIVA.TabIndex = 8;
            lblIVA.Text = "IVA";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(124, 96);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(70, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(83, 21);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(111, 23);
            txtMonto.TabIndex = 6;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(21, 24);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "Monto";
            lblMonto.Click += lblCodigo_Click;
            // 
            // cboIVA
            // 
            cboIVA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIVA.FormattingEnabled = true;
            cboIVA.Items.AddRange(new object[] { "10%", "21%" });
            cboIVA.Location = new Point(83, 56);
            cboIVA.Name = "cboIVA";
            cboIVA.Size = new Size(111, 23);
            cboIVA.TabIndex = 9;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(65, 138);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado: ";
            lblResultado.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Calculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 173);
            Controls.Add(lblResultado);
            Controls.Add(cboIVA);
            Controls.Add(lblIVA);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Calculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo";
            Load += Calculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIVA;
        private Button btnCalcular;
        private TextBox txtMonto;
        private Label lblMonto;
        private ComboBox cboIVA;
        private Label lblResultado;
    }
}