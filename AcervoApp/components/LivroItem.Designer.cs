namespace AcervoApp.components
{
    partial class LivroItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroItem));
            lblTitulo = new Label();
            imagemUser = new PictureBox();
            txtSinopse = new ReaLTaiizor.Controls.MaterialRichTextBox();
            listGeneros = new ListView();
            pcbFavorito = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagemUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFavorito).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(137, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(108, 44);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Título";
            // 
            // imagemUser
            // 
            imagemUser.Image = Properties.Resources.UserIcon;
            imagemUser.Location = new Point(463, 4);
            imagemUser.Margin = new Padding(3, 4, 3, 4);
            imagemUser.Name = "imagemUser";
            imagemUser.Size = new Size(87, 55);
            imagemUser.SizeMode = PictureBoxSizeMode.Zoom;
            imagemUser.TabIndex = 6;
            imagemUser.TabStop = false;
            imagemUser.Click += imagemUser_Click;
            imagemUser.MouseLeave += imagemUser_MouseLeave;
            imagemUser.MouseHover += imagemUser_MouseHover;
            // 
            // txtSinopse
            // 
            txtSinopse.BackColor = Color.FromArgb(255, 255, 255);
            txtSinopse.BorderStyle = BorderStyle.FixedSingle;
            txtSinopse.Depth = 0;
            txtSinopse.Enabled = false;
            txtSinopse.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSinopse.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtSinopse.Hint = "";
            txtSinopse.Location = new Point(3, 73);
            txtSinopse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtSinopse.Name = "txtSinopse";
            txtSinopse.Size = new Size(383, 108);
            txtSinopse.TabIndex = 7;
            txtSinopse.Text = "";
            // 
            // listGeneros
            // 
            listGeneros.Location = new Point(428, 73);
            listGeneros.Name = "listGeneros";
            listGeneros.Size = new Size(164, 108);
            listGeneros.TabIndex = 13;
            listGeneros.UseCompatibleStateImageBehavior = false;
            listGeneros.View = View.List;
            // 
            // pcbFavorito
            // 
            pcbFavorito.Image = (Image)resources.GetObject("pcbFavorito.Image");
            pcbFavorito.Location = new Point(18, 188);
            pcbFavorito.Margin = new Padding(3, 4, 3, 4);
            pcbFavorito.Name = "pcbFavorito";
            pcbFavorito.Size = new Size(47, 44);
            pcbFavorito.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFavorito.TabIndex = 14;
            pcbFavorito.TabStop = false;
            pcbFavorito.Click += pcbFavorito_Click;
            // 
            // LivroItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pcbFavorito);
            Controls.Add(listGeneros);
            Controls.Add(txtSinopse);
            Controls.Add(imagemUser);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LivroItem";
            Size = new Size(608, 236);
            Load += LivroItem_Load;
            Click += LivroItem_Click;
            ((System.ComponentModel.ISupportInitialize)imagemUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFavorito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private PictureBox imagemUser;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtSinopse;
        private ListView listGeneros;
        private PictureBox pcbFavorito;
    }
}
