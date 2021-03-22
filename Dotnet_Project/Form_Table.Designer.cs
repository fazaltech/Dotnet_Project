namespace Dotnet_Project
{
    partial class Form_Table
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
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_users = new System.Windows.Forms.RadioButton();
            this.btn_form = new System.Windows.Forms.RadioButton();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(42, 108);
            this.data_grid.Name = "data_grid";
            this.data_grid.Size = new System.Drawing.Size(704, 184);
            this.data_grid.TabIndex = 1;
            this.data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_users);
            this.groupBox1.Controls.Add(this.btn_form);
            this.groupBox1.Location = new System.Drawing.Point(42, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Table";
            // 
            // btn_users
            // 
            this.btn_users.AutoSize = true;
            this.btn_users.Location = new System.Drawing.Point(67, 20);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(52, 17);
            this.btn_users.TabIndex = 1;
            this.btn_users.TabStop = true;
            this.btn_users.Text = "Users";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_form
            // 
            this.btn_form.AutoSize = true;
            this.btn_form.Location = new System.Drawing.Point(7, 20);
            this.btn_form.Name = "btn_form";
            this.btn_form.Size = new System.Drawing.Size(53, 17);
            this.btn_form.TabIndex = 0;
            this.btn_form.TabStop = true;
            this.btn_form.Text = "Forms";
            this.btn_form.UseVisualStyleBackColor = true;
            this.btn_form.Click += new System.EventHandler(this.btn_form_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(49, 358);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(151, 33);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close Form";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_grid);
            this.Name = "Form_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Table";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_form;
        private System.Windows.Forms.RadioButton btn_users;
        private System.Windows.Forms.Button btn_close;
    }
}