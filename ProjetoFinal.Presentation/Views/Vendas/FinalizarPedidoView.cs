using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Vendas
{
    public partial class FinalizarPedidoView : Form
    {
        private readonly IPedidoRepository _pedidoRepository;

        public Pedido _pedido;
        public Cliente _cliente;
        public Endereco _endereco;
        public Produto _produtos;

        public FinalizarPedidoView(Pedido pedido, Cliente cliente, Endereco endereco, Produto produtos)
        {
            _pedidoRepository = LaloKernel.GetInstance<IPedidoRepository>();

            InitializeComponent();
            BindComboEntregas();

            this._endereco = endereco;
            this._pedido = pedido;
            this._cliente = cliente;
            this._produtos = produtos;

            txtBoxNome.Text = cliente.NomeCompleto;
            txtBoxFormaEntrega.Text = pedido.TipoEntrega;
            txtBoxEndereco.Text = pedido.EnderecoEntrega.Logradouro;
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
            _pedido.Cliente.Endereco = "_endereco1";
            _pedido.Cliente = _cliente;

            _pedidoRepository.Add(_pedido);

            MessageBox.Show("Pedido Finalizado");
        }

        #endregion

    }
}
