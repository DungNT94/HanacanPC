
namespace HANACANPC._03_Master
{
    partial class frmMasterMaintenance
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
            this.btnUserMaster = new System.Windows.Forms.Button();
            this.btnDesignMaster = new System.Windows.Forms.Button();
            this.btnLocationMaster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserMaster
            // 
            this.btnUserMaster.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnUserMaster.Location = new System.Drawing.Point(45, 58);
            this.btnUserMaster.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserMaster.Name = "btnUserMaster";
            this.btnUserMaster.Size = new System.Drawing.Size(812, 71);
            this.btnUserMaster.TabIndex = 0;
            this.btnUserMaster.Text = "Danh mục người dùng (User master)";
            this.btnUserMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserMaster.UseVisualStyleBackColor = true;
            this.btnUserMaster.Click += new System.EventHandler(this.btnUserMaster_Click);
            // 
            // btnDesignMaster
            // 
            this.btnDesignMaster.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDesignMaster.Location = new System.Drawing.Point(45, 172);
            this.btnDesignMaster.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesignMaster.Name = "btnDesignMaster";
            this.btnDesignMaster.Size = new System.Drawing.Size(812, 71);
            this.btnDesignMaster.TabIndex = 1;
            this.btnDesignMaster.Text = "Danh mục thiết kế (Design master)";
            this.btnDesignMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesignMaster.UseVisualStyleBackColor = true;
            this.btnDesignMaster.Click += new System.EventHandler(this.btnDesignMaster_Click);
            // 
            // btnLocationMaster
            // 
            this.btnLocationMaster.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnLocationMaster.Location = new System.Drawing.Point(45, 294);
            this.btnLocationMaster.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocationMaster.Name = "btnLocationMaster";
            this.btnLocationMaster.Size = new System.Drawing.Size(812, 71);
            this.btnLocationMaster.TabIndex = 2;
            this.btnLocationMaster.Text = "Danh mục Vị trí/Ngăn kéo/Hộp (Location/Drawer/Case master)";
            this.btnLocationMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocationMaster.UseVisualStyleBackColor = true;
            this.btnLocationMaster.Click += new System.EventHandler(this.btnLocationMaster_Click);
            // 
            // frmMasterMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1378, 690);
            this.Controls.Add(this.btnLocationMaster);
            this.Controls.Add(this.btnDesignMaster);
            this.Controls.Add(this.btnUserMaster);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMasterMaintenance";
            this.Text = "Master Maintenance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserMaster;
        private System.Windows.Forms.Button btnDesignMaster;
        private System.Windows.Forms.Button btnLocationMaster;
    }
}