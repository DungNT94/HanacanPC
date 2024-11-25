
namespace HANACANPC._01_LogData
{
    partial class frmCompensationLog
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewCompensation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtErrorEnd = new DevExpress.XtraEditors.TextEdit();
            this.txtErrorStart = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateWorkTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.txtDateWorkTimeStart = new System.Windows.Forms.DateTimePicker();
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.txtDesignCode = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExportCSVMain = new System.Windows.Forms.Button();
            this.btnExportCSVError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompensation)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorStart.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(602, 29);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Danh sách compensation (Compensation log data)";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.Location = new System.Drawing.Point(48, 275);
            this.gridControl2.MainView = this.gridViewCompensation;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1768, 558);
            this.gridControl2.TabIndex = 8;
            this.gridControl2.TabStop = false;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompensation});
            // 
            // gridViewCompensation
            // 
            this.gridViewCompensation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridViewCompensation.DetailHeight = 485;
            this.gridViewCompensation.FixedLineWidth = 3;
            this.gridViewCompensation.GridControl = this.gridControl2;
            this.gridViewCompensation.Name = "gridViewCompensation";
            this.gridViewCompensation.OptionsBehavior.Editable = false;
            this.gridViewCompensation.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewCompensation.OptionsView.ShowGroupPanel = false;
            this.gridViewCompensation.RowHeight = 32;
            this.gridViewCompensation.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewCompensation_RowCellClick);
            this.gridViewCompensation.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewCompensation_CustomDrawRowIndicator);
            this.gridViewCompensation.Click += new System.EventHandler(this.gridViewCompensation_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Work Time";
            this.gridColumn1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "WorkingTime";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 172;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Last Update Time";
            this.gridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss tt";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "UpdateTime";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 172;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Drawer/CaseNo";
            this.gridColumn3.FieldName = "CaseNo";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 172;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Location";
            this.gridColumn4.FieldName = "Location";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 172;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "TicketQR";
            this.gridColumn5.FieldName = "TicketQR";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 172;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Design Code";
            this.gridColumn6.FieldName = "DesignCode";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 172;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Design Name";
            this.gridColumn7.FieldName = "DesginName";
            this.gridColumn7.MinWidth = 30;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 172;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Compensation Count";
            this.gridColumn8.FieldName = "CompensionCount";
            this.gridColumn8.MinWidth = 30;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 181;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn9.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.gridColumn9.AppearanceCell.Options.UseFont = true;
            this.gridColumn9.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Error Count";
            this.gridColumn9.FieldName = "WrongCount";
            this.gridColumn9.MinWidth = 30;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 166;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn10.AppearanceCell.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "EAN Code";
            this.gridColumn10.FieldName = "EANCode";
            this.gridColumn10.MinWidth = 30;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Width = 112;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtErrorEnd);
            this.panel2.Controls.Add(this.txtErrorStart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(642, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 44);
            this.panel2.TabIndex = 2;
            // 
            // txtErrorEnd
            // 
            this.txtErrorEnd.Location = new System.Drawing.Point(226, 6);
            this.txtErrorEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorEnd.Name = "txtErrorEnd";
            this.txtErrorEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtErrorEnd.Properties.Appearance.Options.UseFont = true;
            this.txtErrorEnd.Size = new System.Drawing.Size(158, 22);
            this.txtErrorEnd.TabIndex = 4;
            this.txtErrorEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtErrorEnd_KeyPress);
            // 
            // txtErrorStart
            // 
            this.txtErrorStart.Location = new System.Drawing.Point(10, 6);
            this.txtErrorStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorStart.Name = "txtErrorStart";
            this.txtErrorStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtErrorStart.Properties.Appearance.Options.UseFont = true;
            this.txtErrorStart.Size = new System.Drawing.Size(158, 22);
            this.txtErrorStart.TabIndex = 3;
            this.txtErrorStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtErrorStart_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(173, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "to";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(66, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thời gian làm việc (Work time)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(650, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng lỗi (Error Count)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDateWorkTimeEnd);
            this.panel3.Controls.Add(this.txtDateWorkTimeStart);
            this.panel3.Location = new System.Drawing.Point(60, 107);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 44);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(243, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "to";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDateWorkTimeEnd
            // 
            this.txtDateWorkTimeEnd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDateWorkTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateWorkTimeEnd.Location = new System.Drawing.Point(286, 5);
            this.txtDateWorkTimeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateWorkTimeEnd.Name = "txtDateWorkTimeEnd";
            this.txtDateWorkTimeEnd.Size = new System.Drawing.Size(222, 24);
            this.txtDateWorkTimeEnd.TabIndex = 1;
            this.txtDateWorkTimeEnd.ValueChanged += new System.EventHandler(this.txtDateWorkTimeEnd_ValueChanged);
            // 
            // txtDateWorkTimeStart
            // 
            this.txtDateWorkTimeStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDateWorkTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateWorkTimeStart.Location = new System.Drawing.Point(10, 5);
            this.txtDateWorkTimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateWorkTimeStart.Name = "txtDateWorkTimeStart";
            this.txtDateWorkTimeStart.Size = new System.Drawing.Size(222, 24);
            this.txtDateWorkTimeStart.TabIndex = 0;
            this.txtDateWorkTimeStart.ValueChanged += new System.EventHandler(this.txtDateWorkTimeStart_ValueChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(60, 210);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtLocation.Properties.Appearance.Options.UseFont = true;
            this.txtLocation.Size = new System.Drawing.Size(524, 22);
            this.txtLocation.TabIndex = 5;
            // 
            // txtDesignCode
            // 
            this.txtDesignCode.Location = new System.Drawing.Point(642, 210);
            this.txtDesignCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesignCode.Name = "txtDesignCode";
            this.txtDesignCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDesignCode.Properties.Appearance.Options.UseFont = true;
            this.txtDesignCode.Size = new System.Drawing.Size(404, 22);
            this.txtDesignCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(650, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã thiết kế (Design code)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(66, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vị trí (Location)";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::HANACANPC.ResourceImages.search2;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1090, 183);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(182, 59);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExportCSVMain
            // 
            this.btnExportCSVMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSVMain.BackColor = System.Drawing.Color.Green;
            this.btnExportCSVMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportCSVMain.ForeColor = System.Drawing.Color.White;
            this.btnExportCSVMain.Image = global::HANACANPC.ResourceImages.Download_32x32;
            this.btnExportCSVMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportCSVMain.Location = new System.Drawing.Point(1320, 183);
            this.btnExportCSVMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportCSVMain.Name = "btnExportCSVMain";
            this.btnExportCSVMain.Size = new System.Drawing.Size(178, 59);
            this.btnExportCSVMain.TabIndex = 6;
            this.btnExportCSVMain.TabStop = false;
            this.btnExportCSVMain.Text = "Export";
            this.btnExportCSVMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportCSVMain.UseVisualStyleBackColor = false;
            this.btnExportCSVMain.Click += new System.EventHandler(this.btnExportCSVMain_Click);
            // 
            // btnExportCSVError
            // 
            this.btnExportCSVError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSVError.BackColor = System.Drawing.Color.Green;
            this.btnExportCSVError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportCSVError.ForeColor = System.Drawing.Color.White;
            this.btnExportCSVError.Image = global::HANACANPC.ResourceImages.Download_32x32;
            this.btnExportCSVError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportCSVError.Location = new System.Drawing.Point(1551, 183);
            this.btnExportCSVError.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportCSVError.Name = "btnExportCSVError";
            this.btnExportCSVError.Size = new System.Drawing.Size(224, 59);
            this.btnExportCSVError.TabIndex = 7;
            this.btnExportCSVError.TabStop = false;
            this.btnExportCSVError.Text = "Export Error";
            this.btnExportCSVError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportCSVError.UseVisualStyleBackColor = false;
            this.btnExportCSVError.Click += new System.EventHandler(this.btnExportCSVError_Click);
            // 
            // frmCompensationLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 894);
            this.Controls.Add(this.btnExportCSVError);
            this.Controls.Add(this.btnExportCSVMain);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesignCode);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCompensationLog";
            this.Text = "Compensation LogData";
            this.Load += new System.EventHandler(this.frmCompensationLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompensation)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorStart.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCompensation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDateWorkTimeEnd;
        private System.Windows.Forms.DateTimePicker txtDateWorkTimeStart;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraEditors.TextEdit txtDesignCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.TextEdit txtErrorEnd;
        private DevExpress.XtraEditors.TextEdit txtErrorStart;
        private System.Windows.Forms.Button btnExportCSVMain;
        private System.Windows.Forms.Button btnExportCSVError;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}