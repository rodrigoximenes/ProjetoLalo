using ProjetoFinal.Presentation.Views.Clientes;
using ProjetoFinal.Presentation.Views.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private bool VerifyPanel()
        {
            if (Equals(pnlMain.Controls.Count, 1))
            {
                DialogResult dialogResult =
                    MessageBox.Show("Há outra página aberta. Deseja continuar?", "Abrir outra página", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    pnlMain.Controls.Clear();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Events
        private void btnCriarPedido_Click(object sender, EventArgs e)
        {
            if (!Equals(VerifyPanel(), true)) return;

            var form = new CriarPedidoView();
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();
        }

        private void btnGerenciarPedido_Click(object sender, EventArgs e)
        {
            if (!Equals(VerifyPanel(), true)) return;

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
            if (!Equals(VerifyPanel(), true)) return;

            var form = new AdicionarClienteView();
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();

        }

        #endregion


    }
}
