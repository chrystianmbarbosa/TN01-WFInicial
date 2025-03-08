namespace WFInicial
{
    partial class FormEx11
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
            lblSalarioBruto = new Label();
            txtSalarioBruto = new TextBox();
            btnCalcular = new Button();
            txtResultado = new RichTextBox();
            SuspendLayout();
            // 
            // lblSalarioBruto
            // 
            lblSalarioBruto.AutoSize = true;
            lblSalarioBruto.Location = new Point(29, 45);
            lblSalarioBruto.Name = "lblSalarioBruto";
            lblSalarioBruto.Size = new Size(77, 15);
            lblSalarioBruto.TabIndex = 0;
            lblSalarioBruto.Text = "Salário Bruto:";
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.Location = new Point(112, 42);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.Size = new Size(100, 23);
            txtSalarioBruto.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(137, 81);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(29, 135);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(183, 334);
            txtResultado.TabIndex = 3;
            txtResultado.Text = "";
            // 
            // FormEx11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 512);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtSalarioBruto);
            Controls.Add(lblSalarioBruto);
            Name = "FormEx11";
            Text = "FormEx11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalarioBruto;
        private TextBox txtSalarioBruto;
        private Button btnCalcular;
        private RichTextBox txtResultado;
    }
}