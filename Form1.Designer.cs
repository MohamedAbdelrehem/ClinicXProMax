﻿
namespace Clinic_Mang_Sys
{
    partial class Form1
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
            this.Close = new System.Windows.Forms.Button();
            this.Minmize = new System.Windows.Forms.Button();
            this.HomePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close.Location = new System.Drawing.Point(378, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 28);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = false;
            // 
            // Minmize
            // 
            this.Minmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.HomePage.Location = new System.Drawing.Point(139, 228);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(112, 38);
            this.HomePage.TabIndex = 2;
            this.HomePage.Text = "button1";
            this.HomePage.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(428, 309);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.Minmize);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minmize;
        private System.Windows.Forms.Button HomePage;
    }
}

