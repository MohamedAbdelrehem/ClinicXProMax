
namespace Clinic_Mang_Sys {
partial class login_page {
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
        this.Exit = new System.Windows.Forms.Button();
        this.Minmize = new System.Windows.Forms.Button();
        this.HomePage = new System.Windows.Forms.Button();
        this.formLogo = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // Exit
        //
        this.Exit.BackColor = System.Drawing.Color.Red;
        this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
        this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.Exit.Location = new System.Drawing.Point(378, 12);
        this.Exit.Name = "Exit";
        this.Exit.Size = new System.Drawing.Size(30, 28);
        this.Exit.TabIndex = 0;
        this.Exit.UseVisualStyleBackColor = false;
        //
        // Minmize
        //
        this.Minmize.BackColor = System.Drawing.Color.FromArgb(
                                     ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        this.Minmize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.Minmize.Location = new System.Drawing.Point(342, 12);
        this.Minmize.Name = "Minmize";
        this.Minmize.Size = new System.Drawing.Size(30, 28);
        this.Minmize.TabIndex = 1;
        this.Minmize.UseVisualStyleBackColor = false;
        //
        // HomePage
        //
        this.HomePage.BackColor = System.Drawing.Color.Green;
        this.HomePage.Location = new System.Drawing.Point(134, 244);
        this.HomePage.Name = "HomePage";
        this.HomePage.Size = new System.Drawing.Size(112, 38);
        this.HomePage.TabIndex = 2;
        this.HomePage.Text = "button1";
        this.HomePage.UseVisualStyleBackColor = false;
        //
        // formLogo
        //
        this.formLogo.AutoSize = true;
        this.formLogo.Location = new System.Drawing.Point(25, 21);
        this.formLogo.Name = "formLogo";
        this.formLogo.Size = new System.Drawing.Size(64, 13);
        this.formLogo.TabIndex = 3;
        this.formLogo.Text = "DoctorPage";
        //
        // login_page
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(
                             ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        this.ClientSize = new System.Drawing.Size(428, 309);
        this.Controls.Add(this.formLogo);
        this.Controls.Add(this.HomePage);
        this.Controls.Add(this.Minmize);
        this.Controls.Add(this.Exit);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "login_page";
        this.Text = "Login";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button Exit;
    private System.Windows.Forms.Button Minmize;
    private System.Windows.Forms.Button HomePage;
    private System.Windows.Forms.Label formLogo;
}
}
