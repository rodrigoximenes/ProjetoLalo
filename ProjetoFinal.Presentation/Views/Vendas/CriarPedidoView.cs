using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using ProjetoFinal.Presentation.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Vendas
{
    public partial class CriarPedidoView : Form
    {
        private IList<Item> ItemLista;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public CriarPedidoView()
        {
            _pedidoRepository = LaloKernel.GetInstance<IPedidoRepository>();
            _produtoRepository = LaloKernel.GetInstance<IProdutoRepository>();

            InitializeComponent();
            BindComboEntregas();
            BindComboProdutos();
            StartScreen();
        }

        #region PrivateMethods

        private void StartScreen()
        {
            dtTmPkrDataEntrega.Value = DateTime.Now;
            dtTmPkrDataEntrega.Format = DateTimePickerFormat.Short;
            cmbBoxFormaEntrega.SelectedIndex = -1;
            cmbBoxProdutos.SelectedIndex = -1;
        }

        private void BindComboEntregas()
        {
            var entregasList = new List<string>();

            entregasList.Add("Imediata");
            entregasList.Add("Agendada");
            cmbBoxFormaEntrega.DataSource = entregasList;
        }

        private void BindComboProdutos()
        {
            cmbBoxProdutos.DataSource = _produtoRepository.FindAll();
            cmbBoxProdutos.DisplayMember = "Nome";
            cmbBoxProdutos.ValueMember = "Id";
        }

        private bool VerifyPanel()
        {
            if (Equals(Parent.Controls.Count, 1))
            {
                DialogResult dialogResult =
                    MessageBox.Show("Não há mais pedidos para fazer? ", "Ir para Finalizar Pedido", MessageBoxButtons.OKCancel);
                if (dialogResult != DialogResult.OK)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Events

        private void chkBoxUsuarioPadrao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxUsuarioPadrao.Checked)
            {
                txtBoxNome.Text = "Usuário Fantasma";
                txtBoxNome.Enabled = false;

                txtBoxTelefone.Text = string.Empty;
                txtBoxTelefone.Enabled = false;

                txtBoxCPF.Text = string.Empty;
                txtBoxCPF.Enabled = false;

                btnBuscarCliente.Enabled = false;
            }
            else
            {
                txtBoxNome.Text = string.Empty;
                txtBoxNome.Enabled = true;

                txtBoxTelefone.Text = string.Empty;
                txtBoxTelefone.Enabled = true;

                txtBoxCPF.Text = string.Empty;
                txtBoxCPF.Enabled = true;

                btnBuscarCliente.Enabled = true;
            }
        }

        private void cmbBoxFormaEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Equals(cmbBoxFormaEntrega.SelectedIndex, 0))
            {
                txtBoxEndereco.Enabled = false;
                txtBoxEndereco.Text = string.Empty;

                dtTmPkrDataEntrega.Enabled = false;
                dtTmPkrDataEntrega.Text = string.Empty;

                chkBoxTrocaEndereco.Checked = false;
                chkBoxTrocaEndereco.Enabled = false;

                btnAdicionarEndereco.Enabled = false;
            }
            else
            {
                txtBoxEndereco.Enabled = true;
                txtBoxEndereco.Text = string.Empty;

                dtTmPkrDataEntrega.Enabled = true;
                dtTmPkrDataEntrega.Text = string.Empty;

                chkBoxTrocaEndereco.Checked = false;
                chkBoxTrocaEndereco.Enabled = true;

                btnAdicionarEndereco.Enabled = true;
            }

        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (!Equals(VerifyPanel(), true)) return;

            try
            {
                var cliente = new Cliente();
                var pedido = new Pedido();
                var endereco = new Endereco();
                var produtos = new Produto();

                endereco.Logradouro = txtBoxEndereco.Text;
                endereco.Bairro = "Bairro";


                cliente.Endereco = "endereco1";
                cliente.NomeCompleto = txtBoxNome.Text;
                cliente.Cpf = txtBoxCPF.Text;
                cliente.Telefone = txtBoxTelefone.Text;

                pedido.Cliente = cliente;
                pedido.DataEntrega = DateTime.Parse(dtTmPkrDataEntrega.Text);
                pedido.DataSolicitacao = DateTime.Now;
                pedido.TipoEntrega = cmbBoxFormaEntrega.SelectedText;
                //pedido.EnderecoEntrega = endereco;



                var form = new FinalizarPedidoView(pedido, cliente, endereco, produtos);
                form.ShowDialog();
                form.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Há algum campo inválido.");
                return;
            }
        }

        #endregion

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            var itemPedidoViewModel = new ItemPedidoViewModel();

            var produtoSelecionado = _produtoRepository.Find(Convert.ToInt32(cmbBoxProdutos.SelectedValue));

            itemPedidoViewModel.IdProduto = produtoSelecionado.Id;
            itemPedidoViewModel.NomeProduto = produtoSelecionado.Nome;
            itemPedidoViewModel.Quantidade = Convert.ToInt32(txtBoxQuantidade.Text);
            itemPedidoViewModel.PrecoTotal = Convert.ToDecimal(txtBoxValorTotal.Text);
        }

        private void txtBoxQuantidade_ValueChanged(object sender, EventArgs e)
        {
            var produtoSelecionado = _produtoRepository.Find(Convert.ToInt32(cmbBoxProdutos.SelectedValue));
            var quantidade = txtBoxQuantidade.Value;

            if (Equals(cmbBoxProdutos.SelectedIndex, -1)) return;
            txtBoxValorTotal.Text = (produtoSelecionado.PrecoUnitario * quantidade).ToString();
        }
    }
}
