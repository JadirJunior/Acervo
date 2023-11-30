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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.icones = new System.Windows.Forms.ImageList(this.components);
            this.pages = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabFavoritos = new System.Windows.Forms.TabPage();
            this.pages.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-596, 137);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(596, 214);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // icones
            // 
            this.icones.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.icones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icones.ImageStream")));
            this.icones.TransparentColor = System.Drawing.Color.Transparent;
            this.icones.Images.SetKeyName(0, "homeIcon.png");
            this.icones.Images.SetKeyName(1, "UserIcon.png");
            this.icones.Images.SetKeyName(2, "starIcon.png");
            // 
            // pages
            // 
            this.pages.Controls.Add(this.tabHome);
            this.pages.Controls.Add(this.tabUser);
            this.pages.Controls.Add(this.tabFavoritos);
            this.pages.Depth = 0;
            this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages.ImageList = this.icones;
            this.pages.Location = new System.Drawing.Point(3, 64);
            this.pages.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(912, 519);
            this.pages.TabIndex = 3;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblCatalogo);
            this.tabHome.Controls.Add(this.panel);
            this.tabHome.ImageKey = "homeIcon.png";
            this.tabHome.Location = new System.Drawing.Point(4, 24);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(904, 491);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            this.tabHome.Enter += new System.EventHandler(this.tabHome_Enter);
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCatalogo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCatalogo.Location = new System.Drawing.Point(3, 3);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(898, 56);
            this.lblCatalogo.TabIndex = 1;
            this.lblCatalogo.Text = "CATÁLOGO";
            this.lblCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(3, 62);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(898, 426);
            this.panel.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.ImageKey = "UserIcon.png";
            this.tabUser.Location = new System.Drawing.Point(4, 24);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(904, 491);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // tabFavoritos
            // 
            this.tabFavoritos.ImageKey = "starIcon.png";
            this.tabFavoritos.Location = new System.Drawing.Point(4, 24);
            this.tabFavoritos.Name = "tabFavoritos";
            this.tabFavoritos.Size = new System.Drawing.Size(904, 491);
            this.tabFavoritos.TabIndex = 2;
            this.tabFavoritos.Text = "Favoritos";
            this.tabFavoritos.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 586);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.materialDrawer1);
            this.DrawerTabControl = this.pages;
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pages.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}