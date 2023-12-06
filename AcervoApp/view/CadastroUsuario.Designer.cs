namespace AcervoApp.view
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUser = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSenhaConf = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBio = new ReaLTaiizor.Controls.MaterialRichTextBox();
            label1 = new Label();
            pcbImagem = new PictureBox();
            btnSelecionarImagem = new ReaLTaiizor.Controls.MaterialButton();
            opfImagem = new OpenFileDialog();
            btnCadastrar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(26, 107);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(361, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtUser.Hint = "Usuário";
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(409, 107);
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
            txtUser.Size = new Size(361, 48);
            txtUser.TabIndex = 1;
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
            txtSenha.Location = new Point(26, 161);
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
            txtSenha.Size = new Size(361, 48);
            txtSenha.TabIndex = 2;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // txtSenhaConf
            // 
            txtSenhaConf.AnimateReadOnly = false;
            txtSenhaConf.AutoCompleteMode = AutoCompleteMode.None;
            txtSenhaConf.AutoCompleteSource = AutoCompleteSource.None;
            txtSenhaConf.BackgroundImageLayout = ImageLayout.None;
            txtSenhaConf.CharacterCasing = CharacterCasing.Normal;
            txtSenhaConf.Depth = 0;
            txtSenhaConf.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenhaConf.HideSelection = true;
            txtSenhaConf.Hint = "Confirmar Senha";
            txtSenhaConf.LeadingIcon = null;
            txtSenhaConf.Location = new Point(26, 215);
            txtSenhaConf.MaxLength = 32767;
            txtSenhaConf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenhaConf.Name = "txtSenhaConf";
            txtSenhaConf.PasswordChar = '*';
            txtSenhaConf.PrefixSuffixText = null;
            txtSenhaConf.ReadOnly = false;
            txtSenhaConf.RightToLeft = RightToLeft.No;
            txtSenhaConf.SelectedText = "";
            txtSenhaConf.SelectionLength = 0;
            txtSenhaConf.SelectionStart = 0;
            txtSenhaConf.ShortcutsEnabled = true;
            txtSenhaConf.Size = new Size(361, 48);
            txtSenhaConf.TabIndex = 3;
            txtSenhaConf.TabStop = false;
            txtSenhaConf.TextAlign = HorizontalAlignment.Left;
            txtSenhaConf.TrailingIcon = null;
            txtSenhaConf.UseSystemPasswordChar = false;
            // 
            // txtBio
            // 
            txtBio.BackColor = Color.FromArgb(255, 255, 255);
            txtBio.BorderStyle = BorderStyle.None;
            txtBio.Depth = 0;
            txtBio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtBio.Hint = "";
            txtBio.Location = new Point(26, 310);
            txtBio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(273, 167);
            txtBio.TabIndex = 4;
            txtBio.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 284);
            label1.Name = "label1";
            label1.Size = new Size(37, 23);
            label1.TabIndex = 5;
            label1.Text = "Bio";
            // 
            // pcbImagem
            // 
            pcbImagem.BorderStyle = BorderStyle.FixedSingle;
            pcbImagem.Location = new Point(485, 161);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(229, 170);
            pcbImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pcbImagem.TabIndex = 6;
            pcbImagem.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            btnSelecionarImagem.AutoSize = false;
            btnSelecionarImagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSelecionarImagem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSelecionarImagem.Depth = 0;
            btnSelecionarImagem.HighEmphasis = true;
            btnSelecionarImagem.Icon = null;
            btnSelecionarImagem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSelecionarImagem.Location = new Point(485, 340);
            btnSelecionarImagem.Margin = new Padding(4, 6, 4, 6);
            btnSelecionarImagem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSelecionarImagem.Name = "btnSelecionarImagem";
            btnSelecionarImagem.NoAccentTextColor = Color.Empty;
            btnSelecionarImagem.Size = new Size(198, 45);
            btnSelecionarImagem.TabIndex = 7;
            btnSelecionarImagem.Text = "Selecionar Imagem";
            btnSelecionarImagem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSelecionarImagem.UseAccentColor = false;
            btnSelecionarImagem.UseVisualStyleBackColor = true;
            btnSelecionarImagem.Click += btnSelecionarImagem_Click;
            // 
            // opfImagem
            // 
            opfImagem.FileName = "openFileDialog1";
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = false;
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrar.Depth = 0;
            btnCadastrar.HighEmphasis = true;
            btnCadastrar.Icon = null;
            btnCadastrar.Location = new Point(366, 432);
            btnCadastrar.Margin = new Padding(4, 6, 4, 6);
            btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoAccentTextColor = Color.Empty;
            btnCadastrar.Size = new Size(198, 45);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrar.UseAccentColor = false;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(572, 432);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(198, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 500);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnSelecionarImagem);
            Controls.Add(pcbImagem);
            Controls.Add(label1);
            Controls.Add(txtBio);
            Controls.Add(txtSenhaConf);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroUsuario";
            Text = "CadastroUsuario";
            ((System.ComponentModel.ISupportInitialize)pcbImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUser;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenhaConf;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtBio;
        private Label label1;
        private PictureBox pcbImagem;
        private ReaLTaiizor.Controls.MaterialButton btnSelecionarImagem;
        private OpenFileDialog opfImagem;
        private MaterialSkin.Controls.MaterialButton btnCadastrar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}