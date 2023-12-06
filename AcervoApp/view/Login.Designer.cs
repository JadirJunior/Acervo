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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUser = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnEntrar = new ReaLTaiizor.Controls.MaterialButton();
            lblAcervo = new ReaLTaiizor.Controls.BigLabel();
            lblCadastro = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.AnimateReadOnly = false;
            txtUser.AutoCompleteMode = AutoCompleteMode.None;
            txtUser.AutoCompleteSource = AutoCompleteSource.None;
            txtUser.BackgroundImageLayout = ImageLayout.None;
            txtUser.CharacterCasing = CharacterCasing.Normal;
            txtUser.Depth = 0;
            txtUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUser.HideSelection = true;
            txtUser.Hint = "User";
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(7, 201);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.MaxLength = 32767;
            txtUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.PrefixSuffixText = null;
            txtUser.ReadOnly = false;
            txtUser.RightToLeft = RightToLeft.No;
            txtUser.SelectedText = "";
            txtUser.SelectionLength = 0;
            txtUser.SelectionStart = 0;
            txtUser.ShortcutsEnabled = true;
            txtUser.Size = new Size(410, 48);
            txtUser.TabIndex = 2;
            txtUser.TabStop = false;
            txtUser.TextAlign = HorizontalAlignment.Left;
            txtUser.TrailingIcon = null;
            txtUser.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(7, 301);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(410, 48);
            txtSenha.TabIndex = 3;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSize = false;
            btnEntrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEntrar.Depth = 0;
            btnEntrar.HighEmphasis = true;
            btnEntrar.Icon = null;
            btnEntrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEntrar.Location = new Point(116, 412);
            btnEntrar.Margin = new Padding(5, 8, 5, 8);
            btnEntrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEntrar.Name = "btnEntrar";
            btnEntrar.NoAccentTextColor = Color.Empty;
            btnEntrar.Size = new Size(181, 48);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEntrar.UseAccentColor = false;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblAcervo
            // 
            lblAcervo.AutoSize = true;
            lblAcervo.BackColor = Color.Transparent;
            lblAcervo.Font = new Font("Century Gothic", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcervo.ForeColor = Color.FromArgb(80, 80, 80);
            lblAcervo.Location = new Point(127, 112);
            lblAcervo.Name = "lblAcervo";
            lblAcervo.Size = new Size(170, 51);
            lblAcervo.TabIndex = 7;
            lblAcervo.Text = "Acervo";
            lblAcervo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCadastro.ForeColor = Color.Black;
            lblCadastro.Location = new Point(75, 468);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(285, 23);
            lblCadastro.TabIndex = 8;
            lblCadastro.Text = "Não possui login? Cadastre-se";
            lblCadastro.Click += lblCadastro_Click;
            lblCadastro.MouseLeave += lblCadastro_MouseLeave;
            lblCadastro.MouseHover += lblCadastro_MouseHover;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 563);
            Controls.Add(lblCadastro);
            Controls.Add(lblAcervo);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUser;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialButton btnEntrar;
        private ReaLTaiizor.Controls.BigLabel lblAcervo;
        private Label lblCadastro;
    }
}