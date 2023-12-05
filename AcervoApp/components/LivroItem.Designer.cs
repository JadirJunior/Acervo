﻿namespace AcervoApp.components
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
            pcbApagar = new PictureBox();
            pcbEditar = new PictureBox();
            btnLer = new ReaLTaiizor.Controls.ForeverButton();
            btnComentarios = new ReaLTaiizor.Controls.ForeverButton();
            ((System.ComponentModel.ISupportInitialize)imagemUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFavorito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbApagar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbEditar).BeginInit();
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
            // pcbApagar
            // 
            pcbApagar.Image = Properties.Resources.Apagar;
            pcbApagar.Location = new Point(559, 200);
            pcbApagar.Name = "pcbApagar";
            pcbApagar.Size = new Size(33, 33);
            pcbApagar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbApagar.TabIndex = 15;
            pcbApagar.TabStop = false;
            pcbApagar.Click += pcbApagar_Click;
            // 
            // pcbEditar
            // 
            pcbEditar.Image = Properties.Resources.editar;
            pcbEditar.Location = new Point(520, 199);
            pcbEditar.Name = "pcbEditar";
            pcbEditar.Size = new Size(33, 33);
            pcbEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbEditar.TabIndex = 16;
            pcbEditar.TabStop = false;
            pcbEditar.Click += pcbEditar_Click;
            // 
            // btnLer
            // 
            btnLer.BackColor = Color.Transparent;
            btnLer.BaseColor = Color.Silver;
            btnLer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLer.Location = new Point(84, 197);
            btnLer.Name = "btnLer";
            btnLer.Rounded = true;
            btnLer.Size = new Size(144, 35);
            btnLer.TabIndex = 19;
            btnLer.Text = "Ler agora";
            btnLer.TextColor = Color.FromArgb(243, 243, 243);
            btnLer.Click += btnLer_Click;
            // 
            // btnComentarios
            // 
            btnComentarios.BackColor = Color.Transparent;
            btnComentarios.BackgroundImage = (Image)resources.GetObject("btnComentarios.BackgroundImage");
            btnComentarios.BackgroundImageLayout = ImageLayout.Zoom;
            btnComentarios.BaseColor = Color.Transparent;
            btnComentarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnComentarios.Location = new Point(234, 194);
            btnComentarios.Name = "btnComentarios";
            btnComentarios.Rounded = false;
            btnComentarios.Size = new Size(42, 38);
            btnComentarios.TabIndex = 20;
            btnComentarios.TextColor = Color.FromArgb(243, 243, 243);
            btnComentarios.Click += btnComentarios_Click;
            // 
            // LivroItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnComentarios);
            Controls.Add(btnLer);
            Controls.Add(pcbEditar);
            Controls.Add(pcbApagar);
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
            ((System.ComponentModel.ISupportInitialize)pcbApagar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbEditar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private PictureBox imagemUser;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtSinopse;
        private ListView listGeneros;
        private PictureBox pcbFavorito;
        private PictureBox pcbApagar;
        private PictureBox pcbEditar;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.AloneButton aloneButton1;
        private ReaLTaiizor.Controls.ForeverButton btnLer;
        private ReaLTaiizor.Controls.ForeverButton btnComentarios;
    }
}
