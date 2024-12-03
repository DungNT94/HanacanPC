
namespace HANACANPC._03_Master
{
    partial class frmLocationMaster
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocationMaster));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManagementCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecurityBoxIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTierType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLocationName = new DevExpress.XtraEditors.TextEdit();
            this.txtManagementCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecurityAddress = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOneTier = new System.Windows.Forms.RadioButton();
            this.rdoTwoTier = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManagementCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecurityAddress.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(23, 226);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1226, 486);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManagementCode,
            this.colLocationName,
            this.colSecurityBoxIP,
            this.colTierType});
            this.gridView1.DetailHeight = 485;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 32;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colManagementCode
            // 
            this.colManagementCode.AppearanceCell.Font = new System.Drawing.Font("Arial", 11F);
            this.colManagementCode.AppearanceCell.Options.UseFont = true;
            this.colManagementCode.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F);
            this.colManagementCode.AppearanceHeader.Options.UseFont = true;
            this.colManagementCode.Caption = "Management Code (Mã quản lý)";
            this.colManagementCode.FieldName = "Code";
            this.colManagementCode.MinWidth = 30;
            this.colManagementCode.Name = "colManagementCode";
            this.colManagementCode.Visible = true;
            this.colManagementCode.VisibleIndex = 1;
            this.colManagementCode.Width = 112;
            // 
            // colLocationName
            // 
            this.colLocationName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11F);
            this.colLocationName.AppearanceCell.Options.UseFont = true;
            this.colLocationName.AppearanceCell.Options.UseTextOptions = true;
            this.colLocationName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLocationName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F);
            this.colLocationName.AppearanceHeader.Options.UseFont = true;
            this.colLocationName.Caption = "Location Name (Tên vị trí)";
            this.colLocationName.FieldName = "Location";
            this.colLocationName.MinWidth = 30;
            this.colLocationName.Name = "colLocationName";
            this.colLocationName.Visible = true;
            this.colLocationName.VisibleIndex = 2;
            this.colLocationName.Width = 112;
            // 
            // colSecurityBoxIP
            // 
            this.colSecurityBoxIP.AppearanceCell.Font = new System.Drawing.Font("Arial", 11F);
            this.colSecurityBoxIP.AppearanceCell.Options.UseFont = true;
            this.colSecurityBoxIP.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F);
            this.colSecurityBoxIP.AppearanceHeader.Options.UseFont = true;
            this.colSecurityBoxIP.Caption = "Security Box IP (IP Bảo mật)";
            this.colSecurityBoxIP.FieldName = "SecurityAddress";
            this.colSecurityBoxIP.MinWidth = 30;
            this.colSecurityBoxIP.Name = "colSecurityBoxIP";
            this.colSecurityBoxIP.Visible = true;
            this.colSecurityBoxIP.VisibleIndex = 3;
            this.colSecurityBoxIP.Width = 112;
            // 
            // colTierType
            // 
            this.colTierType.AppearanceCell.Font = new System.Drawing.Font("Arial", 11F);
            this.colTierType.AppearanceCell.Options.UseFont = true;
            this.colTierType.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F);
            this.colTierType.AppearanceHeader.Options.UseFont = true;
            this.colTierType.Caption = "Tier Type";
            this.colTierType.FieldName = "TierType";
            this.colTierType.Name = "colTierType";
            this.colTierType.Visible = true;
            this.colTierType.VisibleIndex = 4;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_HANACANS_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression5.ColumnName = "ManagementCode";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"143\" />";
            table2.Name = "tbl_LocationMaster";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "LocationName";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "WarningLightIP";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "SecurityBoxIP";
            columnExpression8.Table = table2;
            column8.Expression = columnExpression8;
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
            selectQuery2.Name = "tbl_LocationMaster";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDelete.Image = global::HANACANPC.ResourceImages.DeleteList_16x16;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1150, 165);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 37);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnUpdate.Image = global::HANACANPC.ResourceImages.EditName_16x16;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1034, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 37);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAdd.Image = global::HANACANPC.ResourceImages.Add_16x16;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(917, 165);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh mục Vị trí/Ngăn/Hộp (Location/Drawer/Case Master)\r\n";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ManagementCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "ManagementCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "LocationName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "WarningLightIP";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "SecurityBoxIP";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(334, 79);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtLocationName.Properties.Appearance.Options.UseFont = true;
            this.txtLocationName.Size = new System.Drawing.Size(259, 22);
            this.txtLocationName.TabIndex = 1;
            // 
            // txtManagementCode
            // 
            this.txtManagementCode.Location = new System.Drawing.Point(41, 79);
            this.txtManagementCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagementCode.Name = "txtManagementCode";
            this.txtManagementCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtManagementCode.Properties.Appearance.Options.UseFont = true;
            this.txtManagementCode.Size = new System.Drawing.Size(259, 22);
            this.txtManagementCode.TabIndex = 0;
            this.txtManagementCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManagementCode_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(336, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên vị trí (Location name)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(43, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã quản lý (Management code)";
            // 
            // txtSecurityAddress
            // 
            this.txtSecurityAddress.Location = new System.Drawing.Point(628, 79);
            this.txtSecurityAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecurityAddress.Name = "txtSecurityAddress";
            this.txtSecurityAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSecurityAddress.Properties.Appearance.Options.UseFont = true;
            this.txtSecurityAddress.Size = new System.Drawing.Size(259, 22);
            this.txtSecurityAddress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(630, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Địa chỉ hộp (Security Box IP)";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnRefresh.Image = global::HANACANPC.ResourceImages._52352_refresh_icon;
            this.btnRefresh.Location = new System.Drawing.Point(1180, 230);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(48, 36);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.rdoOneTier);
            this.groupBox1.Controls.Add(this.rdoTwoTier);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.groupBox1.Location = new System.Drawing.Point(41, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 94);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // rdoOneTier
            // 
            this.rdoOneTier.AutoSize = true;
            this.rdoOneTier.Font = new System.Drawing.Font("Arial", 10F);
            this.rdoOneTier.Location = new System.Drawing.Point(23, 57);
            this.rdoOneTier.Name = "rdoOneTier";
            this.rdoOneTier.Size = new System.Drawing.Size(495, 20);
            this.rdoOneTier.TabIndex = 57;
            this.rdoOneTier.TabStop = true;
            this.rdoOneTier.Text = "Two tier type     Lower tiers || One tier type (Tầng dưới hoặc loại một tầng) ";
            this.rdoOneTier.UseVisualStyleBackColor = true;
            // 
            // rdoTwoTier
            // 
            this.rdoTwoTier.AutoSize = true;
            this.rdoTwoTier.Font = new System.Drawing.Font("Arial", 10F);
            this.rdoTwoTier.Location = new System.Drawing.Point(23, 26);
            this.rdoTwoTier.Name = "rdoTwoTier";
            this.rdoTwoTier.Size = new System.Drawing.Size(365, 20);
            this.rdoTwoTier.TabIndex = 56;
            this.rdoTwoTier.TabStop = true;
            this.rdoTwoTier.Text = "Two tier type     Upper tiers (Loại hai tầng: Tầng trên) ";
            this.rdoTwoTier.UseVisualStyleBackColor = true;
            // 
            // frmLocationMaster
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1278, 736);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSecurityAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.txtManagementCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLocationMaster";
            this.Text = "Location Master";
            this.Load += new System.EventHandler(this.frmLocationMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManagementCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecurityAddress.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colManagementCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationName;
        private DevExpress.XtraGrid.Columns.GridColumn colSecurityBoxIP;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit txtLocationName;
        private DevExpress.XtraEditors.TextEdit txtManagementCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSecurityAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colTierType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOneTier;
        private System.Windows.Forms.RadioButton rdoTwoTier;
    }
}