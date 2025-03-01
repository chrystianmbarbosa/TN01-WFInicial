using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx6 : Form
    {
        public FormEx6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double valorHora = Convert.ToDouble(txtValorHora.Text);
            int quantHoras = Convert.ToInt32(txtQuantHoras.Text);
            double resultado = valorHora * quantHoras;

            string mensagem = $"A renda total de {nome} é R$ {resultado:F2}";

            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
