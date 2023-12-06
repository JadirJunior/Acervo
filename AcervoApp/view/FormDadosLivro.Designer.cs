namespace AcervoApp.view
{
    partial class FormDadosLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDadosLivro));
            panelPdf = new Panel();
            SuspendLayout();
            // 
            // panelPdf
            // 
            panelPdf.Dock = DockStyle.Fill;
            panelPdf.Location = new Point(3, 64);
            panelPdf.Name = "panelPdf";
            panelPdf.Size = new Size(794, 383);
            panelPdf.TabIndex = 0;
            // 
            // FormDadosLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPdf);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDadosLivro";
            Text = "FormDadosLivro";
            WindowState = FormWindowState.Maximized;
            Resize += FormDadosLivro_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPdf;
    }
}