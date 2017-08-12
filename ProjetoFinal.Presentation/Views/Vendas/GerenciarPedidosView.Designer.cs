namespace ProjetoFinal.Presentation.Views.Vendas
{
    partial class GerenciarPedidosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxResultados = new System.Windows.Forms.GroupBox();
            this.tlpResultados = new System.Windows.Forms.TableLayoutPanel();
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.grpBoxConsultaPedidos = new System.Windows.Forms.GroupBox();
            this.tlpConsulta = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.lblNumeroPedido = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxNumeroPedido = new System.Windows.Forms.TextBox();
            this.lblDataEntrega = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.dtTmPkrDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtTmPkrDataRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblDataRegistro = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblStatus = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.cmbBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblNomeCliente = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.btnLimparFiltros = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnConsultar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            this.grpBoxResultados.SuspendLayout();
            this.tlpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.grpBoxConsultaPedidos.SuspendLayout();
            this.tlpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.grpBoxResultados, 0, 1);
            this.tlpMain.Controls.Add(this.grpBoxConsultaPedidos, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpMain.Size = new System.Drawing.Size(642, 363);
            this.tlpMain.TabIndex = 0;
            // 
            // grpBoxResultados
            // 
            this.tlpMain.SetColumnSpan(this.grpBoxResultados, 2);
            this.grpBoxResultados.Controls.Add(this.tlpResultados);
            this.grpBoxResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxResultados.Location = new System.Drawing.Point(3, 190);
            this.grpBoxResultados.Name = "grpBoxResultados";
            this.grpBoxResultados.Size = new System.Drawing.Size(636, 170);
            this.grpBoxResultados.TabIndex = 1;
            this.grpBoxResultados.TabStop = false;
            this.grpBoxResultados.Text = "Pedidos Cadastrados";
            // 
            // tlpResultados
            // 
            this.tlpResultados.ColumnCount = 1;
            this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.26786F));
            this.tlpResultados.Controls.Add(this.gridPedidos, 0, 0);
            this.tlpResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResultados.Location = new System.Drawing.Point(3, 16);
            this.tlpResultados.Name = "tlpResultados";
            this.tlpResultados.RowCount = 2;
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultados.Size = new System.Drawing.Size(630, 151);
            this.tlpResultados.TabIndex = 0;
            // 
            // gridPedidos
            // 
            this.gridPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdCliente,
            this.EnderecoEntrega,
            this.Cliente,
            this.TipoEntrega,
            this.DataSolicitacao,
            this.DataEntrega,
            this.Atendente});
            this.gridPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPedidos.Location = new System.Drawing.Point(3, 3);
            this.gridPedidos.MultiSelect = false;
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.ReadOnly = true;
            this.tlpResultados.SetRowSpan(this.gridPedidos, 2);
            this.gridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPedidos.Size = new System.Drawing.Size(624, 145);
            this.gridPedidos.TabIndex = 0;
            this.gridPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPedidos_CellClick);
            // 
            // grpBoxConsultaPedidos
            // 
            this.tlpMain.SetColumnSpan(this.grpBoxConsultaPedidos, 2);
            this.grpBoxConsultaPedidos.Controls.Add(this.tlpConsulta);
            this.grpBoxConsultaPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxConsultaPedidos.Location = new System.Drawing.Point(3, 3);
            this.grpBoxConsultaPedidos.Name = "grpBoxConsultaPedidos";
            this.grpBoxConsultaPedidos.Size = new System.Drawing.Size(636, 181);
            this.grpBoxConsultaPedidos.TabIndex = 0;
            this.grpBoxConsultaPedidos.TabStop = false;
            this.grpBoxConsultaPedidos.Text = "Consulta de Pedidos";
            // 
            // tlpConsulta
            // 
            this.tlpConsulta.ColumnCount = 4;
            this.tlpConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.49206F));
            this.tlpConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.19048F));
            this.tlpConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.723371F));
            this.tlpConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.4833F));
            this.tlpConsulta.Controls.Add(this.btnExcluir, 3, 2);
            this.tlpConsulta.Controls.Add(this.lblNumeroPedido, 0, 0);
            this.tlpConsulta.Controls.Add(this.txtBoxNumeroPedido, 1, 0);
            this.tlpConsulta.Controls.Add(this.lblDataEntrega, 0, 4);
            this.tlpConsulta.Controls.Add(this.dtTmPkrDataEntrega, 1, 4);
            this.tlpConsulta.Controls.Add(this.dtTmPkrDataRegistro, 1, 3);
            this.tlpConsulta.Controls.Add(this.lblDataRegistro, 0, 3);
            this.tlpConsulta.Controls.Add(this.lblStatus, 0, 2);
            this.tlpConsulta.Controls.Add(this.cmbBoxStatus, 1, 2);
            this.tlpConsulta.Controls.Add(this.lblNomeCliente, 0, 1);
            this.tlpConsulta.Controls.Add(this.txtBoxNomeCliente, 1, 1);
            this.tlpConsulta.Controls.Add(this.btnLimparFiltros, 3, 0);
            this.tlpConsulta.Controls.Add(this.btnConsultar, 3, 1);
            this.tlpConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConsulta.Location = new System.Drawing.Point(3, 16);
            this.tlpConsulta.Name = "tlpConsulta";
            this.tlpConsulta.RowCount = 5;
            this.tlpConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConsulta.Size = new System.Drawing.Size(630, 162);
            this.tlpConsulta.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(478, 69);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 27);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroPedido.Location = new System.Drawing.Point(47, 10);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(98, 13);
            this.lblNumeroPedido.TabIndex = 1;
            this.lblNumeroPedido.Text = "Número do Pedido:";
            // 
            // txtBoxNumeroPedido
            // 
            this.txtBoxNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxNumeroPedido.Location = new System.Drawing.Point(151, 6);
            this.txtBoxNumeroPedido.Name = "txtBoxNumeroPedido";
            this.txtBoxNumeroPedido.Size = new System.Drawing.Size(148, 20);
            this.txtBoxNumeroPedido.TabIndex = 0;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataEntrega.Location = new System.Drawing.Point(57, 142);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(88, 13);
            this.lblDataEntrega.TabIndex = 4;
            this.lblDataEntrega.Text = "Data de Entrega:";
            // 
            // dtTmPkrDataEntrega
            // 
            this.dtTmPkrDataEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtTmPkrDataEntrega.Location = new System.Drawing.Point(151, 138);
            this.dtTmPkrDataEntrega.Name = "dtTmPkrDataEntrega";
            this.dtTmPkrDataEntrega.Size = new System.Drawing.Size(148, 20);
            this.dtTmPkrDataEntrega.TabIndex = 4;
            this.dtTmPkrDataEntrega.Value = new System.DateTime(2017, 7, 20, 0, 0, 0, 0);
            // 
            // dtTmPkrDataRegistro
            // 
            this.dtTmPkrDataRegistro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtTmPkrDataRegistro.Location = new System.Drawing.Point(151, 105);
            this.dtTmPkrDataRegistro.Name = "dtTmPkrDataRegistro";
            this.dtTmPkrDataRegistro.Size = new System.Drawing.Size(148, 20);
            this.dtTmPkrDataRegistro.TabIndex = 3;
            this.dtTmPkrDataRegistro.Value = new System.DateTime(2017, 7, 20, 0, 0, 0, 0);
            // 
            // lblDataRegistro
            // 
            this.lblDataRegistro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataRegistro.AutoSize = true;
            this.lblDataRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataRegistro.Location = new System.Drawing.Point(55, 109);
            this.lblDataRegistro.Name = "lblDataRegistro";
            this.lblDataRegistro.Size = new System.Drawing.Size(90, 13);
            this.lblDataRegistro.TabIndex = 2;
            this.lblDataRegistro.Text = "Data de Registro:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStatus.AutoSize = true;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Location = new System.Drawing.Point(54, 76);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status do Pedido:";
            // 
            // cmbBoxStatus
            // 
            this.cmbBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxStatus.FormattingEnabled = true;
            this.cmbBoxStatus.Location = new System.Drawing.Point(151, 72);
            this.cmbBoxStatus.Name = "cmbBoxStatus";
            this.cmbBoxStatus.Size = new System.Drawing.Size(148, 21);
            this.cmbBoxStatus.TabIndex = 2;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomeCliente.Location = new System.Drawing.Point(57, 43);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(88, 13);
            this.lblNomeCliente.TabIndex = 5;
            this.lblNomeCliente.Text = "Nome do Cliente;";
            // 
            // txtBoxNomeCliente
            // 
            this.txtBoxNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxNomeCliente.Location = new System.Drawing.Point(151, 39);
            this.txtBoxNomeCliente.Name = "txtBoxNomeCliente";
            this.txtBoxNomeCliente.Size = new System.Drawing.Size(148, 20);
            this.txtBoxNomeCliente.TabIndex = 1;
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFiltros.Location = new System.Drawing.Point(478, 3);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(111, 27);
            this.btnLimparFiltros.TabIndex = 1;
            this.btnLimparFiltros.Text = "Novo";
            this.btnLimparFiltros.UseVisualStyleBackColor = false;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(478, 36);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 27);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseCompatibleTextRendering = true;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdPedido";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // EnderecoEntrega
            // 
            this.EnderecoEntrega.DataPropertyName = "EnderecoEntrega";
            this.EnderecoEntrega.HeaderText = "Endereço Entrega";
            this.EnderecoEntrega.Name = "EnderecoEntrega";
            this.EnderecoEntrega.ReadOnly = true;
            this.EnderecoEntrega.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NomeCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // TipoEntrega
            // 
            this.TipoEntrega.DataPropertyName = "TipoEntrega";
            this.TipoEntrega.HeaderText = "Tipo Entrega";
            this.TipoEntrega.Name = "TipoEntrega";
            this.TipoEntrega.ReadOnly = true;
            // 
            // DataSolicitacao
            // 
            this.DataSolicitacao.DataPropertyName = "DataSolicitacao";
            this.DataSolicitacao.HeaderText = "Data Solicitação";
            this.DataSolicitacao.Name = "DataSolicitacao";
            this.DataSolicitacao.ReadOnly = true;
            // 
            // DataEntrega
            // 
            this.DataEntrega.DataPropertyName = "DataEntrega";
            this.DataEntrega.HeaderText = "Data Entrega";
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.ReadOnly = true;
            // 
            // Atendente
            // 
            this.Atendente.DataPropertyName = "Atendente";
            this.Atendente.HeaderText = "Atendente";
            this.Atendente.Name = "Atendente";
            this.Atendente.ReadOnly = true;
            this.Atendente.Visible = false;
            // 
            // GerenciarPedidosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 363);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarPedidosView";
            this.Text = "Gerenciar Pedidos";
            this.tlpMain.ResumeLayout(false);
            this.grpBoxResultados.ResumeLayout(false);
            this.tlpResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.grpBoxConsultaPedidos.ResumeLayout(false);
            this.tlpConsulta.ResumeLayout(false);
            this.tlpConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpBoxResultados;
        private System.Windows.Forms.GroupBox grpBoxConsultaPedidos;
        private System.Windows.Forms.TableLayoutPanel tlpConsulta;
        private System.Windows.Forms.TableLayoutPanel tlpResultados;
        private Components.LaloLabel lblNumeroPedido;
        private Components.LaloLabel lblDataRegistro;
        private Components.LaloLabel lblStatus;
        private Components.LaloLabel lblDataEntrega;
        private System.Windows.Forms.TextBox txtBoxNumeroPedido;
        private System.Windows.Forms.DateTimePicker dtTmPkrDataRegistro;
        private System.Windows.Forms.DateTimePicker dtTmPkrDataEntrega;
        private System.Windows.Forms.ComboBox cmbBoxStatus;
        private Components.LaloPrimaryButton btnConsultar;
        private Components.LaloPrimaryButton btnLimparFiltros;
        private System.Windows.Forms.DataGridView gridPedidos;
        private Components.LaloPrimaryButton btnExcluir;
        private Components.LaloLabel lblNomeCliente;
        private System.Windows.Forms.TextBox txtBoxNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atendente;
    }
}