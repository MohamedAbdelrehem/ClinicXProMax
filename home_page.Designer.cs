
namespace Clinic_Mang_Sys {
partial class home_page {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed;
  /// otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.panelSideMenu = new System.Windows.Forms.Panel();
    this.panelLogo = new System.Windows.Forms.Panel();
    this.button_Dashboard = new System.Windows.Forms.Button();
    this.button_Patiants = new System.Windows.Forms.Button();
    this.button_Appoinment = new System.Windows.Forms.Button();
    this.button_Setting = new System.Windows.Forms.Button();
    this.panel1 = new System.Windows.Forms.Panel();
    this.button_Clinic_Setting_Subsetting = new System.Windows.Forms.Button();
    this.button_Clinic_Program_Subsetting = new System.Windows.Forms.Button();
    this.button_About = new System.Windows.Forms.Button();
    this.panelSideMenu.SuspendLayout();
    this.panel1.SuspendLayout();
    this.SuspendLayout();
    //
    // panelSideMenu
    //
    this.panelSideMenu.AutoScroll = true;
    this.panelSideMenu.BackColor = System.Drawing.Color.Black;
    this.panelSideMenu.Controls.Add(this.button_About);
    this.panelSideMenu.Controls.Add(this.panel1);
    this.panelSideMenu.Controls.Add(this.button_Setting);
    this.panelSideMenu.Controls.Add(this.button_Appoinment);
    this.panelSideMenu.Controls.Add(this.button_Patiants);
    this.panelSideMenu.Controls.Add(this.button_Dashboard);
    this.panelSideMenu.Controls.Add(this.panelLogo);
    this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
    this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
    this.panelSideMenu.Name = "panelSideMenu";
    this.panelSideMenu.Size = new System.Drawing.Size(250, 491);
    this.panelSideMenu.TabIndex = 0;
    this.panelSideMenu.Paint +=
        new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
    //
    // panelLogo
    //
    this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
    this.panelLogo.Location = new System.Drawing.Point(0, 0);
    this.panelLogo.Name = "panelLogo";
    this.panelLogo.Size = new System.Drawing.Size(250, 104);
    this.panelLogo.TabIndex = 0;
    //
    // button_Dashboard
    //
    this.button_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
    this.button_Dashboard.FlatAppearance.BorderSize = 0;
    this.button_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.button_Dashboard.Font = new System.Drawing.Font(
        "Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.button_Dashboard.ForeColor = System.Drawing.Color.LightGray;
    this.button_Dashboard.Location = new System.Drawing.Point(0, 104);
    this.button_Dashboard.Name = "button_Dashboard";
    this.button_Dashboard.Padding =
        new System.Windows.Forms.Padding(10, 0, 0, 0);
    this.button_Dashboard.Size = new System.Drawing.Size(250, 45);
    this.button_Dashboard.TabIndex = 1;
    this.button_Dashboard.Text = "Dashboard";
    this.button_Dashboard.TextAlign =
        System.Drawing.ContentAlignment.MiddleLeft;
    this.button_Dashboard.UseVisualStyleBackColor = true;
    //
    // button_Patiants
    //
    this.button_Patiants.Dock = System.Windows.Forms.DockStyle.Top;
    this.button_Patiants.FlatAppearance.BorderSize = 0;
    this.button_Patiants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.button_Patiants.Font = new System.Drawing.Font(
        "Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.button_Patiants.ForeColor = System.Drawing.Color.LightGray;
    this.button_Patiants.Location = new System.Drawing.Point(0, 149);
    this.button_Patiants.Name = "button_Patiants";
    this.button_Patiants.Padding =
        new System.Windows.Forms.Padding(10, 0, 0, 0);
    this.button_Patiants.Size = new System.Drawing.Size(250, 45);
    this.button_Patiants.TabIndex = 2;
    this.button_Patiants.Text = "Patients";
    this.button_Patiants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    this.button_Patiants.UseVisualStyleBackColor = true;
    this.button_Patiants.Click +=
        new System.EventHandler(this.buttonPatiants_Click);
    //
    // button_Appoinment
    //
    this.button_Appoinment.Dock = System.Windows.Forms.DockStyle.Top;
    this.button_Appoinment.FlatAppearance.BorderSize = 0;
    this.button_Appoinment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.button_Appoinment.Font = new System.Drawing.Font(
        "Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.button_Appoinment.ForeColor = System.Drawing.Color.LightGray;
    this.button_Appoinment.Location = new System.Drawing.Point(0, 194);
    this.button_Appoinment.Name = "button_Appoinment";
    this.button_Appoinment.Padding =
        new System.Windows.Forms.Padding(10, 0, 0, 0);
    this.button_Appoinment.Size = new System.Drawing.Size(250, 45);
    this.button_Appoinment.TabIndex = 3;
    this.button_Appoinment.Text = "Appointments";
    this.button_Appoinment.TextAlign =
        System.Drawing.ContentAlignment.MiddleLeft;
    this.button_Appoinment.UseVisualStyleBackColor = true;
    //
    // button_Setting
    //
    this.button_Setting.BackColor = System.Drawing.Color.Black;
    this.button_Setting.Dock = System.Windows.Forms.DockStyle.Top;
    this.button_Setting.FlatAppearance.BorderSize = 0;
    this.button_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.button_Setting.Font = new System.Drawing.Font(
        "Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.button_Setting.ForeColor = System.Drawing.Color.LightGray;
    this.button_Setting.Location = new System.Drawing.Point(0, 239);
    this.button_Setting.Name = "button_Setting";
    this.button_Setting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
    this.button_Setting.Size = new System.Drawing.Size(250, 45);
    this.button_Setting.TabIndex = 4;
    this.button_Setting.Text = "Settings";
    this.button_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    this.button_Setting.UseVisualStyleBackColor = false;
    //
    // panel1
    //
    this.panel1.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
    this.panel1.Controls.Add(this.button_Clinic_Program_Subsetting);
    this.panel1.Controls.Add(this.button_Clinic_Setting_Subsetting);
    this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel1.Location = new System.Drawing.Point(0, 284);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(250, 79);
    this.panel1.TabIndex = 5;
    //
    // button_Clinic_Setting_Subsetting
    //
    this.button_Clinic_Setting_Subsetting.Dock =
        System.Windows.Forms.DockStyle.Top;
    this.button_Clinic_Setting_Subsetting.FlatAppearance.BorderSize = 0;
    this.button_Clinic_Setting_Subsetting.FlatStyle =
        System.Windows.Forms.FlatStyle.Flat;
    this.button_Clinic_Setting_Subsetting.Font =
        new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold,
                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.button_Clinic_Setting_Subsetting.ForeColor =
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))),
                                      ((int)(((byte)(224)))),
                                      ((int)(((byte)(224)))));
    this.button_Clinic_Setting_Subsetting.Location =
        new System.Drawing.Point(0, 0);
    this.button_Clinic_Setting_Subsetting.Name =
        "button_Clinic_Setting_Subsetting";
    this.button_Clinic_Setting_Subsetting.Padding =
        new System.Windows.Forms.Padding(35, 0, 0, 0);
    this.button_Clinic_Setting_Subsetting.Size =
        new System.Drawing.Size(250, 40);
    this.button_Clinic_Setting_Subsetting.TabIndex = 0;
    this.button_Clinic_Setting_Subsetting.Text = "Clinic Setting";
    this.button_Clinic_Setting_Subsetting.TextAlign =
        System.Drawing.ContentAlignment.MiddleLeft;
    this.button_Clinic_Setting_Subsetting.UseVisualStyleBackColor = true;
    //
    // button_Clinic_Program_Subsetting
    //
    this.button_Clinic_Program_Subsetting.Dock =
        System.Windows.Forms.DockStyle.Top;
    this.button_Clinic_Program_Subsetting.FlatAppearance.BorderSize = 0;
    this.button_Clinic_Program_Subsetting.FlatStyle =
        System.Windows.Forms.FlatStyle.Flat;
    this.button_Clinic_Program_Subsetting.Font =
        new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold,
                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.button_Clinic_Program_Subsetting.ForeColor =
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))),
                                      ((int)(((byte)(224)))),
                                      ((int)(((byte)(224)))));
    this.button_Clinic_Program_Subsetting.Location =
        new System.Drawing.Point(0, 40);
    this.button_Clinic_Program_Subsetting.Name =
        "button_Clinic_Program_Subsetting";
    this.button_Clinic_Program_Subsetting.Padding =
        new System.Windows.Forms.Padding(35, 0, 0, 0);
    this.button_Clinic_Program_Subsetting.Size =
        new System.Drawing.Size(250, 40);
    this.button_Clinic_Program_Subsetting.TabIndex = 1;
    this.button_Clinic_Program_Subsetting.Text = "Program Clinic";
    this.button_Clinic_Program_Subsetting.TextAlign =
        System.Drawing.ContentAlignment.MiddleLeft;
    this.button_Clinic_Program_Subsetting.UseVisualStyleBackColor = true;
    //
    // button_About
    //
    this.button_About.Dock = System.Windows.Forms.DockStyle.Top;
    this.button_About.FlatAppearance.BorderSize = 0;
    this.button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.button_About.Font = new System.Drawing.Font(
        "Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.button_About.ForeColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
    this.button_About.Location = new System.Drawing.Point(0, 363);
    this.button_About.Name = "button_About";
    this.button_About.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
    this.button_About.Size = new System.Drawing.Size(250, 45);
    this.button_About.TabIndex = 6;
    this.button_About.Text = "About";
    this.button_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    this.button_About.UseVisualStyleBackColor = true;
    //
    // home_page
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(669, 491);
    this.Controls.Add(this.panelSideMenu);
    this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
    this.Name = "home_page";
    this.Text = "Home";
    this.panelSideMenu.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.ResumeLayout(false);

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.adminButton = new System.Windows.Forms.Button();
      this.loginButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      //
      // adminButton
      //
      this.adminButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.adminButton.Location = new System.Drawing.Point(344, 162);
      this.adminButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.adminButton.Name = "adminButton";
      this.adminButton.Size = new System.Drawing.Size(176, 65);
      this.adminButton.TabIndex = 0;
      this.adminButton.Text = "admin";
      this.adminButton.UseVisualStyleBackColor = false;
      //
      // loginButton
      //
      this.loginButton.BackColor = System.Drawing.SystemColors.ControlDark;
      this.loginButton.Location = new System.Drawing.Point(87, 162);
      this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(160, 65);
      this.loginButton.TabIndex = 1;
      this.loginButton.Text = "login";
      this.loginButton.UseVisualStyleBackColor = false;
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
      //
      // home_page
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(686, 366);
      this.Controls.Add(this.loginButton);
      this.Controls.Add(this.adminButton);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "home_page";
      this.Text = "Home";
      this.ResumeLayout(false);
    }

#endregion

    private System.Windows.Forms.Panel panelSideMenu;
    private System.Windows.Forms.Button button_Dashboard;
    private System.Windows.Forms.Panel panelLogo;
    private System.Windows.Forms.Button button_Patiants;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button_Setting;
    private System.Windows.Forms.Button button_Appoinment;
    private System.Windows.Forms.Button button_Clinic_Program_Subsetting;
    private System.Windows.Forms.Button button_Clinic_Setting_Subsetting;
    private System.Windows.Forms.Button button_About;
  }
}
