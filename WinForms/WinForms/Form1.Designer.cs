﻿
namespace WinForms
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
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnFeatureA1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaster
            // 
            this.btnMaster.Location = new System.Drawing.Point(266, 12);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(286, 143);
            this.btnMaster.TabIndex = 0;
            this.btnMaster.Text = "Master";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFeatureA1
            // 
            this.btnFeatureA1.Location = new System.Drawing.Point(266, 161);
            this.btnFeatureA1.Name = "btnFeatureA1";
            this.btnFeatureA1.Size = new System.Drawing.Size(286, 143);
            this.btnFeatureA1.TabIndex = 1;
            this.btnFeatureA1.Text = "Feature A 1";
            this.btnFeatureA1.UseVisualStyleBackColor = true;
            this.btnFeatureA1.Click += new System.EventHandler(this.btnFeatureA1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 723);
            this.Controls.Add(this.btnFeatureA1);
            this.Controls.Add(this.btnMaster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnFeatureA1;
    }
}

