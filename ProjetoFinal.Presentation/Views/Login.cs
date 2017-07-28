using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Infrastructure.Repository;
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
    public partial class Login : Form
    {
        private IProdutoRepository _produtoRepository;

        public Login()
        {
            //_produtoRepository = ProjetoFinalKernel.GetInstance< IProdutoRepository>();

            InitializeComponent();

            var repo = new ProdutoRepository(new Infrastructure.Context.LaloContext());

            var produtos = _produtoRepository.FindAll();
        }

        #region Events

        private void btnLogar_Click(object sender, System.EventArgs e)
        {
            if (Equals(txtBoxLogin.Text, "admin") && Equals(txtBoxSenha.Text, "admin"))
            {
                Main menu = new Main();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Usuário e senha errados.", "", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK) return;
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
