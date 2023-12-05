namespace AcervoApp.view
{
    partial class FormComentarios
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
            btnAvaliar = new MaterialSkin.Controls.MaterialButton();
            panelComentarios = new FlowLayoutPanel();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnAvaliar
            // 
            btnAvaliar.AutoSize = false;
            btnAvaliar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAvaliar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAvaliar.Depth = 0;
            btnAvaliar.HighEmphasis = true;
            btnAvaliar.Icon = null;
            btnAvaliar.Location = new Point(7, 70);
            btnAvaliar.Margin = new Padding(4, 6, 4, 6);
            btnAvaliar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAvaliar.Name = "btnAvaliar";
            btnAvaliar.NoAccentTextColor = Color.Empty;
            btnAvaliar.Size = new Size(198, 45);
            btnAvaliar.TabIndex = 0;
            btnAvaliar.Text = "Avaliar";
            btnAvaliar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAvaliar.UseAccentColor = false;
            btnAvaliar.UseVisualStyleBackColor = true;
            btnAvaliar.Click += btnAvaliar_Click;
            // 
            // panelComentarios
            // 
            panelComentarios.AutoScroll = true;
            panelComentarios.Dock = DockStyle.Bottom;
            panelComentarios.FlowDirection = FlowDirection.TopDown;
            panelComentarios.Location = new Point(3, 138);
            panelComentarios.Name = "panelComentarios";
            panelComentarios.Size = new Size(864, 395);
            panelComentarios.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(212, 75);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(206, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Título do livro";
            // 
            // FormComentarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 536);
            Controls.Add(lblTitulo);
            Controls.Add(panelComentarios);
            Controls.Add(btnAvaliar);
            Name = "FormComentarios";
            Text = "Comentários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAvaliar;
        private FlowLayoutPanel panelComentarios;
        private Label lblTitulo;
    }
}