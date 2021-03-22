namespace Dotnet_Project
{
    partial class Form_Data
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_weight = new System.Windows.Forms.MaskedTextBox();
            this.text_height = new System.Windows.Forms.MaskedTextBox();
            this.text_mauc = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_gender2 = new System.Windows.Forms.RadioButton();
            this.radio_gender1 = new System.Windows.Forms.RadioButton();
            this.dateTime_dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.text_fathername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_childname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_weight);
            this.groupBox1.Controls.Add(this.text_height);
            this.groupBox1.Controls.Add(this.text_mauc);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTime_dob);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_fathername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_childname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(30, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FORM";
            // 
            // text_weight
            // 
            this.text_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_weight.Location = new System.Drawing.Point(129, 299);
            this.text_weight.Mask = "00.0";
            this.text_weight.Name = "text_weight";
            this.text_weight.Size = new System.Drawing.Size(150, 24);
            this.text_weight.TabIndex = 7;
            // 
            // text_height
            // 
            this.text_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_height.Location = new System.Drawing.Point(129, 264);
            this.text_height.Mask = "000.0";
            this.text_height.Name = "text_height";
            this.text_height.Size = new System.Drawing.Size(150, 24);
            this.text_height.TabIndex = 6;
            // 
            // text_mauc
            // 
            this.text_mauc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mauc.Location = new System.Drawing.Point(129, 231);
            this.text_mauc.Mask = "00.0";
            this.text_mauc.Name = "text_mauc";
            this.text_mauc.Size = new System.Drawing.Size(150, 24);
            this.text_mauc.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_gender2);
            this.groupBox2.Controls.Add(this.radio_gender1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(129, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 31);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // radio_gender2
            // 
            this.radio_gender2.AutoSize = true;
            this.radio_gender2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio_gender2.Location = new System.Drawing.Point(98, 8);
            this.radio_gender2.Name = "radio_gender2";
            this.radio_gender2.Size = new System.Drawing.Size(59, 17);
            this.radio_gender2.TabIndex = 4;
            this.radio_gender2.TabStop = true;
            this.radio_gender2.Text = "Female";
            this.radio_gender2.UseVisualStyleBackColor = true;
            // 
            // radio_gender1
            // 
            this.radio_gender1.AutoSize = true;
            this.radio_gender1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio_gender1.Location = new System.Drawing.Point(7, 8);
            this.radio_gender1.Name = "radio_gender1";
            this.radio_gender1.Size = new System.Drawing.Size(48, 17);
            this.radio_gender1.TabIndex = 3;
            this.radio_gender1.TabStop = true;
            this.radio_gender1.Text = "Male";
            this.radio_gender1.UseVisualStyleBackColor = true;
            // 
            // dateTime_dob
            // 
            this.dateTime_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_dob.Location = new System.Drawing.Point(132, 148);
            this.dateTime_dob.Name = "dateTime_dob";
            this.dateTime_dob.Size = new System.Drawing.Size(164, 22);
            this.dateTime_dob.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(31, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Weight";
            // 
            // text_fathername
            // 
            this.text_fathername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_fathername.Location = new System.Drawing.Point(132, 107);
            this.text_fathername.MaxLength = 15;
            this.text_fathername.Name = "text_fathername";
            this.text_fathername.Size = new System.Drawing.Size(164, 22);
            this.text_fathername.TabIndex = 1;
            this.text_fathername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_fathername_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(31, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(31, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "MAUC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Father Name";
            // 
            // text_childname
            // 
            this.text_childname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_childname.Location = new System.Drawing.Point(132, 66);
            this.text_childname.MaxLength = 15;
            this.text_childname.Name = "text_childname";
            this.text_childname.Size = new System.Drawing.Size(164, 22);
            this.text_childname.TabIndex = 0;
            this.text_childname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_childname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Child Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(192, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(43, 526);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(171, 23);
            this.btn_data.TabIndex = 9;
            this.btn_data.Text = "Show Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Visible = false;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(220, 526);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(171, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close Form";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 592);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_gender2;
        private System.Windows.Forms.RadioButton radio_gender1;
        private System.Windows.Forms.DateTimePicker dateTime_dob;
        private System.Windows.Forms.TextBox text_fathername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_childname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox text_mauc;
        private System.Windows.Forms.MaskedTextBox text_weight;
        private System.Windows.Forms.MaskedTextBox text_height;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Button btn_close;
    }
}