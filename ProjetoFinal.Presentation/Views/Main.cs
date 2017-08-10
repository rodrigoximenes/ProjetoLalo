using ProjetoFinal.Presentation.Views.Clientes;
using ProjetoFinal.Presentation.Views.Estoque;
using ProjetoFinal.Presentation.Views.Usuarios;
using ProjetoFinal.Presentation.Views.Vendas;
using System;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region PrivateMethods

        private void VerifyPanel()
        {
            pnlMain.Controls.Clear();
        }

        #endregion

        #region Events
        private void btnCriarPedido_Click(object sender, EventArgs e)
        {
            VerifyPanel();
            var form = new CriarPedidoView();
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();
        }

        private void btnGerenciarPedido_Click(object sender, EventArgs e)
        {
            VerifyPanel();
            var form = new GerenciarPedidosView();
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();
        }

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            VerifyPanel();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            VerifyPanel();
            var form = new AdicionarClienteView();
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            VerifyPanel();
            var form = new AdicionarProdutoView();
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();
        }

        private void btnAdicionarUsuário_Click(object sender, EventArgs e)
        {
            VerifyPanel();
            var form = new AdicionarUsuarioView();
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();
        }

        #endregion


    }
}
