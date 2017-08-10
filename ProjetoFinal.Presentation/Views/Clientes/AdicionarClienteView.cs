using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using System;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Clientes
{
    public partial class AdicionarClienteView : Form
    {
        public int IdClienteSelecionado { get; set; }
        private readonly IClienteRepository _clienteRepository;

        public AdicionarClienteView()
        {
            _clienteRepository = LaloKernel.GetInstance<IClienteRepository>();

            InitializeComponent();

            this.Load += AdicionarClienteView_Load;
        }

        private void AdicionarClienteView_Load(object sender, EventArgs e)
        {
            LoadCliente();
        }

        private void LoadCliente()
        {
            gridClientes.DataSource = _clienteRepository.FindAll();
            ClearFields();
        }

        private void ClearFields()
        {
            IdClienteSelecionado = 0;
            txtBoxNome.Text = string.Empty;
            txtBoxCPF.Text = string.Empty;
            txtBoxEmail.Text = string.Empty;
            txtBoxEndereco.Text = string.Empty;
            txtBoxTelefone.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNome.Text) ||
                string.IsNullOrEmpty(txtBoxEndereco.Text) ||
                string.IsNullOrEmpty(txtBoxTelefone.Text) ||
                string.IsNullOrEmpty(txtBoxCPF.Text))
            {
                MessageBox.Show("Favor preencher os campos corretamente.");
                return;
            }
            try
            {
                var cliente = new Cliente();
                cliente.NomeCompleto = txtBoxNome.Text;
                cliente.Telefone = txtBoxTelefone.Text;
                cliente.Email = txtBoxEmail.Text;
                cliente.Cpf = txtBoxCPF.Text;
                cliente.Endereco = txtBoxEndereco.Text;

                if (IdClienteSelecionado > 0)
                {
                    var clienteAdd = cliente;
                    IdClienteSelecionado = Convert.ToInt32(gridClientes.SelectedRows[0].Cells[0].Value);
                    _clienteRepository.Update(clienteAdd, IdClienteSelecionado);
                }
                else
                {
                    _clienteRepository.Add(cliente);
                }

                MessageBox.Show("Cliente salvo com sucesso");
                LoadCliente();
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
                _clienteRepository.Delete(IdClienteSelecionado);
                LoadCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar excluir o cliente.");
            }
        }

        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdClienteSelecionado = Convert.ToInt32(gridClientes.SelectedRows[0].Cells[0].Value);

            var cliente = _clienteRepository.Find(IdClienteSelecionado);

            txtBoxNome.Text = cliente.NomeCompleto;
            txtBoxTelefone.Text = cliente.Telefone;
            txtBoxEndereco.Text = cliente.Endereco;
            txtBoxCPF.Text = cliente.Cpf;
            txtBoxEmail.Text = cliente.Email;
        }
    }
}
