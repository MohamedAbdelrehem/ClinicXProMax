
namespace Clinic_Mang_Sys
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed;
        /// otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.bunifuAppBar1 = new Bunifu.Utils.BunifuAppBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navigtionMenu1 = new Kimtoo.NavigtionMenu();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuAppBar1
            // 
            this.bunifuAppBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.bunifuAppBar1.ControlBoxColor = System.Drawing.Color.Gray;
            this.bunifuAppBar1.ControlBoxColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.bunifuAppBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuAppBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuAppBar1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuAppBar1.Icon = null;
            this.bunifuAppBar1.Location = new System.Drawing.Point(255, 0);
            this.bunifuAppBar1.Name = "bunifuAppBar1";
            this.bunifuAppBar1.Size = new System.Drawing.Size(1025, 46);
            this.bunifuAppBar1.TabIndex = 3;
            this.bunifuAppBar1.Title = "";
            this.bunifuAppBar1.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.navigtionMenu1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 720);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // navigtionMenu1
            // 
            this.navigtionMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navigtionMenu1.AutoScroll = true;
            this.navigtionMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.navigtionMenu1.BackColor_Click = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.navigtionMenu1.BackColor_Hover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.navigtionMenu1.BackColor_Selected = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.navigtionMenu1.DisableToggling = new string[] {
        "Settings.Database"};
            this.navigtionMenu1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigtionMenu1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.navigtionMenu1.ForeColor_Selected = System.Drawing.Color.DimGray;
            this.navigtionMenu1.IsExpandable = false;
            this.navigtionMenu1.IsExpanded = true;
            this.navigtionMenu1.ItemHeight = 50;
            this.navigtionMenu1.ItemImageSize = new System.Drawing.Size(20, 20);
            this.navigtionMenu1.ItemPadding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.navigtionMenu1.ItemRightImageMargin = 20;
            this.navigtionMenu1.ItemRightImageSize = new System.Drawing.Size(15, 15);
            this.navigtionMenu1.Items = new Kimtoo.ButtonItem[] {
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items1"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items2"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items3"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items4")))};
            this.navigtionMenu1.ItemTextMargin = 8;
            this.navigtionMenu1.Location = new System.Drawing.Point(56, 177);
            this.navigtionMenu1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.navigtionMenu1.Name = "navigtionMenu1";
            this.navigtionMenu1.Size = new System.Drawing.Size(199, 472);
            this.navigtionMenu1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1007, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patients";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1007, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Appointments";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1007, 641);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Controls.Add(this.tabPage3);
            this.pages.Controls.Add(this.tabPage4);
            this.pages.Location = new System.Drawing.Point(261, 48);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.tabPage2;
            this.pages.PageIndex = 1;
            this.pages.PageName = "tabPage2";
            this.pages.PageTitle = "Patients";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1015, 667);
            this.pages.TabIndex = 5;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pages.Transition = animation1;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.bunifuAppBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Bunifu.Utils.BunifuAppBar bunifuAppBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Kimtoo.NavigtionMenu navigtionMenu1;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
    }
}
