using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Infrastructure.NinjectConfig;
using ProjetoFinal.Presentation.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Vendas
{
    public partial class GerenciarPedidosView : Form
    {
        public int IdPedidoSelecionado { get; set; }
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IItemRepository _itemRepository;
        private List<PedidoViewModel> _pedidosViewModel { get; set; }

        public GerenciarPedidosView()
        {
            _itemRepository = LaloKernel.GetInstance<IItemRepository>();
            _pedidoRepository = LaloKernel.GetInstance<IPedidoRepository>();
            _clienteRepository = LaloKernel.GetInstance<IClienteRepository>();

            _pedidosViewModel = new List<PedidoViewModel>();

            InitializeComponent();
            BindCombo();
            BindDateTime();
            StartScreen();
            this.Load += GerenciarPedidosView_Load;

           
            gridPedidos.AutoGenerateColumns = false;
        }

        private void GerenciarPedidosView_Load(object sender, EventArgs e)
        {
            LoadPedidos();
        }

        private void LoadPedidos()
        {
            var pedidos = _pedidoRepository.FindAll();

            foreach (var pedido in pedidos)
            {
                var cliente = _clienteRepository.Find(pedido.IdCliente);
                pedido.Itens = _itemRepository.ListarItensPorIdPedido(pedido.Id);

                var pedidoViewModel = new PedidoViewModel();

                if (!Equals(cliente, null))
                {
                    pedidoViewModel.NomeCliente = cliente.NomeCompleto;
                    pedidoViewModel.IdCliente = cliente.Id;
                    pedidoViewModel.IdPedido = pedido.Id;
                    pedidoViewModel.TipoEntrega = pedido.TipoEntrega;
                    pedidoViewModel.IdAtendente = pedido.IdAtendente;
                    pedidoViewModel.DataSolicitacao = pedido.DataSolicitacao;
                    pedidoViewModel.DataEntrega = pedido.DataEntrega;
                }
                _pedidosViewModel.Add(pedidoViewModel);
            }
            gridPedidos.DataSource = null;
            gridPedidos.DataSource = _pedidosViewModel;
            ClearFields();
        }

        #region PrivateMethods

        private void StartScreen()
        {
            dtTmPkrDataEntrega.Value = DateTime.Now;
            dtTmPkrDataRegistro.Value = DateTime.Today.AddDays(-1);
            cmbBoxStatus.SelectedIndex = 0;
            txtBoxNumeroPedido.Text = string.Empty;
        }

        private void BindCombo()
        {
            var statusList = new List<string>();

            statusList.Add("Em Aberto");
            statusList.Add("Aguardando entrega");
            statusList.Add("Concluída");
            cmbBoxStatus.DataSource = statusList;
        }

        private void BindDateTime()
        {
            dtTmPkrDataEntrega.Format = DateTimePickerFormat.Short;
            dtTmPkrDataRegistro.Format = DateTimePickerFormat.Short;
        }

        private void ClearFields()
        {
            IdPedidoSelecionado = 0;
            txtBoxNumeroPedido.Text = string.Empty;
            txtBoxNomeCliente.Text = string.Empty;
            cmbBoxStatus.SelectedIndex = -1;
            dtTmPkrDataEntrega.Value = DateTime.Today;
            dtTmPkrDataRegistro.Value = DateTime.Today.AddDays(-1);
        }

        #endregion

        #region Events

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {

        }

        private void gridPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPedidoSelecionado = Convert.ToInt32(gridPedidos.SelectedRows[0].Cells["Id"].Value);

            var pedido = _pedidoRepository.Find(IdPedidoSelecionado);

            pedido.Cliente = _clienteRepository.Find(pedido.IdCliente);

            txtBoxNomeCliente.Text = pedido.Cliente.NomeCompleto;
            txtBoxNumeroPedido.Text = pedido.Cliente.Id.ToString();
            dtTmPkrDataEntrega.Text = pedido.DataEntrega.ToShortDateString();
            dtTmPkrDataRegistro.Text = pedido.DataSolicitacao.ToShortDateString();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
