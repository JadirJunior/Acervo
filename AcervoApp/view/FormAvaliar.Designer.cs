namespace AcervoApp.view
{
    partial class FormAvaliar
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
            txtComentario = new ReaLTaiizor.Controls.MaterialRichTextBox();
            label1 = new Label();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnStar1 = new ReaLTaiizor.Controls.ForeverButton();
            btnStar2 = new ReaLTaiizor.Controls.ForeverButton();
            btnStar3 = new ReaLTaiizor.Controls.ForeverButton();
            btnStar5 = new ReaLTaiizor.Controls.ForeverButton();
            btnStar4 = new ReaLTaiizor.Controls.ForeverButton();
            SuspendLayout();
            // 
            // txtComentario
            // 
            txtComentario.BackColor = Color.FromArgb(255, 255, 255);
            txtComentario.BorderStyle = BorderStyle.None;
            txtComentario.Depth = 0;
            txtComentario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtComentario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtComentario.Hint = "";
            txtComentario.Location = new Point(21, 148);
            txtComentario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(747, 207);
            txtComentario.TabIndex = 0;
            txtComentario.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 118);
            label1.Name = "label1";
            label1.Size = new Size(149, 27);
            label1.TabIndex = 1;
            label1.Text = "Comentário";
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
            btnSalvar.Location = new Point(21, 396);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(198, 45);
            btnSalvar.TabIndex = 2;
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
            btnCancelar.Location = new Point(227, 396);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(198, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnStar1
            // 
            btnStar1.BackColor = Color.Transparent;
            btnStar1.BackgroundImage = Properties.Resources.emptyStar;
            btnStar1.BackgroundImageLayout = ImageLayout.Zoom;
            btnStar1.BaseColor = Color.Transparent;
            btnStar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStar1.Location = new Point(321, 118);
            btnStar1.Name = "btnStar1";
            btnStar1.Rounded = false;
            btnStar1.Size = new Size(36, 24);
            btnStar1.TabIndex = 4;
            btnStar1.TextColor = Color.FromArgb(243, 243, 243);
            btnStar1.Click += btnStar1_Click;
            // 
            // btnStar2
            // 
            btnStar2.BackColor = Color.Transparent;
            btnStar2.BackgroundImage = Properties.Resources.emptyStar;
            btnStar2.BackgroundImageLayout = ImageLayout.Zoom;
            btnStar2.BaseColor = Color.Transparent;
            btnStar2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStar2.Location = new Point(373, 118);
            btnStar2.Name = "btnStar2";
            btnStar2.Rounded = false;
            btnStar2.Size = new Size(36, 24);
            btnStar2.TabIndex = 5;
            btnStar2.TextColor = Color.FromArgb(243, 243, 243);
            btnStar2.Click += btnStar2_Click;
            // 
            // btnStar3
            // 
            btnStar3.BackColor = Color.Transparent;
            btnStar3.BackgroundImage = Properties.Resources.emptyStar;
            btnStar3.BackgroundImageLayout = ImageLayout.Zoom;
            btnStar3.BaseColor = Color.Transparent;
            btnStar3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStar3.Location = new Point(422, 118);
            btnStar3.Name = "btnStar3";
            btnStar3.Rounded = false;
            btnStar3.Size = new Size(36, 24);
            btnStar3.TabIndex = 6;
            btnStar3.TextColor = Color.FromArgb(243, 243, 243);
            btnStar3.Click += btnStar3_Click;
            // 
            // btnStar5
            // 
            btnStar5.BackColor = Color.Transparent;
            btnStar5.BackgroundImage = Properties.Resources.emptyStar;
            btnStar5.BackgroundImageLayout = ImageLayout.Zoom;
            btnStar5.BaseColor = Color.Transparent;
            btnStar5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStar5.Location = new Point(520, 118);
            btnStar5.Name = "btnStar5";
            btnStar5.Rounded = false;
            btnStar5.Size = new Size(36, 24);
            btnStar5.TabIndex = 8;
            btnStar5.TextColor = Color.FromArgb(243, 243, 243);
            btnStar5.Click += btnStar5_Click;
            // 
            // btnStar4
            // 
            btnStar4.BackColor = Color.Transparent;
            btnStar4.BackgroundImage = Properties.Resources.emptyStar;
            btnStar4.BackgroundImageLayout = ImageLayout.Zoom;
            btnStar4.BaseColor = Color.Transparent;
            btnStar4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStar4.Location = new Point(471, 118);
            btnStar4.Name = "btnStar4";
            btnStar4.Rounded = false;
            btnStar4.Size = new Size(36, 24);
            btnStar4.TabIndex = 7;
            btnStar4.TextColor = Color.FromArgb(243, 243, 243);
            btnStar4.Click += btnStar4_Click;
            // 
            // FormAvaliar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStar5);
            Controls.Add(btnStar4);
            Controls.Add(btnStar3);
            Controls.Add(btnStar2);
            Controls.Add(btnStar1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtComentario);
            Name = "FormAvaliar";
            Text = "Avaliar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialRichTextBox txtComentario;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.ForeverButton btnStar1;
        private ReaLTaiizor.Controls.ForeverButton btnStar2;
        private ReaLTaiizor.Controls.ForeverButton btnStar3;
        private ReaLTaiizor.Controls.ForeverButton btnStar5;
        private ReaLTaiizor.Controls.ForeverButton btnStar4;
    }
}