namespace AcervoApp.view
{
    partial class Principal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            icones = new ImageList(components);
            pages = new ReaLTaiizor.Controls.MaterialTabControl();
            tabHome = new TabPage();
            lblCatalogo = new Label();
            panel = new FlowLayoutPanel();
            tabUser = new TabPage();
            btnNovoLivro = new MaterialSkin.Controls.MaterialButton();
            cmbMostraSenha = new ReaLTaiizor.Controls.MaterialCheckBox();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnSalvar = new MaterialSkin.Controls.MaterialButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBio = new ReaLTaiizor.Controls.RichTextBoxEdit();
            txtUser = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            imagemUser = new PictureBox();
            tabFavoritos = new TabPage();
            label4 = new Label();
            panelFav = new FlowLayoutPanel();
            tabLoggout = new TabPage();
            opfUser = new OpenFileDialog();
            pages.SuspendLayout();
            tabHome.SuspendLayout();
            tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagemUser).BeginInit();
            tabFavoritos.SuspendLayout();
            SuspendLayout();
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackColor = SystemColors.ActiveCaption;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-681, 183);
            materialDrawer1.Margin = new Padding(3, 4, 3, 4);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(681, 285);
            materialDrawer1.TabIndex = 0;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // icones
            // 
            icones.ColorDepth = ColorDepth.Depth8Bit;
            icones.ImageStream = (ImageListStreamer)resources.GetObject("icones.ImageStream");
            icones.TransparentColor = Color.Transparent;
            icones.Images.SetKeyName(0, "homeIcon.png");
            icones.Images.SetKeyName(1, "UserIcon.png");
            icones.Images.SetKeyName(2, "starIcon.png");
            icones.Images.SetKeyName(3, "logout.png");
            // 
            // pages
            // 
            pages.Controls.Add(tabHome);
            pages.Controls.Add(tabUser);
            pages.Controls.Add(tabFavoritos);
            pages.Controls.Add(tabLoggout);
            pages.Depth = 0;
            pages.Dock = DockStyle.Fill;
            pages.ImageList = icones;
            pages.Location = new Point(3, 85);
            pages.Margin = new Padding(3, 4, 3, 4);
            pages.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            pages.Multiline = true;
            pages.Name = "pages";
            pages.SelectedIndex = 0;
            pages.Size = new Size(1043, 692);
            pages.TabIndex = 3;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(lblCatalogo);
            tabHome.Controls.Add(panel);
            tabHome.ImageKey = "homeIcon.png";
            tabHome.Location = new Point(4, 29);
            tabHome.Margin = new Padding(3, 4, 3, 4);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3, 4, 3, 4);
            tabHome.Size = new Size(1035, 659);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            tabHome.Enter += tabHome_Enter;
            // 
            // lblCatalogo
            // 
            lblCatalogo.Dock = DockStyle.Top;
            lblCatalogo.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCatalogo.Location = new Point(3, 4);
            lblCatalogo.Name = "lblCatalogo";
            lblCatalogo.Size = new Size(1029, 75);
            lblCatalogo.TabIndex = 1;
            lblCatalogo.Text = "CATÁLOGO";
            lblCatalogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoScroll = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.Location = new Point(3, 83);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(1027, 568);
            panel.TabIndex = 0;
            // 
            // tabUser
            // 
            tabUser.Controls.Add(btnNovoLivro);
            tabUser.Controls.Add(cmbMostraSenha);
            tabUser.Controls.Add(btnCancelar);
            tabUser.Controls.Add(btnSalvar);
            tabUser.Controls.Add(label3);
            tabUser.Controls.Add(label2);
            tabUser.Controls.Add(label1);
            tabUser.Controls.Add(txtSenha);
            tabUser.Controls.Add(txtBio);
            tabUser.Controls.Add(txtUser);
            tabUser.Controls.Add(txtNome);
            tabUser.Controls.Add(imagemUser);
            tabUser.ImageKey = "UserIcon.png";
            tabUser.Location = new Point(4, 29);
            tabUser.Margin = new Padding(3, 4, 3, 4);
            tabUser.Name = "tabUser";
            tabUser.Padding = new Padding(3, 4, 3, 4);
            tabUser.Size = new Size(1035, 659);
            tabUser.TabIndex = 1;
            tabUser.Text = "User";
            tabUser.UseVisualStyleBackColor = true;
            tabUser.Enter += tabUser_Enter;
            // 
            // btnNovoLivro
            // 
            btnNovoLivro.AutoSize = false;
            btnNovoLivro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovoLivro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovoLivro.Depth = 0;
            btnNovoLivro.HighEmphasis = true;
            btnNovoLivro.Icon = null;
            btnNovoLivro.Location = new Point(562, 435);
            btnNovoLivro.Margin = new Padding(4, 6, 4, 6);
            btnNovoLivro.MouseState = MaterialSkin.MouseState.HOVER;
            btnNovoLivro.Name = "btnNovoLivro";
            btnNovoLivro.NoAccentTextColor = Color.Empty;
            btnNovoLivro.Size = new Size(198, 45);
            btnNovoLivro.TabIndex = 18;
            btnNovoLivro.Text = "Adicionar nova obra";
            btnNovoLivro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovoLivro.UseAccentColor = false;
            btnNovoLivro.UseVisualStyleBackColor = true;
            btnNovoLivro.Click += btnNovoLivro_Click;
            // 
            // cmbMostraSenha
            // 
            cmbMostraSenha.AutoSize = true;
            cmbMostraSenha.Depth = 0;
            cmbMostraSenha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMostraSenha.Location = new Point(334, 366);
            cmbMostraSenha.Margin = new Padding(0);
            cmbMostraSenha.MouseLocation = new Point(-1, -1);
            cmbMostraSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cmbMostraSenha.Name = "cmbMostraSenha";
            cmbMostraSenha.ReadOnly = false;
            cmbMostraSenha.Ripple = true;
            cmbMostraSenha.Size = new Size(139, 37);
            cmbMostraSenha.TabIndex = 17;
            cmbMostraSenha.Text = "Mostrar Senha";
            cmbMostraSenha.UseAccentColor = false;
            cmbMostraSenha.UseVisualStyleBackColor = true;
            cmbMostraSenha.CheckedChanged += cmbMostraSenha_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(794, 435);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(198, 45);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = false;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.Location = new Point(334, 435);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(198, 45);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "SALVAR";
            btnSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(334, 272);
            label3.Name = "label3";
            label3.Size = new Size(82, 27);
            label3.TabIndex = 14;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(334, 168);
            label2.Name = "label2";
            label2.Size = new Size(95, 27);
            label2.TabIndex = 13;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(334, 60);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 12;
            label1.Text = "Nome";
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
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(334, 302);
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
            txtSenha.Size = new Size(658, 48);
            txtSenha.TabIndex = 11;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // txtBio
            // 
            txtBio.AutoWordSelection = false;
            txtBio.BackColor = Color.Transparent;
            txtBio.BaseColor = Color.Transparent;
            txtBio.BorderColor = Color.FromArgb(180, 180, 180);
            txtBio.EdgeColor = Color.White;
            txtBio.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBio.ForeColor = Color.DimGray;
            txtBio.Location = new Point(49, 292);
            txtBio.Name = "txtBio";
            txtBio.ReadOnly = false;
            txtBio.Size = new Size(235, 188);
            txtBio.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtBio.TabIndex = 10;
            txtBio.TextBackColor = Color.White;
            txtBio.TextBorderStyle = BorderStyle.None;
            txtBio.TextFont = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBio.WordWrap = true;
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
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(334, 198);
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
            txtUser.Size = new Size(658, 48);
            txtUser.TabIndex = 9;
            txtUser.TabStop = false;
            txtUser.TextAlign = HorizontalAlignment.Left;
            txtUser.TrailingIcon = null;
            txtUser.UseSystemPasswordChar = false;
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
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(334, 90);
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
            txtNome.Size = new Size(658, 48);
            txtNome.TabIndex = 8;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // imagemUser
            // 
            imagemUser.Image = Properties.Resources.UserIcon;
            imagemUser.Location = new Point(49, 67);
            imagemUser.Margin = new Padding(3, 4, 3, 4);
            imagemUser.Name = "imagemUser";
            imagemUser.Size = new Size(235, 201);
            imagemUser.SizeMode = PictureBoxSizeMode.Zoom;
            imagemUser.TabIndex = 7;
            imagemUser.TabStop = false;
            imagemUser.DoubleClick += imagemUser_DoubleClick;
            // 
            // tabFavoritos
            // 
            tabFavoritos.Controls.Add(label4);
            tabFavoritos.Controls.Add(panelFav);
            tabFavoritos.ImageKey = "starIcon.png";
            tabFavoritos.Location = new Point(4, 29);
            tabFavoritos.Margin = new Padding(3, 4, 3, 4);
            tabFavoritos.Name = "tabFavoritos";
            tabFavoritos.Size = new Size(1035, 659);
            tabFavoritos.TabIndex = 2;
            tabFavoritos.Text = "Favoritos";
            tabFavoritos.UseVisualStyleBackColor = true;
            tabFavoritos.Enter += tabFavoritos_Enter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1035, 84);
            label4.TabIndex = 2;
            label4.Text = "FAVORITOS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFav
            // 
            panelFav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFav.AutoScroll = true;
            panelFav.Location = new Point(0, 88);
            panelFav.Margin = new Padding(3, 4, 3, 4);
            panelFav.Name = "panelFav";
            panelFav.Size = new Size(1035, 571);
            panelFav.TabIndex = 1;
            // 
            // tabLoggout
            // 
            tabLoggout.ImageKey = "logout.png";
            tabLoggout.Location = new Point(4, 29);
            tabLoggout.Name = "tabLoggout";
            tabLoggout.Size = new Size(1035, 659);
            tabLoggout.TabIndex = 3;
            tabLoggout.Text = "Loggout";
            tabLoggout.UseVisualStyleBackColor = true;
            tabLoggout.Click += tabLoggout_Click;
            tabLoggout.Enter += tabLoggout_Enter;
            // 
            // opfUser
            // 
            opfUser.FileName = "openFileDialog1";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 781);
            Controls.Add(pages);
            Controls.Add(materialDrawer1);
            DrawerTabControl = pages;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += Principal_FormClosing;
            pages.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabUser.ResumeLayout(false);
            tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagemUser).EndInit();
            tabFavoritos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private ImageList icones;
        private TabPage tabHome;
        private TabPage tabUser;
        protected ReaLTaiizor.Controls.MaterialTabControl pages;
        private FlowLayoutPanel panel;
        private TabPage tabFavoritos;
        private Label lblCatalogo;
        private PictureBox imagemUser;
        private ReaLTaiizor.Controls.RichTextBoxEdit txtBio;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUser;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnSalvar;
        private Label label3;
        private Label label2;
        private Label label4;
        private FlowLayoutPanel panelFav;
        private ReaLTaiizor.Controls.MaterialCheckBox cmbMostraSenha;
        private MaterialSkin.Controls.MaterialButton btnNovoLivro;
        private OpenFileDialog opfUser;
        private TabPage tabLoggout;
    }
}