﻿namespace ftp_client
{
    partial class FTPClientForm
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
            this.FTPClientLB = new System.Windows.Forms.Label();
            this.IPServerLB = new System.Windows.Forms.Label();
            this.UsernameLB = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.IPServerTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.fileListLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // FTPClientLB
            // 
            this.FTPClientLB.AutoSize = true;
            this.FTPClientLB.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPClientLB.Location = new System.Drawing.Point(298, 9);
            this.FTPClientLB.Name = "FTPClientLB";
            this.FTPClientLB.Size = new System.Drawing.Size(153, 38);
            this.FTPClientLB.TabIndex = 0;
            this.FTPClientLB.Text = "FTP Client";
            // 
            // IPServerLB
            // 
            this.IPServerLB.AutoSize = true;
            this.IPServerLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPServerLB.Location = new System.Drawing.Point(41, 59);
            this.IPServerLB.Name = "IPServerLB";
            this.IPServerLB.Size = new System.Drawing.Size(129, 28);
            this.IPServerLB.TabIndex = 1;
            this.IPServerLB.Text = "IP FTP Server";
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLB.Location = new System.Drawing.Point(41, 108);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(103, 28);
            this.UsernameLB.TabIndex = 2;
            this.UsernameLB.Text = "Username";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLB.Location = new System.Drawing.Point(41, 158);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(96, 28);
            this.PasswordLB.TabIndex = 3;
            this.PasswordLB.Text = "Password";
            // 
            // IPServerTB
            // 
            this.IPServerTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.IPServerTB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPServerTB.Location = new System.Drawing.Point(192, 56);
            this.IPServerTB.Name = "IPServerTB";
            this.IPServerTB.Size = new System.Drawing.Size(300, 34);
            this.IPServerTB.TabIndex = 4;
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.UsernameTB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.Location = new System.Drawing.Point(192, 108);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(300, 34);
            this.UsernameTB.TabIndex = 5;
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(192, 158);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(300, 34);
            this.PasswordTB.TabIndex = 6;
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.UploadBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBtn.ForeColor = System.Drawing.Color.Crimson;
            this.UploadBtn.Location = new System.Drawing.Point(541, 55);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(205, 35);
            this.UploadBtn.TabIndex = 7;
            this.UploadBtn.Text = "UPLOAD FILE";
            this.UploadBtn.UseVisualStyleBackColor = false;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.DownloadBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.ForeColor = System.Drawing.Color.Crimson;
            this.DownloadBtn.Location = new System.Drawing.Point(541, 108);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(205, 35);
            this.DownloadBtn.TabIndex = 8;
            this.DownloadBtn.Text = "DOWNLOAD FILE";
            this.DownloadBtn.UseVisualStyleBackColor = false;
            // 
            // fileListLV
            // 
            this.fileListLV.BackColor = System.Drawing.Color.LavenderBlush;
            this.fileListLV.HideSelection = false;
            this.fileListLV.Location = new System.Drawing.Point(46, 210);
            this.fileListLV.Name = "fileListLV";
            this.fileListLV.Size = new System.Drawing.Size(700, 228);
            this.fileListLV.TabIndex = 9;
            this.fileListLV.UseCompatibleStateImageBehavior = false;
            // 
            // FTPClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileListLV);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.IPServerTB);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.UsernameLB);
            this.Controls.Add(this.IPServerLB);
            this.Controls.Add(this.FTPClientLB);
            this.Name = "FTPClientForm";
            this.Text = "FTPClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FTPClientLB;
        private System.Windows.Forms.Label IPServerLB;
        private System.Windows.Forms.Label UsernameLB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.TextBox IPServerTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.ListView fileListLV;
    }
}