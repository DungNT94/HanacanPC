
namespace HANACANPC._03_Master
{
    partial class frmDesignMaster
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesignMaster));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDesignCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesignName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEANCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesignCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDesignName = new DevExpress.XtraEditors.TextEdit();
            this.txtEANCode = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEANCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(57, 216);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1618, 435);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDesignCode,
            this.colDesignName,
            this.colEANCode,
            this.colImage});
            this.gridView1.DetailHeight = 485;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 32;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator_1);
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // colDesignCode
            // 
            this.colDesignCode.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDesignCode.AppearanceCell.Options.UseFont = true;
            this.colDesignCode.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDesignCode.AppearanceHeader.Options.UseFont = true;
            this.colDesignCode.Caption = "Design Code";
            this.colDesignCode.FieldName = "Code";
            this.colDesignCode.MinWidth = 30;
            this.colDesignCode.Name = "colDesignCode";
            this.colDesignCode.Visible = true;
            this.colDesignCode.VisibleIndex = 1;
            this.colDesignCode.Width = 111;
            // 
            // colDesignName
            // 
            this.colDesignName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDesignName.AppearanceCell.Options.UseFont = true;
            this.colDesignName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDesignName.AppearanceHeader.Options.UseFont = true;
            this.colDesignName.Caption = "Design Name";
            this.colDesignName.FieldName = "Name";
            this.colDesignName.MinWidth = 30;
            this.colDesignName.Name = "colDesignName";
            this.colDesignName.Visible = true;
            this.colDesignName.VisibleIndex = 2;
            this.colDesignName.Width = 111;
            // 
            // colEANCode
            // 
            this.colEANCode.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEANCode.AppearanceCell.Options.UseFont = true;
            this.colEANCode.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEANCode.AppearanceHeader.Options.UseFont = true;
            this.colEANCode.FieldName = "EANCode";
            this.colEANCode.MinWidth = 30;
            this.colEANCode.Name = "colEANCode";
            this.colEANCode.Visible = true;
            this.colEANCode.VisibleIndex = 3;
            this.colEANCode.Width = 111;
            // 
            // colImage
            // 
            this.colImage.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colImage.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colImage.AppearanceCell.Options.UseFont = true;
            this.colImage.AppearanceCell.Options.UseForeColor = true;
            this.colImage.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colImage.AppearanceHeader.Options.UseFont = true;
            this.colImage.Caption = "Image Name";
            this.colImage.FieldName = "ImgLink";
            this.colImage.MinWidth = 30;
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 4;
            this.colImage.Width = 111;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_HANACANS_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "DesignCode";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"123\" />";
            table1.Name = "tbl_DesignMaster";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "DesignName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "EANCode";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Name = "tbl_DesignMaster";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDelete.Image = global::HANACANPC.ResourceImages.DeleteList_16x16;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1440, 114);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 50);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnUpdate.Image = global::HANACANPC.ResourceImages.EditName_16x16;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1263, 114);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 50);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAdd.Image = global::HANACANPC.ResourceImages.Add_16x16;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1090, 112);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(408, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên thiết kế (Design name)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã thiết kế (Design code)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh mục Design (Design Master)";
            // 
            // txtDesignCode
            // 
            this.txtDesignCode.Enabled = false;
            this.txtDesignCode.Location = new System.Drawing.Point(87, 125);
            this.txtDesignCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesignCode.Name = "txtDesignCode";
            this.txtDesignCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDesignCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDesignCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtDesignCode.Properties.Appearance.Options.UseFont = true;
            this.txtDesignCode.Size = new System.Drawing.Size(258, 22);
            this.txtDesignCode.TabIndex = 1;
            // 
            // txtDesignName
            // 
            this.txtDesignName.Enabled = false;
            this.txtDesignName.Location = new System.Drawing.Point(412, 125);
            this.txtDesignName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesignName.Name = "txtDesignName";
            this.txtDesignName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDesignName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDesignName.Properties.Appearance.Options.UseBackColor = true;
            this.txtDesignName.Properties.Appearance.Options.UseFont = true;
            this.txtDesignName.Size = new System.Drawing.Size(258, 22);
            this.txtDesignName.TabIndex = 2;
            // 
            // txtEANCode
            // 
            this.txtEANCode.Enabled = false;
            this.txtEANCode.Location = new System.Drawing.Point(746, 125);
            this.txtEANCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEANCode.Name = "txtEANCode";
            this.txtEANCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEANCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtEANCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtEANCode.Properties.Appearance.Options.UseFont = true;
            this.txtEANCode.Size = new System.Drawing.Size(258, 22);
            this.txtEANCode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(741, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã EAN (EAN code)";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnRefresh.Image = global::HANACANPC.ResourceImages._52352_refresh_icon;
            this.btnRefresh.Location = new System.Drawing.Point(1600, 228);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 44);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmDesignMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 721);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtEANCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesignName);
            this.Controls.Add(this.txtDesignCode);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDesignMaster";
            this.Text = "Design Master";
            this.Load += new System.EventHandler(this.frmDesignMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEANCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignName;
        private DevExpress.XtraGrid.Columns.GridColumn colEANCode;
        private DevExpress.XtraEditors.TextEdit txtDesignCode;
        private DevExpress.XtraEditors.TextEdit txtDesignName;
        private DevExpress.XtraEditors.TextEdit txtEANCode;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private System.Windows.Forms.Button btnRefresh;
    }
}