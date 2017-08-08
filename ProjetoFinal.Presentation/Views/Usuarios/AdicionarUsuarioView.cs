using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Infrastructure.NinjectConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
