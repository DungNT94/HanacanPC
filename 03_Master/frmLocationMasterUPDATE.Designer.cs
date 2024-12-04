
namespace HANACANPC._03_Master
{
    partial class frmLocationMasterUPDATE
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
            this.txtSecurityBoxIP = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLocationName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManagementCode = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOneTier = new System.Windows.Forms.RadioButton();
            this.rdoTwoTier = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecurityBoxIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManagementCode.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSecurityBoxIP
            // 
            this.txtSecurityBoxIP.Location = new System.Drawing.Point(299, 183);
            this.txtSecurityBoxIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecurityBoxIP.Name = "txtSecurityBoxIP";
            this.txtSecurityBoxIP.Size = new System.Drawing.Size(287, 24);
            this.txtSecurityBoxIP.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(47, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Security box IP address";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(140, 368);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 57);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnCancel.Location = new System.Drawing.Point(387, 368);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 57);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(299, 140);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(287, 24);
            this.txtLocationName.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(48, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Loaction name:";
            // 
            // txtManagementCode
            // 
            this.txtManagementCode.Enabled = false;
            this.txtManagementCode.Location = new System.Drawing.Point(299, 97);
            this.txtManagementCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagementCode.Name = "txtManagementCode";
            this.txtManagementCode.Size = new System.Drawing.Size(287, 24);
            this.txtManagementCode.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Management code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 54);
            this.label1.TabIndex = 42;
            this.label1.Text = "Edit location/Drawer/Case master\r\n(Sửa Vị trí/Ngăn/Hộp)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOneTier);
            this.groupBox1.Controls.Add(this.rdoTwoTier);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.Location = new System.Drawing.Point(41, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 100);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tier type";
            // 
            // rdoOneTier
            // 
            this.rdoOneTier.AutoSize = true;
            this.rdoOneTier.Font = new System.Drawing.Font("Arial", 9.5F);
            this.rdoOneTier.Location = new System.Drawing.Point(22, 51);
            this.rdoOneTier.Name = "rdoOneTier";
            this.rdoOneTier.Size = new System.Drawing.Size(454, 20);
            this.rdoOneTier.TabIndex = 57;
            this.rdoOneTier.TabStop = true;
            this.rdoOneTier.Text = "Two tier type    Lower tiers || One tier type (Tầng dưới hoặc loại một tầng) ";
            this.rdoOneTier.UseVisualStyleBackColor = true;
            // 
            // rdoTwoTier
            // 
            this.rdoTwoTier.AutoSize = true;
            this.rdoTwoTier.Font = new System.Drawing.Font("Arial", 9.5F);
            this.rdoTwoTier.Location = new System.Drawing.Point(22, 25);
            this.rdoTwoTier.Name = "rdoTwoTier";
            this.rdoTwoTier.Size = new System.Drawing.Size(330, 20);
            this.rdoTwoTier.TabIndex = 56;
            this.rdoTwoTier.TabStop = true;
            this.rdoTwoTier.Text = "Two tier type    Upper tiers (Loại hai tầng: Tầng trên) ";
            this.rdoTwoTier.UseVisualStyleBackColor = true;
            // 
            // frmLocationMasterUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(699, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSecurityBoxIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManagementCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLocationMasterUPDATE";
            this.Text = "Location Update";
            this.Load += new System.EventHandler(this.frmLocationMasterUPDATE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSecurityBoxIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManagementCode.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSecurityBoxIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.TextEdit txtLocationName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtManagementCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOneTier;
        private System.Windows.Forms.RadioButton rdoTwoTier;
    }
}