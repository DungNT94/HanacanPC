﻿
namespace HANACANPC._03_Master
{
    partial class frmDesignMasterADD
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
            this.btnImport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEAN = new DevExpress.XtraEditors.TextEdit();
            this.txtDesignName = new DevExpress.XtraEditors.TextEdit();
            this.txtDesignCode = new DevExpress.XtraEditors.TextEdit();
            this.ImgLink = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ImageLink = new System.Windows.Forms.Label();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtEAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImport.FlatAppearance.BorderSize = 10;
            this.btnImport.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnImport.Location = new System.Drawing.Point(223, 206);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(83, 34);
            this.btnImport.TabIndex = 29;
            this.btnImport.Text = " Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(30, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "EAN code:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAdd.Location = new System.Drawing.Point(156, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 44);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnCancel.Location = new System.Drawing.Point(384, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 44);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Design name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Design code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Design master (Thêm thông tin thiết kế)";
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(223, 153);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(247, 20);
            this.txtEAN.TabIndex = 28;
            // 
            // txtDesignName
            // 
            this.txtDesignName.Location = new System.Drawing.Point(223, 112);
            this.txtDesignName.Name = "txtDesignName";
            this.txtDesignName.Size = new System.Drawing.Size(247, 20);
            this.txtDesignName.TabIndex = 24;
            // 
            // txtDesignCode
            // 
            this.txtDesignCode.Location = new System.Drawing.Point(223, 72);
            this.txtDesignCode.Name = "txtDesignCode";
            this.txtDesignCode.Size = new System.Drawing.Size(247, 20);
            this.txtDesignCode.TabIndex = 22;
            // 
            // ImgLink
            // 
            this.ImgLink.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ImgLink.Appearance.Options.UseFont = true;
            this.ImgLink.Location = new System.Drawing.Point(223, 184);
            this.ImgLink.Name = "ImgLink";
            this.ImgLink.Size = new System.Drawing.Size(38, 14);
            this.ImgLink.TabIndex = 30;
            this.ImgLink.Text = "Image:";
            // 
            // lbl_ImageLink
            // 
            this.lbl_ImageLink.AutoSize = true;
            this.lbl_ImageLink.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbl_ImageLink.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ImageLink.Location = new System.Drawing.Point(268, 184);
            this.lbl_ImageLink.Name = "lbl_ImageLink";
            this.lbl_ImageLink.Size = new System.Drawing.Size(0, 14);
            this.lbl_ImageLink.TabIndex = 31;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteImage.FlatAppearance.BorderSize = 10;
            this.btnDeleteImage.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDeleteImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.Location = new System.Drawing.Point(312, 206);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteImage.TabIndex = 32;
            this.btnDeleteImage.Text = "Delete";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(30, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Image file:";
            // 
            // frmDesignMasterADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 359);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.lbl_ImageLink);
            this.Controls.Add(this.ImgLink);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtEAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDesignName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesignCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDesignMasterADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.txtEAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImport;
        private DevExpress.XtraEditors.TextEdit txtEAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.TextEdit txtDesignName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtDesignCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl ImgLink;
        private System.Windows.Forms.Label lbl_ImageLink;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Label label5;
    }
}