namespace WFInicial
{
    partial class FormEx6
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
            lblNome = new Label();
            txtNome = new TextBox();
            txtValorHora = new TextBox();
            lblValorHora = new Label();
            txtQuantHoras = new TextBox();
            lblQuantHoras = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(29, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(157, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 23);
            txtNome.TabIndex = 1;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(157, 78);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 3;
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(29, 81);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(81, 15);
            lblValorHora.TabIndex = 2;
            lblValorHora.Text = "Valor da Hora:";
            // 
            // txtQuantHoras
            // 
            txtQuantHoras.Location = new Point(157, 130);
            txtQuantHoras.Name = "txtQuantHoras";
            txtQuantHoras.Size = new Size(100, 23);
            txtQuantHoras.TabIndex = 5;
            // 
            // lblQuantHoras
            // 
            lblQuantHoras.AutoSize = true;
            lblQuantHoras.Location = new Point(29, 133);
            lblQuantHoras.Name = "lblQuantHoras";
            lblQuantHoras.Size = new Size(122, 15);
            lblQuantHoras.TabIndex = 4;
            lblQuantHoras.Text = "Quantidade de Horas:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(296, 112);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 41);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 190);
            Controls.Add(btnCalcular);
            Controls.Add(txtQuantHoras);
            Controls.Add(lblQuantHoras);
            Controls.Add(txtValorHora);
            Controls.Add(lblValorHora);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtValorHora;
        private Label lblValorHora;
        private TextBox txtQuantHoras;
        private Label lblQuantHoras;
        private Button btnCalcular;
    }
}