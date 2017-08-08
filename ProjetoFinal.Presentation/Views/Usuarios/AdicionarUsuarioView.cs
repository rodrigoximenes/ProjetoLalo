using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using System;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Usuarios
{
    public partial class AdicionarUsuarioView : Form
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AdicionarUsuarioView()
        {
            _usuarioRepository = LaloKernel.GetInstance<IUsuarioRepository>();

            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxNome.Text) ||
              string.IsNullOrEmpty(txtBoxPerfil.Text) ||
              string.IsNullOrEmpty(txtBoxSenha.Text))
            {
                MessageBox.Show("Favor preencher os campos corretamente.");
                return;
            }

            try
            {
                var usuario = new Usuario();
                usuario.Nome = txtBoxNome.Text;
                usuario.Senha = txtBoxSenha.Text;
                usuario.Perfil = txtBoxPerfil.Text;

                _usuarioRepository.Add(usuario);
                MessageBox.Show("Usuario salvo com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Favor preencher os campos corretamente.");
            }
        }
    }
}
