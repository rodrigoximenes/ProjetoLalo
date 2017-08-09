using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Infrastructure.NinjectConfig;
using ProjetoFinal.Infrastructure.Repository;
using ProjetoFinal.Presentation.Views;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation
{
    public partial class Login : Form
    {
       // private IProdutoRepository _produtoRepository;

        public Login()
        {
          //  _produtoRepository = LaloKernel.GetInstance<IProdutoRepository>();

            InitializeComponent();

           // var repo = new ProdutoRepository(new Infrastructure.Context.LaloContext());

           // var produtos = repo.FindAll();
        }

        #region Events

        private void btnLogar_Click(object sender, System.EventArgs e)
        {
            if(Equals(txtBoxLogin.Text, "admin") && Equals(txtBoxSenha.Text, "admin"))
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
