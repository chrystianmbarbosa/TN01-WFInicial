namespace WFInicial
{
    partial class FormEx7
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
            btnCadastrar = new Button();
            txtNomeProduto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtValorProduto = new TextBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(112, 113);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(87, 19);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 68);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Valor: ";
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(87, 65);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 4;
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 184);
            Controls.Add(label2);
            Controls.Add(txtValorProduto);
            Controls.Add(label1);
            Controls.Add(txtNomeProduto);
            Controls.Add(btnCadastrar);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtNomeProduto;
        private Label label1;
        private Label label2;
        private TextBox txtValorProduto;
    }
}