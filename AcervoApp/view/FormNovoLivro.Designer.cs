namespace AcervoApp.view
{
    partial class FormNovoLivro
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
            txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSinopse = new ReaLTaiizor.Controls.MaterialRichTextBox();
            label1 = new Label();
            pcbImagem = new PictureBox();
            btnSelecionarImagem = new ReaLTaiizor.Controls.MaterialButton();
            opfSelecionar = new OpenFileDialog();
            btnSelecionarPdf = new ReaLTaiizor.Controls.MaterialButton();
            txtCaminho = new MaterialSkin.Controls.MaterialTextBox();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            lblGeneros = new Label();
            lstGeneros = new ListView();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.AutoCompleteMode = AutoCompleteMode.None;
            txtTitulo.AutoCompleteSource = AutoCompleteSource.None;
            txtTitulo.BackgroundImageLayout = ImageLayout.None;
            txtTitulo.CharacterCasing = CharacterCasing.Normal;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.HideSelection = true;
            txtTitulo.Hint = "Título";
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(45, 93);
            txtTitulo.MaxLength = 32767;
            txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PasswordChar = '\0';
            txtTitulo.PrefixSuffixText = null;
            txtTitulo.ReadOnly = false;
            txtTitulo.RightToLeft = RightToLeft.No;
            txtTitulo.SelectedText = "";
            txtTitulo.SelectionLength = 0;
            txtTitulo.SelectionStart = 0;
            txtTitulo.ShortcutsEnabled = true;
            txtTitulo.Size = new Size(481, 48);
            txtTitulo.TabIndex = 0;
            txtTitulo.TabStop = false;
            txtTitulo.TextAlign = HorizontalAlignment.Left;
            txtTitulo.TrailingIcon = null;
            txtTitulo.UseSystemPasswordChar = false;
            // 
            // txtSinopse
            // 
            txtSinopse.BackColor = Color.FromArgb(255, 255, 255);
            txtSinopse.BorderStyle = BorderStyle.None;
            txtSinopse.Depth = 0;
            txtSinopse.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSinopse.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtSinopse.Hint = "";
            txtSinopse.Location = new Point(45, 211);
            txtSinopse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtSinopse.Name = "txtSinopse";
            txtSinopse.Size = new Size(481, 139);
            txtSinopse.TabIndex = 1;
            txtSinopse.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 185);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 2;
            label1.Text = "Sinopse";
            // 
            // pcbImagem
            // 
            pcbImagem.BorderStyle = BorderStyle.FixedSingle;
            pcbImagem.Location = new Point(644, 93);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(167, 147);
            pcbImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pcbImagem.TabIndex = 3;
            pcbImagem.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            btnSelecionarImagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSelecionarImagem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSelecionarImagem.Depth = 0;
            btnSelecionarImagem.HighEmphasis = true;
            btnSelecionarImagem.Icon = null;
            btnSelecionarImagem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSelecionarImagem.Location = new Point(641, 249);
            btnSelecionarImagem.Margin = new Padding(4, 6, 4, 6);
            btnSelecionarImagem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSelecionarImagem.Name = "btnSelecionarImagem";
            btnSelecionarImagem.NoAccentTextColor = Color.Empty;
            btnSelecionarImagem.Size = new Size(170, 36);
            btnSelecionarImagem.TabIndex = 4;
            btnSelecionarImagem.Text = "Selecionar imagem";
            btnSelecionarImagem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSelecionarImagem.UseAccentColor = false;
            btnSelecionarImagem.UseVisualStyleBackColor = true;
            btnSelecionarImagem.Click += btnSelecionarImagem_Click;
            // 
            // opfSelecionar
            // 
            opfSelecionar.FileName = "openFileDialog1";
            // 
            // btnSelecionarPdf
            // 
            btnSelecionarPdf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSelecionarPdf.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSelecionarPdf.Depth = 0;
            btnSelecionarPdf.HighEmphasis = true;
            btnSelecionarPdf.Icon = null;
            btnSelecionarPdf.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSelecionarPdf.Location = new Point(45, 439);
            btnSelecionarPdf.Margin = new Padding(4, 6, 4, 6);
            btnSelecionarPdf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSelecionarPdf.Name = "btnSelecionarPdf";
            btnSelecionarPdf.NoAccentTextColor = Color.Empty;
            btnSelecionarPdf.Size = new Size(139, 36);
            btnSelecionarPdf.TabIndex = 6;
            btnSelecionarPdf.Text = "Selecionar Pdf";
            btnSelecionarPdf.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSelecionarPdf.UseAccentColor = false;
            btnSelecionarPdf.UseVisualStyleBackColor = true;
            btnSelecionarPdf.Click += btnSelecionarPdf_Click;
            // 
            // txtCaminho
            // 
            txtCaminho.AnimateReadOnly = false;
            txtCaminho.BorderStyle = BorderStyle.None;
            txtCaminho.Depth = 0;
            txtCaminho.Enabled = false;
            txtCaminho.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCaminho.LeadingIcon = null;
            txtCaminho.Location = new Point(45, 380);
            txtCaminho.MaxLength = 50;
            txtCaminho.MouseState = MaterialSkin.MouseState.OUT;
            txtCaminho.Multiline = false;
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(329, 50);
            txtCaminho.TabIndex = 7;
            txtCaminho.Text = "";
            txtCaminho.TrailingIcon = null;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = false;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(45, 494);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(139, 36);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(192, 494);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(139, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblGeneros
            // 
            lblGeneros.AutoSize = true;
            lblGeneros.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblGeneros.Location = new Point(583, 308);
            lblGeneros.Name = "lblGeneros";
            lblGeneros.Size = new Size(85, 21);
            lblGeneros.TabIndex = 11;
            lblGeneros.Text = "Gêneros";
            // 
            // lstGeneros
            // 
            lstGeneros.Location = new Point(583, 332);
            lstGeneros.Name = "lstGeneros";
            lstGeneros.Size = new Size(228, 198);
            lstGeneros.TabIndex = 12;
            lstGeneros.UseCompatibleStateImageBehavior = false;
            lstGeneros.View = View.List;
            // 
            // FormNovoLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 551);
            Controls.Add(lstGeneros);
            Controls.Add(lblGeneros);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtCaminho);
            Controls.Add(btnSelecionarPdf);
            Controls.Add(btnSelecionarImagem);
            Controls.Add(pcbImagem);
            Controls.Add(label1);
            Controls.Add(txtSinopse);
            Controls.Add(txtTitulo);
            Name = "FormNovoLivro";
            Text = "Novo Livro";
            ((System.ComponentModel.ISupportInitialize)pcbImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtSinopse;
        private Label label1;
        private PictureBox pcbImagem;
        private ReaLTaiizor.Controls.MaterialButton btnSelecionarImagem;
        private OpenFileDialog opfSelecionar;
        private ReaLTaiizor.Controls.MaterialButton btnSelecionarPdf;
        private MaterialSkin.Controls.MaterialTextBox txtCaminho;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private Label lblGeneros;
        private ListView lstGeneros;
    }
}