namespace ProjetoFinal.Presentation
{
    partial class Login
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
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblSenha = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblBemVindo = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.btnCancelar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnLogar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.6F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.4F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tlpMain.Controls.Add(this.txtBoxSenha, 1, 2);
            this.tlpMain.Controls.Add(this.lblLogin, 0, 1);
            this.tlpMain.Controls.Add(this.lblSenha, 0, 2);
            this.tlpMain.Controls.Add(this.txtBoxLogin, 1, 1);
            this.tlpMain.Controls.Add(this.lblBemVindo, 0, 0);
            this.tlpMain.Controls.Add(this.btnCancelar, 2, 3);
            this.tlpMain.Controls.Add(this.btnLogar, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(232, 139);
            this.tlpMain.TabIndex = 1;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpMain.SetColumnSpan(this.txtBoxSenha, 2);
            this.txtBoxSenha.Location = new System.Drawing.Point(106, 75);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSenha.TabIndex = 1;
            this.txtBoxSenha.Text = "admin";
            this.txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLogin.AutoSize = true;
            this.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogin.Location = new System.Drawing.Point(64, 44);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSenha.AutoSize = true;
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenha.Location = new System.Drawing.Point(59, 78);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpMain.SetColumnSpan(this.txtBoxLogin, 2);
            this.txtBoxLogin.Location = new System.Drawing.Point(106, 41);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLogin.TabIndex = 0;
            this.txtBoxLogin.Text = "admin";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBemVindo.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lblBemVindo, 3);
            this.lblBemVindo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBemVindo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(3, 10);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(226, 13);
            this.lblBemVindo.TabIndex = 3;
            this.lblBemVindo.Text = "Bem Vindo ao Sistema - Depósito Lalo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(120, 109);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogar.Location = new System.Drawing.Point(25, 109);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 139);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.LaloPrimaryButton btnLogar;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Components.LaloLabel lblLogin;
        private Components.LaloLabel lblSenha;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private Components.LaloLabel lblBemVindo;
        private Components.LaloPrimaryButton btnCancelar;
    }
}

