using ProjetoFinal.Domain.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Vendas
{
    public partial class CriarPedidoView : Form
    {
        private IList<Item> ItemLista;



        public CriarPedidoView()
        {
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
            var produtosList = new List<string>();

            produtosList.Add("Guaraná Jesus");
            produtosList.Add("Pitú");
            produtosList.Add("Seven-Up");
            produtosList.Add("Groselha Milani");
            cmbBoxProdutos.DataSource = produtosList;
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

            //var pedido = new Pedido();

            //pedido.Cliente.NomeCompleto = txtBoxNome.Text;
            //pedido.Cliente.Cpf = txtBoxCPF.Text;
            //pedido.Cliente.Telefone = txtBoxTelefone.Text;
            //pedido.Cliente.Endereco.Logradouro = txtBoxEndereco.Text;

            //pedido.DataEntrega = DateTime.Parse(dtTmPkrDataEntrega.Text);
            //pedido.DataSolicitacao = DateTime.Now;
            //pedido.TipoEntrega = cmbBoxFormaEntrega.SelectedText;

            var form = new FinalizarPedidoView();
            form.ShowDialog();
            form.Focus();
        }

        #endregion
    }
}
