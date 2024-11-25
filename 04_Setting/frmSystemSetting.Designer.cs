﻿
namespace HANACANPC._04_Setting
{
    partial class frmSystemSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.txtDatabaseName = new DevExpress.XtraEditors.TextEdit();
            this.txtUserDB = new DevExpress.XtraEditors.TextEdit();
            this.txtPassDB = new DevExpress.XtraEditors.TextEdit();
            this.txtPassLogin = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTestConnectDB = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassLogin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(26, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database Information";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(75, 208);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtServerName.Properties.Appearance.Options.UseFont = true;
            this.txtServerName.Size = new System.Drawing.Size(209, 22);
            this.txtServerName.TabIndex = 2;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(395, 269);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDatabaseName.Properties.Appearance.Options.UseFont = true;
            this.txtDatabaseName.Size = new System.Drawing.Size(209, 22);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // txtUserDB
            // 
            this.txtUserDB.Location = new System.Drawing.Point(395, 208);
            this.txtUserDB.Name = "txtUserDB";
            this.txtUserDB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUserDB.Properties.Appearance.Options.UseFont = true;
            this.txtUserDB.Size = new System.Drawing.Size(209, 22);
            this.txtUserDB.TabIndex = 4;
            // 
            // txtPassDB
            // 
            this.txtPassDB.Location = new System.Drawing.Point(75, 269);
            this.txtPassDB.Name = "txtPassDB";
            this.txtPassDB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassDB.Properties.Appearance.Options.UseFont = true;
            this.txtPassDB.Size = new System.Drawing.Size(209, 22);
            this.txtPassDB.TabIndex = 5;
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.Location = new System.Drawing.Point(75, 76);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassLogin.Properties.Appearance.Options.UseFont = true;
            this.txtPassLogin.Size = new System.Drawing.Size(181, 22);
            this.txtPassLogin.TabIndex = 6;
            this.txtPassLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassLogin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(72, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login  password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(72, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server Name/ Server IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(72, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(393, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "User name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(393, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Database name";
            // 
            // btnTestConnectDB
            // 
            this.btnTestConnectDB.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestConnectDB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTestConnectDB.ForeColor = System.Drawing.Color.White;
            this.btnTestConnectDB.Location = new System.Drawing.Point(283, 138);
            this.btnTestConnectDB.Name = "btnTestConnectDB";
            this.btnTestConnectDB.Size = new System.Drawing.Size(110, 39);
            this.btnTestConnectDB.TabIndex = 12;
            this.btnTestConnectDB.Text = "Test Connect";
            this.btnTestConnectDB.UseVisualStyleBackColor = false;
            this.btnTestConnectDB.Click += new System.EventHandler(this.btnTestConnectDB_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(519, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 38);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(395, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 38);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSystemSetting
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 405);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTestConnectDB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassLogin);
            this.Controls.Add(this.txtPassDB);
            this.Controls.Add(this.txtUserDB);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSystemSetting";
            this.Text = "Config Setting (Cấu hình)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSystemSetting_FormClosed);
            this.Load += new System.EventHandler(this.frmSystemSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassLogin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtServerName;
        private DevExpress.XtraEditors.TextEdit txtDatabaseName;
        private DevExpress.XtraEditors.TextEdit txtUserDB;
        private DevExpress.XtraEditors.TextEdit txtPassDB;
        private DevExpress.XtraEditors.TextEdit txtPassLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTestConnectDB;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}