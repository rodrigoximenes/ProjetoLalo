using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;
using ProjetoFinal.Infrastructure.NinjectConfig;
using System;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Clientes
{
    public partial class AdicionarClienteView : Form
    {
        private readonly IClienteRepository _clienteRepository;

        public AdicionarClienteView()
        {
            _clienteRepository = LaloKernel.GetInstance<IClienteRepository>();

            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var cliente = new Cliente();
                cliente.NomeCompleto = txtBoxNome.Text;
                cliente.Telefone = txtBoxTelefone.Text;
                cliente.Email = txtBoxEmail.Text;
                cliente.Cpf = txtBoxCPF.Text;
                cliente.Endereco = txtBoxEndereco.Text;

                _clienteRepository.Add(cliente);
                MessageBox.Show("Cliente salvo com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Favor preencher os campos corretamente.");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //var clienteProcurado = _clienteRepository.Find(c => c.Nome == );

                //if (clienteProcurado == null) throw new ArgumentNullException(nameof(clienteProcurado));

                //gridClientes.DataSource = clienteProcurado;

            }
            catch (Exception)
            {

                MessageBox.Show("Cliente não encontrado");
            }

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            var cliente = gridClientes.SelectedRows;
        }
    }
}
