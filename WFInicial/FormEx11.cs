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
    public partial class FormEx11 : Form
    {
        public double[] salariosBruto = new double[5];
        public int contador = 0;

        public FormEx11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (contador < 5)
            {
                double salarioBruto = double.Parse(txtSalarioBruto.Text);
                double salarioLiquido = salarioBruto * 0.88;

                salariosBruto[contador] = salarioBruto;

                txtResultado.Text +=
                    $"Valor Bruto: R$ {salarioBruto:F2} \n " +
                    $"Valor Líquido: R$ {salarioLiquido:F2} \n " +
                    "\n";
            }
            else
            {
                MessageBox.Show("Quantidade Máxima!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            contador++;
        }
    }
}
