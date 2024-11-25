
namespace HANACANPC._03_Master
{
    partial class frmDesignMasterUPDATE
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtEAN = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDesignName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesignCode = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ImageLink = new System.Windows.Forms.Label();
            this.ImgLink = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtEAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(650, 274);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 44);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete Img";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCheck.Location = new System.Drawing.Point(498, 274);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(124, 44);
            this.btnCheck.TabIndex = 30;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnImport.Location = new System.Drawing.Point(342, 274);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(124, 44);
            this.btnImport.TabIndex = 29;
            this.btnImport.Text = " Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(360, 198);
            this.txtEAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(370, 24);
            this.txtEAN.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(48, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "EAN:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(237, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 57);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnCancel.Location = new System.Drawing.Point(562, 395);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 57);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDesignName
            // 
            this.txtDesignName.Location = new System.Drawing.Point(360, 145);
            this.txtDesignName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesignName.Name = "txtDesignName";
            this.txtDesignName.Size = new System.Drawing.Size(370, 24);
            this.txtDesignName.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(48, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Design name:";
            // 
            // txtDesignCode
            // 
            this.txtDesignCode.Enabled = false;
            this.txtDesignCode.Location = new System.Drawing.Point(360, 94);
            this.txtDesignCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesignCode.Name = "txtDesignCode";
            this.txtDesignCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDesignCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtDesignCode.Size = new System.Drawing.Size(370, 24);
            this.txtDesignCode.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Design code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Design master (Chỉnh sửa thiết kế)";
            // 
            // lbl_ImageLink
            // 
            this.lbl_ImageLink.AutoSize = true;
            this.lbl_ImageLink.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbl_ImageLink.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ImageLink.Location = new System.Drawing.Point(435, 247);
            this.lbl_ImageLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ImageLink.Name = "lbl_ImageLink";
            this.lbl_ImageLink.Size = new System.Drawing.Size(0, 14);
            this.lbl_ImageLink.TabIndex = 33;
            // 
            // ImgLink
            // 
            this.ImgLink.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ImgLink.Appearance.Options.UseFont = true;
            this.ImgLink.Location = new System.Drawing.Point(366, 247);
            this.ImgLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImgLink.Name = "ImgLink";
            this.ImgLink.Size = new System.Drawing.Size(38, 14);
            this.ImgLink.TabIndex = 32;
            this.ImgLink.Text = "Image:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(48, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Image file:";
            // 
            // frmDesignMasterUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ImageLink);
            this.Controls.Add(this.ImgLink);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtEAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDesignName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesignCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDesignMasterUPDATE";
            this.Text = "Design Update";
            this.Load += new System.EventHandler(this.frmDesignMasterUPDATE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnImport;
        private DevExpress.XtraEditors.TextEdit txtEAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.TextEdit txtDesignName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtDesignCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ImageLink;
        private DevExpress.XtraEditors.LabelControl ImgLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
    }
}