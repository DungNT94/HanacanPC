﻿
namespace HANACANPC._00_Login
{
    partial class frmPassSetting
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
            this.btnContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassSetting = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassSetting.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnContinue.Font = new System.Drawing.Font("Arial", 10F);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(125, 51);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(82, 31);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Tiếp theo";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(13, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pass (Mật khẩu)";
            // 
            // txtPassSetting
            // 
            this.txtPassSetting.Location = new System.Drawing.Point(13, 21);
            this.txtPassSetting.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassSetting.Name = "txtPassSetting";
            this.txtPassSetting.Properties.PasswordChar = '*';
            this.txtPassSetting.Size = new System.Drawing.Size(194, 24);
            this.txtPassSetting.TabIndex = 2;
            this.txtPassSetting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassSetting_KeyDown);
            // 
            // frmPassSetting
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(220, 95);
            this.Controls.Add(this.txtPassSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPassSetting";
            this.Load += new System.EventHandler(this.frmPassSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassSetting.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtPassSetting;
    }
}