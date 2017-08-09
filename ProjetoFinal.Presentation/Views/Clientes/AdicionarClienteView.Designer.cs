namespace ProjetoFinal.Presentation.Views.Clientes
{
    partial class AdicionarClienteView
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
            this.grpBoxDadosConsulta = new System.Windows.Forms.GroupBox();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnSalvar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.txtBoxTelefone = new System.Windows.Forms.TextBox();
            this.lblNome = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblTelefone = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.btnNovo = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblCPF = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.grpBoxDadosConsultaDetalhada = new System.Windows.Forms.GroupBox();
            this.tlpProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.tlpMain.SuspendLayout();
            this.grpBoxDadosConsulta.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.grpBoxDadosConsultaDetalhada.SuspendLayout();
            this.tlpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpBoxDadosConsulta, 0, 0);
            this.tlpMain.Controls.Add(this.grpBoxDadosConsultaDetalhada, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(642, 363);
            this.tlpMain.TabIndex = 0;
            // 
            // grpBoxDadosConsulta
            // 
            this.grpBoxDadosConsulta.Controls.Add(this.tlpCliente);
            this.grpBoxDadosConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDadosConsulta.Location = new System.Drawing.Point(3, 3);
            this.grpBoxDadosConsulta.Name = "grpBoxDadosConsulta";
            this.grpBoxDadosConsulta.Size = new System.Drawing.Size(636, 149);
            this.grpBoxDadosConsulta.TabIndex = 1;
            this.grpBoxDadosConsulta.TabStop = false;
            this.grpBoxDadosConsulta.Text = "Clientes";
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 6;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.6361F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.55556F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.26984F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.6361F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.984127F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73016F));
            this.tlpCliente.Controls.Add(this.btnExcluir, 5, 2);
            this.tlpCliente.Controls.Add(this.btnSalvar, 5, 1);
            this.tlpCliente.Controls.Add(this.txtBoxTelefone, 3, 0);
            this.tlpCliente.Controls.Add(this.lblNome, 0, 0);
            this.tlpCliente.Controls.Add(this.lblTelefone, 2, 0);
            this.tlpCliente.Controls.Add(this.txtBoxNome, 1, 0);
            this.tlpCliente.Controls.Add(this.btnNovo, 5, 0);
            this.tlpCliente.Controls.Add(this.txtBoxCPF, 1, 1);
            this.tlpCliente.Controls.Add(this.txtBoxEmail, 3, 1);
            this.tlpCliente.Controls.Add(this.lblEmail, 2, 1);
            this.tlpCliente.Controls.Add(this.txtBoxEndereco, 1, 2);
            this.tlpCliente.Controls.Add(this.lblEndereco, 0, 2);
            this.tlpCliente.Controls.Add(this.lblCPF, 0, 1);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(3, 16);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 3;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.Size = new System.Drawing.Size(630, 130);
            this.tlpCliente.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(513, 89);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 33);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(513, 46);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 33);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCliente.SetColumnSpan(this.txtBoxTelefone, 2);
            this.txtBoxTelefone.Location = new System.Drawing.Point(352, 11);
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(155, 20);
            this.txtBoxTelefone.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Location = new System.Drawing.Point(76, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefone.Location = new System.Drawing.Point(294, 15);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNome.Location = new System.Drawing.Point(120, 11);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(155, 20);
            this.txtBoxNome.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(513, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(114, 33);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCPF.Location = new System.Drawing.Point(120, 54);
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(155, 20);
            this.txtBoxCPF.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCliente.SetColumnSpan(this.txtBoxEmail, 2);
            this.txtBoxEmail.Location = new System.Drawing.Point(352, 54);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(155, 20);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Location = new System.Drawing.Point(311, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCliente.SetColumnSpan(this.txtBoxEndereco, 4);
            this.txtBoxEndereco.Location = new System.Drawing.Point(120, 98);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(387, 20);
            this.txtBoxEndereco.TabIndex = 4;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndereco.Location = new System.Drawing.Point(58, 101);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCPF.AutoSize = true;
            this.lblCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCPF.Location = new System.Drawing.Point(84, 58);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF:";
            // 
            // grpBoxDadosConsultaDetalhada
            // 
            this.grpBoxDadosConsultaDetalhada.Controls.Add(this.tlpProdutos);
            this.grpBoxDadosConsultaDetalhada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDadosConsultaDetalhada.Location = new System.Drawing.Point(3, 158);
            this.grpBoxDadosConsultaDetalhada.Name = "grpBoxDadosConsultaDetalhada";
            this.grpBoxDadosConsultaDetalhada.Size = new System.Drawing.Size(636, 202);
            this.grpBoxDadosConsultaDetalhada.TabIndex = 3;
            this.grpBoxDadosConsultaDetalhada.TabStop = false;
            this.grpBoxDadosConsultaDetalhada.Text = "Clientes Cadastrados";
            // 
            // tlpProdutos
            // 
            this.tlpProdutos.ColumnCount = 6;
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.612439F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58692F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32376F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.409887F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.26794F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.68254F));
            this.tlpProdutos.Controls.Add(this.gridClientes, 0, 0);
            this.tlpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProdutos.Location = new System.Drawing.Point(3, 16);
            this.tlpProdutos.Name = "tlpProdutos";
            this.tlpProdutos.RowCount = 1;
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tlpProdutos.Size = new System.Drawing.Size(630, 183);
            this.tlpProdutos.TabIndex = 2;
            // 
            // gridClientes
            // 
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpProdutos.SetColumnSpan(this.gridClientes, 6);
            this.gridClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClientes.Location = new System.Drawing.Point(3, 3);
            this.gridClientes.MultiSelect = false;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(624, 177);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellClick);
            // 
            // AdicionarClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 363);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarClienteView";
            this.Text = "Criar Pedido";
            this.tlpMain.ResumeLayout(false);
            this.grpBoxDadosConsulta.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.grpBoxDadosConsultaDetalhada.ResumeLayout(false);
            this.tlpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpBoxDadosConsulta;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private System.Windows.Forms.TextBox txtBoxTelefone;
        private Components.LaloLabel lblNome;
        private Components.LaloLabel lblTelefone;
        private Components.LaloPrimaryButton btnNovo;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private Components.LaloLabel lblEmail;
        private Components.LaloLabel lblEndereco;
        private Components.LaloPrimaryButton btnSalvar;
        private System.Windows.Forms.GroupBox grpBoxDadosConsultaDetalhada;
        private System.Windows.Forms.TableLayoutPanel tlpProdutos;
        private System.Windows.Forms.DataGridView gridClientes;
        private Components.LaloPrimaryButton btnExcluir;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private Components.LaloLabel lblCPF;
    }
}