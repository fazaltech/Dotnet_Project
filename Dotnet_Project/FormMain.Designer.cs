﻿namespace Dotnet_Project
{
    partial class FormMain
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(1024, 582);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(904, 582);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(859, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Form Entry Screen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pContainer
            // 
            this.pContainer.AutoScroll = true;
            this.pContainer.AutoSize = true;
            this.pContainer.Location = new System.Drawing.Point(12, 56);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1128, 500);
            this.pContainer.TabIndex = 0;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pContainer;
    }
}