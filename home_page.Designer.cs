
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

#region Windows Form Designer generated code

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

  private System.Windows.Forms.Button adminButton;
  private System.Windows.Forms.Button loginButton;
}
}