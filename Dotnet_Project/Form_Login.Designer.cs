namespace Dotnet_Project
{
    partial class Form_Login
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
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(61, 240);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(184, 20);
            this.user_name.TabIndex = 0;
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(61, 284);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(184, 20);
            this.user_password.TabIndex = 0;
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(12, 463);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(124, 23);
            this.btn_download.TabIndex = 1;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(83, 326);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(131, 23);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 498);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Name = "Form_Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btnlogin;
    }
}

