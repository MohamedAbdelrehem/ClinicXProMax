
namespace Clinic_Mang_Sys
{
    partial class Form2
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
            this.adminButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminButton.Location = new System.Drawing.Point(177, 92);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(205, 80);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "admin";
            this.adminButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginButton.Location = new System.Drawing.Point(387, 240);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(187, 80);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.adminButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button loginButton;
    }
}