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
    public partial class FormEx5 : Form
    {
        public FormEx5()
        {
            InitializeComponent();
        }

        private void btnMaiorMenor_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);

            int maior = Math.Max(num1, num2);
            maior = Math.Max(num3, maior);

            int menor = Math.Min(num1, num2);
            menor = Math.Min(num3, menor);

            string mensagem = $"O Número {maior} é o maior número!";
            mensagem += $"\n O Número {menor} é o menor número!";

            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
