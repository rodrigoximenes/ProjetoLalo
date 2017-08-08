using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using System;
using System.Collections.Generic;
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
            BindComboPerfil();
        }

        private void BindComboPerfil()
        {
            var perfilList = new List<string>();

            perfilList.Add("Admin");
            perfilList.Add("Vendedor");
            perfilList.Add("Gerente");
            cmbBoxPerfil.DataSource = perfilList;
            cmbBoxPerfil.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxNome.Text) ||
              Equals(cmbBoxPerfil.SelectedIndex, -1) ||
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
                usuario.Perfil = cmbBoxPerfil.SelectedItem.ToString();

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
