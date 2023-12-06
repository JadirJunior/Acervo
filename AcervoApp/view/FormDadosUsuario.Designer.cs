namespace AcervoApp.view
{
    partial class FormDadosUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDadosUsuario));
            label2 = new Label();
            label1 = new Label();
            txtBio = new ReaLTaiizor.Controls.RichTextBoxEdit();
            txtUser = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            imagemUser = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)imagemUser).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(382, 219);
            label2.Name = "label2";
            label2.Size = new Size(95, 27);
            label2.TabIndex = 25;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(382, 111);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 24;
            label1.Text = "Nome";
            // 
            // txtBio
            // 
            txtBio.AutoWordSelection = false;
            txtBio.BackColor = Color.Transparent;
            txtBio.BaseColor = Color.Transparent;
            txtBio.BorderColor = Color.FromArgb(180, 180, 180);
            txtBio.EdgeColor = Color.White;
            txtBio.Enabled = false;
            txtBio.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBio.ForeColor = Color.DimGray;
            txtBio.Location = new Point(661, 141);
            txtBio.Name = "txtBio";
            txtBio.ReadOnly = false;
            txtBio.Size = new Size(235, 188);
            txtBio.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtBio.TabIndex = 22;
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
            txtUser.Enabled = false;
            txtUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUser.HideSelection = true;
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(382, 249);
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
            txtUser.Size = new Size(242, 48);
            txtUser.TabIndex = 21;
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
            txtNome.Enabled = false;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(382, 141);
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
            txtNome.Size = new Size(242, 48);
            txtNome.TabIndex = 20;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // imagemUser
            // 
            imagemUser.Image = Properties.Resources.UserIcon;
            imagemUser.Location = new Point(97, 118);
            imagemUser.Margin = new Padding(3, 4, 3, 4);
            imagemUser.Name = "imagemUser";
            imagemUser.Size = new Size(235, 201);
            imagemUser.SizeMode = PictureBoxSizeMode.Zoom;
            imagemUser.TabIndex = 19;
            imagemUser.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(661, 111);
            label3.Name = "label3";
            label3.Size = new Size(46, 27);
            label3.TabIndex = 26;
            label3.Text = "Bio";
            // 
            // FormDadosUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 365);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBio);
            Controls.Add(txtUser);
            Controls.Add(txtNome);
            Controls.Add(imagemUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDadosUsuario";
            Text = "FormDadosUsuario";
            ((System.ComponentModel.ISupportInitialize)imagemUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.RichTextBoxEdit txtBio;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUser;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private PictureBox imagemUser;
        private Label label3;
    }
}