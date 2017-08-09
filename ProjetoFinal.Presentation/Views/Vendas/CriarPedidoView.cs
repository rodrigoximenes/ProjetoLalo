﻿using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using ProjetoFinal.Presentation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Vendas
{
    public partial class CriarPedidoView : Form
    {
        private IList<Item> ItemLista;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public PedidoViewModel PedidoViewModel { get; set; }

        public CriarPedidoView()
        {
            _pedidoRepository = LaloKernel.GetInstance<IPedidoRepository>();
            _produtoRepository = LaloKernel.GetInstance<IProdutoRepository>();

            PedidoViewModel = new PedidoViewModel();

            InitializeComponent();

            gridProdutos.AutoGenerateColumns = false;

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
            try
            {
                PedidoViewModel.EnderecoCliente = txtBoxEndereco.Text;
                PedidoViewModel.NomeCliente = txtBoxNome.Text;
                PedidoViewModel.CPF = txtBoxCPF.Text;
                PedidoViewModel.Telefone = txtBoxTelefone.Text;

                PedidoViewModel.DataEntrega = DateTime.Parse(dtTmPkrDataEntrega.Text);
                PedidoViewModel.DataSolicitacao = DateTime.Now;
                PedidoViewModel.TipoEntrega = cmbBoxFormaEntrega.SelectedText;
                PedidoViewModel.EnderecoEntrega = txtBoxEndereco.Text;

                var form = new FinalizarPedidoView(PedidoViewModel);
                form.ShowDialog();
                form.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Há algum campo inválido.");
                return;
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            var produtoSelecionado = _produtoRepository.Find(Convert.ToInt32(cmbBoxProdutos.SelectedValue));

            var itemExiste = PedidoViewModel.ItemsViewModel.SingleOrDefault(x => x.IdProduto == produtoSelecionado.Id);

            if (itemExiste != null)
            {
                itemExiste.Quantidade = itemExiste.Quantidade + Convert.ToInt32(txtBoxQuantidade.Text);
                itemExiste.PrecoTotal = itemExiste.PrecoUnitario * itemExiste.Quantidade;
            }
            else
            {
                var itemViewModel = new ItemPedidoViewModel();
                itemViewModel.IdProduto = produtoSelecionado.Id;
                itemViewModel.NomeProduto = produtoSelecionado.Nome;
                itemViewModel.Quantidade = Convert.ToInt32(txtBoxQuantidade.Text);
                itemViewModel.PrecoUnitario = produtoSelecionado.PrecoUnitario;
                itemViewModel.PrecoTotal = Convert.ToDecimal(txtBoxValorTotal.Text);
                PedidoViewModel.ItemsViewModel.Add(itemViewModel);
            }

            gridProdutos.DataSource = null;
            gridProdutos.DataSource = PedidoViewModel.ItemsViewModel;
        }

        private void txtBoxQuantidade_ValueChanged(object sender, EventArgs e)
        {
            var produtoSelecionado = _produtoRepository.Find(Convert.ToInt32(cmbBoxProdutos.SelectedValue));
            var quantidade = txtBoxQuantidade.Value;

            if (Equals(cmbBoxProdutos.SelectedIndex, -1)) return;
            txtBoxValorTotal.Text = (produtoSelecionado.PrecoUnitario * quantidade).ToString();
        }

        private void cmbBoxProdutos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtBoxQuantidade_ValueChanged(this, e);
        }

        private void btnRetirarProduto_Click(object sender, EventArgs e)
        {
            var idProdutoSelecionado = Convert.ToInt32(gridProdutos.SelectedRows[0].Cells[0].Value);

            var produtoExcluir = PedidoViewModel.ItemsViewModel.SingleOrDefault(x => x.IdProduto == idProdutoSelecionado);

            PedidoViewModel.ItemsViewModel.Remove(produtoExcluir);

            gridProdutos.DataSource = null;
            gridProdutos.DataSource = PedidoViewModel.ItemsViewModel;

        }
    }
}
