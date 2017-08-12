using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using ProjetoFinal.Presentation.ViewModel;
using System;
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
        public PedidoViewModel _pedidoViewModel { get; set; }

        public Pedido _pedido = new Pedido();
        public Cliente _cliente = new Cliente();

        public FinalizarPedidoView(PedidoViewModel pedidoViewModel)
        {
            _pedidoRepository = LaloKernel.GetInstance<IPedidoRepository>();
            _itemRepository = LaloKernel.GetInstance<IItemRepository>();
            _clienteRepository = LaloKernel.GetInstance<IClienteRepository>();
            this._pedidoViewModel = pedidoViewModel;

            InitializeComponent();
            BindComboEntregas();

            _cliente.NomeCompleto = pedidoViewModel.NomeCliente;
            _cliente.Cpf = pedidoViewModel.CPF;
            _cliente.Endereco = pedidoViewModel.EnderecoCliente;
            _cliente.Telefone = pedidoViewModel.Telefone;
            _cliente.Email = pedidoViewModel.Email;

            _pedido.DataEntrega = pedidoViewModel.DataEntrega;
            _pedido.DataSolicitacao = pedidoViewModel.DataSolicitacao;
            _pedido.EnderecoEntrega = pedidoViewModel.EnderecoEntrega;
            _pedido.TipoEntrega = pedidoViewModel.TipoEntrega;
            _pedido.IdAtendente = pedidoViewModel.IdAtendente;
            _pedido.IdCliente = pedidoViewModel.IdCliente;

            txtBoxNome.Text = pedidoViewModel.NomeCliente;
            txtBoxFormaEntrega.Text = pedidoViewModel.TipoEntrega;
            txtBoxEndereco.Text = pedidoViewModel.EnderecoEntrega;
            txtBoxValorPedido.Text = pedidoViewModel.getValorTotal().ToString();
            txtBoxEmail.Text = pedidoViewModel.Email;
        }

        #region

        private void BindComboEntregas()
        {
            var entregasList = new List<string>();

            entregasList.Add("À Vista");
            entregasList.Add("Agendada");
            cmbBoxFormaPagamento.DataSource = entregasList;
            cmbBoxFormaPagamento.SelectedIndex = -1;
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
            if (Equals(VerificarCampos(), false)) return;

            try
            {
                if (_cliente.Id <= 0) _clienteRepository.Add(_cliente);

                _pedidoRepository.Add(_pedido);

                foreach (var itemViewModel in _pedidoViewModel.ItemsViewModel)
                {
                    var item = new Item();
                    item.IdPedido = _pedido.Id;
                    item.IdProduto = itemViewModel.IdProduto;
                    item.PrecoUnitario = itemViewModel.PrecoUnitario;
                    item.QuantidadeSolicitada = itemViewModel.Quantidade;

                    _itemRepository.Add(item);
                }

                MessageBox.Show("Pedido Finalizado");
                this.Close();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Pedido não finalizado");
            }
            
        }

        private bool VerificarCampos()
        {
            if (string.IsNullOrEmpty(txtBoxValorRecebido.Text) ||
                cmbBoxFormaPagamento.SelectedIndex == -1) return false;

            return true;
        }

        #endregion

    }
}
