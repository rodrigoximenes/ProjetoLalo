using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Infrastructure.NinjectConfig;
using ProjetoFinal.Infrastructure.Repository;
using ProjetoFinal.Presentation.Views;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation
{
    public partial class Login : Form
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public Login()
        {
            _usuarioRepository = LaloKernel.GetInstance<IUsuarioRepository>();

            InitializeComponent();
           
        }

        #region Events

        private void btnLogar_Click(object sender, System.EventArgs e)
        {
            if(Equals(_usuarioRepository.AutenticaUsuario(txtBoxLogin.Text, txtBoxSenha.Text),true))
            {
                Main menu = new Main();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Usuário e senha inválidos.", "", MessageBoxButtons.OK);
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
