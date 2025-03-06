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
    public partial class FormEx7 : Form
    {
        public string[] ListaNomeProdutos = new string[6];
        public double[] ListaValoresProdutos = new double[6];
        public int contador = 0;

        public FormEx7()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            ListaNomeProdutos[contador - 1] = txtNomeProduto.Text;
            ListaValoresProdutos[contador - 1] =
                Convert.ToDouble(txtValorProduto.Text);

            txtNomeProduto.Text = "";
            txtValorProduto.Text = "";

            if (contador == 6)
            {
                double menor = ListaValoresProdutos.Min();
                int pos_menor = Array.IndexOf(ListaValoresProdutos, menor);
                string mensagem =
                    $"O Produto mais Barato é {ListaNomeProdutos[pos_menor]} " +
                    $"de valor R$ {menor:F2}";

                MessageBox.Show(mensagem);
            }

        }
    }
}
