using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Vendas
{
    public partial class FinalizarPedidoView : Form
    {
        public FinalizarPedidoView()
        {
            InitializeComponent();
            BindComboEntregas();

        }

        #region

        private void BindComboEntregas()
        {
            var entregasList = new List<string>();

            entregasList.Add("À Vista");
            entregasList.Add("Agendada");
            cmbBoxFormaPagamento.DataSource = entregasList;
        }

        private void CalculoValorTotal()
        {
            var valorPedido = decimal.Parse(txtBoxValorPedido.Text);

            if (Equals(txtBoxValorDesconto.Text, string.Empty))
            {
                txtBoxValorTotal.Text = valorPedido.ToString();
            }
            else
            {
                txtBoxValorTotal.Text = (valorPedido - (valorPedido * (decimal.Parse(txtBoxValorDesconto.Text) / 100))).ToString();
            }
        }

        private void CalculoTroco()
        {
            var valorRecebido = decimal.Parse(txtBoxValorRecebido.Text);

            if (valorRecebido < decimal.Parse(txtBoxValorPedido.Text))
            {
                MessageBox.Show("Não é possível pagar pedido com o valor recebido");
                return;
            }

            txtBoxTroco.Text = (valorRecebido - decimal.Parse(txtBoxValorPedido.Text)).ToString();
        }

        #endregion


        #region Events

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void txtBoxValorRecebido_Leave(object sender, System.EventArgs e)
        {
            CalculoTroco();
            CalculoValorTotal();
        }

        private void txtBoxValorDesconto_Leave(object sender, System.EventArgs e)
        {
            CalculoTroco();
            CalculoValorTotal();
        }

        private void btnFinalizarPedido_Click(object sender, System.EventArgs e)
        {


            MessageBox.Show("Pedido Finalizado");
        }

        #endregion


    }
}
