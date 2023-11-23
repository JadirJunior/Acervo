namespace AcervoApp.view
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
            this.txtUser = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnEntrar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSemLogin = new ReaLTaiizor.Controls.MaterialButton();
            this.lblAcervo = new ReaLTaiizor.Controls.BigLabel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.HideSelection = true;
            this.txtUser.Hint = "User";
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(6, 151);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PrefixSuffixText = null;
            this.txtUser.ReadOnly = false;
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(359, 48);
            this.txtUser.TabIndex = 2;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.HideSelection = true;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(6, 226);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PrefixSuffixText = null;
            this.txtSenha.ReadOnly = false;
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(359, 48);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TabStop = false;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = false;
            this.btnEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEntrar.Depth = 0;
            this.btnEntrar.HighEmphasis = true;
            this.btnEntrar.Icon = null;
            this.btnEntrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEntrar.Location = new System.Drawing.Point(25, 309);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEntrar.Size = new System.Drawing.Size(158, 36);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEntrar.UseAccentColor = false;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSemLogin
            // 
            this.btnSemLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSemLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSemLogin.Depth = 0;
            this.btnSemLogin.HighEmphasis = true;
            this.btnSemLogin.Icon = null;
            this.btnSemLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSemLogin.Location = new System.Drawing.Point(188, 309);
            this.btnSemLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSemLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSemLogin.Name = "btnSemLogin";
            this.btnSemLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSemLogin.Size = new System.Drawing.Size(158, 36);
            this.btnSemLogin.TabIndex = 5;
            this.btnSemLogin.Text = "Entrar sem login";
            this.btnSemLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSemLogin.UseAccentColor = false;
            this.btnSemLogin.UseVisualStyleBackColor = true;
            this.btnSemLogin.Click += new System.EventHandler(this.btnSemLogin_Click);
            // 
            // lblAcervo
            // 
            this.lblAcervo.AutoSize = true;
            this.lblAcervo.BackColor = System.Drawing.Color.Transparent;
            this.lblAcervo.Font = new System.Drawing.Font("Snap ITC", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcervo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblAcervo.Location = new System.Drawing.Point(107, 83);
            this.lblAcervo.Name = "lblAcervo";
            this.lblAcervo.Size = new System.Drawing.Size(150, 43);
            this.lblAcervo.TabIndex = 7;
            this.lblAcervo.Text = "Acervo";
            this.lblAcervo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblCadastro.Location = new System.Drawing.Point(79, 351);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(228, 20);
            this.lblCadastro.TabIndex = 8;
            this.lblCadastro.Text = "Não possui login? Cadastre-se";
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            this.lblCadastro.MouseLeave += new System.EventHandler(this.lblCadastro_MouseLeave);
            this.lblCadastro.MouseHover += new System.EventHandler(this.lblCadastro_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 422);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblAcervo);
            this.Controls.Add(this.btnSemLogin);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUser;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialButton btnEntrar;
        private ReaLTaiizor.Controls.MaterialButton btnSemLogin;
        private ReaLTaiizor.Controls.BigLabel lblAcervo;
        private Label lblCadastro;
    }
}