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
        public int IdUsuarioSelecionado { get; set; }
        private readonly IUsuarioRepository _usuarioRepository;

        public AdicionarUsuarioView()
        {
            _usuarioRepository = LaloKernel.GetInstance<IUsuarioRepository>();

            InitializeComponent();
            BindComboPerfil();

            this.Load += AdicionarUsuarioView_Load;
        }

        private void AdicionarUsuarioView_Load(object sender, EventArgs e)
        {
            LoadUsuario();
        }

        private void LoadUsuario()
        {
            gridUsuarios.DataSource = _usuarioRepository.FindAll();
            ClearFields();
        }

        private void ClearFields()
        {
            IdUsuarioSelecionado = 0;
            txtBoxNome.Text = string.Empty;
            txtBoxSenha.Text = string.Empty;
            cmbBoxPerfil.SelectedIndex = -1;
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

                if (IdUsuarioSelecionado > 0)
                {
                    _usuarioRepository.Update(usuario);
                }
                else
                {
                    _usuarioRepository.Add(usuario);
                }

                MessageBox.Show("Usuario salvo com sucesso");

                LoadUsuario();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor preencher os campos corretamente.");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                _usuarioRepository.Delete(IdUsuarioSelecionado);

                MessageBox.Show("Cliente excluído com sucesso");

                LoadUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir o cliente.");
            }
        }

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUsuarioSelecionado = Convert.ToInt32(gridUsuarios.SelectedRows[0].Cells[1].Value);

            var usuario = _usuarioRepository.Find(IdUsuarioSelecionado);

            txtBoxNome.Text = usuario.Nome;
            txtBoxSenha.Text = usuario.Senha;
            if (Equals(usuario.Perfil, "Admin")) cmbBoxPerfil.SelectedIndex = 0;
            if (Equals(usuario.Perfil, "Vendedor")) cmbBoxPerfil.SelectedIndex = 1;
            if (Equals(usuario.Perfil, "Gerente")) cmbBoxPerfil.SelectedIndex = 2;
        }
    }
}