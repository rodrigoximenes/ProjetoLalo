using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Clientes
{
    public partial class AdicionarClienteView : Form
    {
        private readonly IClienteRepository _clienteRepository;

        public AdicionarClienteView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            var cliente = new Cliente();
            cliente.NomeCompleto = "Rodrigo Ximenes";
            cliente.Telefone = "99284475";
            cliente.Email = "rodrigo@gmail.com";
            cliente.Cpf = "8674565";
            cliente.Endereco = new Endereco { Bairro = "Bairro1", Logradouro = "Logradouro1" };

            _clienteRepository.Add(cliente);
        }
    }
}
