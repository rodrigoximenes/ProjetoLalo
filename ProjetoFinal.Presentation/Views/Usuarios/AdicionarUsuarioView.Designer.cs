namespace ProjetoFinal.Presentation.Views.Usuarios
{
    partial class AdicionarUsuarioView
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
            this.grpBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblPerfil = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblSenha = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.cmbBoxPerfil = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnNovo = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.grpBoxUsuariosGrid = new System.Windows.Forms.GroupBox();
            this.tlpProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            this.grpBoxUsuarios.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.grpBoxUsuariosGrid.SuspendLayout();
            this.tlpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpBoxUsuarios, 0, 0);
            this.tlpMain.Controls.Add(this.grpBoxUsuariosGrid, 0, 1);
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
            // grpBoxUsuarios
            // 
            this.grpBoxUsuarios.Controls.Add(this.tlpCliente);
            this.grpBoxUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxUsuarios.Location = new System.Drawing.Point(3, 3);
            this.grpBoxUsuarios.Name = "grpBoxUsuarios";
            this.grpBoxUsuarios.Size = new System.Drawing.Size(636, 149);
            this.grpBoxUsuarios.TabIndex = 1;
            this.grpBoxUsuarios.TabStop = false;
            this.grpBoxUsuarios.Text = "Usuários";
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 5;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.04501F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.03175F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.26984F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73016F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCliente.Controls.Add(this.btnExcluir, 4, 2);
            this.tlpCliente.Controls.Add(this.txtBoxSenha, 2, 2);
            this.tlpCliente.Controls.Add(this.txtBoxNome, 2, 0);
            this.tlpCliente.Controls.Add(this.lblNome, 1, 0);
            this.tlpCliente.Controls.Add(this.lblPerfil, 1, 1);
            this.tlpCliente.Controls.Add(this.lblSenha, 1, 2);
            this.tlpCliente.Controls.Add(this.cmbBoxPerfil, 2, 1);
            this.tlpCliente.Controls.Add(this.btnSalvar, 4, 1);
            this.tlpCliente.Controls.Add(this.btnNovo, 4, 0);
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
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(513, 95);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 32);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSenha.Location = new System.Drawing.Point(211, 98);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(191, 20);
            this.txtBoxSenha.TabIndex = 2;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNome.Location = new System.Drawing.Point(211, 11);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(191, 20);
            this.txtBoxNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Location = new System.Drawing.Point(167, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPerfil.Location = new System.Drawing.Point(172, 58);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 7;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSenha.AutoSize = true;
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenha.Location = new System.Drawing.Point(164, 101);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // cmbBoxPerfil
            // 
            this.cmbBoxPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPerfil.FormattingEnabled = true;
            this.cmbBoxPerfil.Location = new System.Drawing.Point(211, 54);
            this.cmbBoxPerfil.Name = "cmbBoxPerfil";
            this.cmbBoxPerfil.Size = new System.Drawing.Size(191, 21);
            this.cmbBoxPerfil.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(513, 46);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 33);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(513, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(111, 33);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grpBoxUsuariosGrid
            // 
            this.grpBoxUsuariosGrid.Controls.Add(this.tlpProdutos);
            this.grpBoxUsuariosGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxUsuariosGrid.Location = new System.Drawing.Point(3, 158);
            this.grpBoxUsuariosGrid.Name = "grpBoxUsuariosGrid";
            this.grpBoxUsuariosGrid.Size = new System.Drawing.Size(636, 202);
            this.grpBoxUsuariosGrid.TabIndex = 3;
            this.grpBoxUsuariosGrid.TabStop = false;
            this.grpBoxUsuariosGrid.Text = "Usuários Cadastrados";
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
            this.tlpProdutos.Controls.Add(this.gridUsuarios, 0, 0);
            this.tlpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProdutos.Location = new System.Drawing.Point(3, 16);
            this.tlpProdutos.Name = "tlpProdutos";
            this.tlpProdutos.RowCount = 1;
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tlpProdutos.Size = new System.Drawing.Size(630, 183);
            this.tlpProdutos.TabIndex = 2;
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Perfil});
            this.tlpProdutos.SetColumnSpan(this.gridUsuarios, 6);
            this.gridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsuarios.Location = new System.Drawing.Point(3, 3);
            this.gridUsuarios.MultiSelect = false;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuarios.Size = new System.Drawing.Size(624, 177);
            this.gridUsuarios.TabIndex = 0;
            this.gridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsuarios_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "Perfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // AdicionarUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 363);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarUsuarioView";
            this.Text = "Criar Pedido";
            this.tlpMain.ResumeLayout(false);
            this.grpBoxUsuarios.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.grpBoxUsuariosGrid.ResumeLayout(false);
            this.tlpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpBoxUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private Components.LaloLabel lblNome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private Components.LaloLabel lblSenha;
        private Components.LaloPrimaryButton btnSalvar;
        private System.Windows.Forms.GroupBox grpBoxUsuariosGrid;
        private System.Windows.Forms.TableLayoutPanel tlpProdutos;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private Components.LaloPrimaryButton btnNovo;
        private Components.LaloPrimaryButton btnExcluir;
        private Components.LaloLabel lblPerfil;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.ComboBox cmbBoxPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
    }
}