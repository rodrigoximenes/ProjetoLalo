using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Vendas
{
    public partial class GerenciarPedidosView : Form
    {
        public GerenciarPedidosView()
        {
            InitializeComponent();
            BindCombo();
            BindDateTime();
            StartScreen();
        }

        #region PrivateMethods

        private void StartScreen()
        {
            dtTmPkrDataEntrega.Value = DateTime.Now;
            dtTmPkrDataRegistro.Value = DateTime.Today.AddDays(-1);
            cmbBoxStatus.SelectedIndex = -1;
            txtBoxNumeroPedido.Text = string.Empty;
        }

        private void BindCombo()
        {
            var statusList = new List<string>();

            statusList.Add("Em Aberto");
            statusList.Add("Aguardando entrega");
            statusList.Add("Concluída");
            cmbBoxStatus.DataSource = statusList;
        }

        private void BindDateTime()
        {
            dtTmPkrDataEntrega.Format = DateTimePickerFormat.Short;
            dtTmPkrDataRegistro.Format = DateTimePickerFormat.Short;
        }

        private void CleanFields()
        {
            txtBoxNumeroPedido.Text = string.Empty;
            txtBoxNomeCliente.Text = string.Empty;
            cmbBoxStatus.SelectedIndex = -1;
            dtTmPkrDataEntrega.Value = DateTime.Today;
            dtTmPkrDataRegistro.Value = DateTime.Today.AddDays(-1);
        }

        #endregion

        #region Events
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtTmPkrDataRegistro.Value > dtTmPkrDataEntrega.Value)
            {
                MessageBox.Show("Data de Entrega não pode ser menor que a Data de Registro");
                return;
            }

        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
