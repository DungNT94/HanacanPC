
namespace HANACANPC._01_LogData
{
    partial class frmErrorResorting
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewErrorResorting = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportCSVError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewErrorResorting)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Font = new System.Drawing.Font("Arial", 12F);
            this.gridControl2.Location = new System.Drawing.Point(28, 11);
            this.gridControl2.MainView = this.gridViewErrorResorting;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1123, 506);
            this.gridControl2.TabIndex = 25;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewErrorResorting});
            // 
            // gridViewErrorResorting
            // 
            this.gridViewErrorResorting.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 13F);
            this.gridViewErrorResorting.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewErrorResorting.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 13F);
            this.gridViewErrorResorting.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewErrorResorting.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewErrorResorting.DetailHeight = 485;
            this.gridViewErrorResorting.FixedLineWidth = 3;
            this.gridViewErrorResorting.GridControl = this.gridControl2;
            this.gridViewErrorResorting.Name = "gridViewErrorResorting";
            this.gridViewErrorResorting.OptionsBehavior.Editable = false;
            this.gridViewErrorResorting.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewErrorResorting.OptionsView.ShowGroupPanel = false;
            this.gridViewErrorResorting.RowHeight = 32;
            this.gridViewErrorResorting.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewErrorCompensation_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Arial", 13F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 13F);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Each time";
            this.gridColumn1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "ErrorTime";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 240;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Arial", 13F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 13F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Original ticket QR";
            this.gridColumn2.FieldName = "OriginTicketQR";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 598;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Arial", 13F);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Arial", 13F);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Mistake ticket QR";
            this.gridColumn3.FieldName = "MistakeTicketQR";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 960;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1003, 538);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 51);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "CLOSE";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExportCSVError
            // 
            this.btnExportCSVError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSVError.BackColor = System.Drawing.Color.Green;
            this.btnExportCSVError.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnExportCSVError.ForeColor = System.Drawing.Color.White;
            this.btnExportCSVError.Location = new System.Drawing.Point(833, 538);
            this.btnExportCSVError.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportCSVError.Name = "btnExportCSVError";
            this.btnExportCSVError.Size = new System.Drawing.Size(142, 51);
            this.btnExportCSVError.TabIndex = 41;
            this.btnExportCSVError.Text = "CSV Export Error";
            this.btnExportCSVError.UseVisualStyleBackColor = false;
            this.btnExportCSVError.Click += new System.EventHandler(this.btnExportCSVError_Click);
            // 
            // frmErrorResorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1183, 598);
            this.Controls.Add(this.btnExportCSVError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gridControl2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmErrorResorting";
            this.Text = "Danh sách lỗi Resorting (Error Resorting)";
            this.Load += new System.EventHandler(this.frmErrorResorting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewErrorResorting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewErrorResorting;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportCSVError;
    }
}