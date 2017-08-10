using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using ProjetoFinal.Presentation.ViewModel;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Vendas
{
    public partial class FinalizarPedidoView : Form
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IItemRepository _itemRepository;
        private readonly IClienteRepository _clienteRepository;

        public Pedido _pedido = new Pedido();
        public Cliente _cliente = new Cliente();

        public FinalizarPedidoView(PedidoViewModel pedidoViewModel)
        {
            _pedidoRepository = LaloKernel.GetInstance<IPedidoRepository>();
            _itemRepository = LaloKernel.GetInstance<IItemRepository>();
            _clienteRepository = LaloKernel.GetInstance<IClienteRepository>();

            //var _pedido = new Pedido();
            //var _cliente = new Cliente();

            InitializeComponent();
            BindComboEntregas();

            this._cliente.NomeCompleto = pedidoViewModel.NomeCliente;
            this._cliente.Cpf = pedidoViewModel.CPF;
            this._cliente.Endereco = pedidoViewModel.EnderecoCliente;
            this._cliente.Telefone = pedidoViewModel.Telefone;

            this._pedido.Cliente = _cliente;
            this._pedido.DataEntrega = pedidoViewModel.DataEntrega;
            this._pedido.DataSolicitacao = pedidoViewModel.DataSolicitacao;
            this._pedido.EnderecoEntrega = pedidoViewModel.EnderecoEntrega;
            this._pedido.TipoEntrega = pedidoViewModel.TipoEntrega;

            txtBoxNome.Text = pedidoViewModel.NomeCliente;
            txtBoxFormaEntrega.Text = pedidoViewModel.TipoEntrega;
            txtBoxEndereco.Text = pedidoViewModel.EnderecoEntrega;
            txtBoxValorPedido.Text = pedidoViewModel.getValorTotal().ToString();
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
        _clienteRepository.Add(_cliente);
        _pedidoRepository.Add(_pedido);

        MessageBox.Show("Pedido Finalizado");
    }

    #endregion

}
}
