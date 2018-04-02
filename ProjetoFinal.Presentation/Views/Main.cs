using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Infrastructure.NinjectConfig;
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

        private readonly IUsuarioRepository _usuarioRepository;

        public Main()
        {
            _usuarioRepository = LaloKernel.GetInstance<IUsuarioRepository>();

            InitializeComponent();
            lblTituloMain.Visible = false;
            btnUsuarioNome.Text = "Nome: " + _usuarioRepository.ObterUsuarioLogado().Nome;
            btnTipoUsuario.Text = "Perfil: " + _usuarioRepository.ObterUsuarioLogado().Perfil;
        }

        #region PrivateMethods

        private void VerifyPanel()
        {
            pnlMain.Controls.Clear();
            lblTituloMain.Visible = true;

        }

        #endregion

        #region Events
        private void btnCriarPedido_Click(object sender, EventArgs e)
        {
            VerifyPanel();
            var form = new CriarPedidoView();
            lblTituloMain.Text = form.Text;
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
            lblTituloMain.Text = form.Text;
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
            lblTituloMain.Text = form.Text;
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
            lblTituloMain.Text = form.Text;
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
            lblTituloMain.Text = form.Text;
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();
        }

        #endregion


    }
}
