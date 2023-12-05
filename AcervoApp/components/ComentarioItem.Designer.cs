namespace AcervoApp.components
{
    partial class ComentarioItem
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
            pcbUser = new PictureBox();
            txtComentario = new ReaLTaiizor.Controls.MaterialRichTextBox();
            lblUser = new Label();
            star1 = new PictureBox();
            star2 = new PictureBox();
            star3 = new PictureBox();
            star4 = new PictureBox();
            star5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star5).BeginInit();
            SuspendLayout();
            // 
            // pcbUser
            // 
            pcbUser.BorderStyle = BorderStyle.FixedSingle;
            pcbUser.Image = Properties.Resources.UserIcon;
            pcbUser.Location = new Point(32, 12);
            pcbUser.Name = "pcbUser";
            pcbUser.Size = new Size(87, 73);
            pcbUser.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUser.TabIndex = 0;
            pcbUser.TabStop = false;
            // 
            // txtComentario
            // 
            txtComentario.BackColor = Color.FromArgb(255, 255, 255);
            txtComentario.BorderStyle = BorderStyle.None;
            txtComentario.Depth = 0;
            txtComentario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtComentario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtComentario.Hint = "";
            txtComentario.Location = new Point(154, 45);
            txtComentario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(526, 97);
            txtComentario.TabIndex = 1;
            txtComentario.Text = "";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(32, 88);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(66, 23);
            lblUser.TabIndex = 2;
            lblUser.Text = "@user";
            // 
            // star1
            // 
            star1.BorderStyle = BorderStyle.FixedSingle;
            star1.Image = Properties.Resources.emptyStar;
            star1.Location = new Point(154, 6);
            star1.Name = "star1";
            star1.Size = new Size(34, 33);
            star1.SizeMode = PictureBoxSizeMode.Zoom;
            star1.TabIndex = 3;
            star1.TabStop = false;
            // 
            // star2
            // 
            star2.BorderStyle = BorderStyle.FixedSingle;
            star2.Image = Properties.Resources.emptyStar;
            star2.Location = new Point(194, 6);
            star2.Name = "star2";
            star2.Size = new Size(34, 33);
            star2.SizeMode = PictureBoxSizeMode.Zoom;
            star2.TabIndex = 4;
            star2.TabStop = false;
            // 
            // star3
            // 
            star3.BorderStyle = BorderStyle.FixedSingle;
            star3.Image = Properties.Resources.emptyStar;
            star3.Location = new Point(234, 6);
            star3.Name = "star3";
            star3.Size = new Size(34, 33);
            star3.SizeMode = PictureBoxSizeMode.Zoom;
            star3.TabIndex = 5;
            star3.TabStop = false;
            // 
            // star4
            // 
            star4.BorderStyle = BorderStyle.FixedSingle;
            star4.Image = Properties.Resources.emptyStar;
            star4.Location = new Point(274, 6);
            star4.Name = "star4";
            star4.Size = new Size(34, 33);
            star4.SizeMode = PictureBoxSizeMode.Zoom;
            star4.TabIndex = 6;
            star4.TabStop = false;
            // 
            // star5
            // 
            star5.BorderStyle = BorderStyle.FixedSingle;
            star5.Image = Properties.Resources.emptyStar;
            star5.Location = new Point(314, 6);
            star5.Name = "star5";
            star5.Size = new Size(34, 33);
            star5.SizeMode = PictureBoxSizeMode.Zoom;
            star5.TabIndex = 7;
            star5.TabStop = false;
            // 
            // ComentarioItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(star5);
            Controls.Add(star4);
            Controls.Add(star3);
            Controls.Add(star2);
            Controls.Add(star1);
            Controls.Add(lblUser);
            Controls.Add(txtComentario);
            Controls.Add(pcbUser);
            Name = "ComentarioItem";
            Size = new Size(734, 167);
            ((System.ComponentModel.ISupportInitialize)pcbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)star5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbUser;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtComentario;
        private Label lblUser;
        private PictureBox star1;
        private PictureBox star2;
        private PictureBox star3;
        private PictureBox star4;
        private PictureBox star5;
    }
}
