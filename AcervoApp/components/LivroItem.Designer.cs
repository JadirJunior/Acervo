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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imagemUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagemUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(256, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sinopse";
            // 
            // imagemUser
            // 
            this.imagemUser.Image = global::AcervoApp.Properties.Resources.UserIcon;
            this.imagemUser.Location = new System.Drawing.Point(437, 11);
            this.imagemUser.Name = "imagemUser";
            this.imagemUser.Size = new System.Drawing.Size(65, 63);
            this.imagemUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemUser.TabIndex = 6;
            this.imagemUser.TabStop = false;
            this.imagemUser.Click += new System.EventHandler(this.imagemUser_Click);
            // 
            // LivroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.imagemUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LivroItem";
            this.Size = new System.Drawing.Size(604, 200);
            this.Load += new System.EventHandler(this.LivroItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagemUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox imagemUser;
    }
}
