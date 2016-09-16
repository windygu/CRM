﻿namespace ZNLCRM.UI.STK
{
    partial class frmStkInManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucSuperTabControl1 = new ZNLCRM.Controls.UcSuperTabControl(this.components);
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dgvStkIn = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colSelect = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.colStkInGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colBillType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colSourceBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colTaxRate = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panMastWhere = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.tbiStkIn = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dgvDtlStkIn = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.panDtlWhere = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnDtlSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.tbiDtlStkIn = new DevComponents.DotNetBar.SuperTabItem();
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgStkIn = new ZNLCRM.Controls.UcPager();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tlbAuditBill = new System.Windows.Forms.ToolStripButton();
            this.tlbCancelBill = new System.Windows.Forms.ToolStripButton();
            this.colDtlSelect = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.colDtlStkInLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlStkInGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlInDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colDtlBillType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colDtlItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlMPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlMarkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlInvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBookedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlStkOutQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlReturnOccQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlIsRaiseTaxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlSCAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlPayAmtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlDemands = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlIsCut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlIsPCut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlIsGive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlCreatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlUpdatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlUpdatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlUpdatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlSourceBillGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlSourceBillLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlSOLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucSuperTabControl1)).BeginInit();
            this.ucSuperTabControl1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStkIn)).BeginInit();
            this.panMastWhere.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDtlStkIn)).BeginInit();
            this.panDtlWhere.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucSuperTabControl1);
            this.ucPanel1.Controls.Add(this.ucPanel5);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 40);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1215, 415);
            this.ucPanel1.TabIndex = 5;
            // 
            // ucSuperTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.ucSuperTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.ucSuperTabControl1.ControlBox.MenuBox.Name = "";
            this.ucSuperTabControl1.ControlBox.Name = "";
            this.ucSuperTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ucSuperTabControl1.ControlBox.MenuBox,
            this.ucSuperTabControl1.ControlBox.CloseBox});
            this.ucSuperTabControl1.Controls.Add(this.superTabControlPanel1);
            this.ucSuperTabControl1.Controls.Add(this.superTabControlPanel2);
            this.ucSuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuperTabControl1.Location = new System.Drawing.Point(0, 0);
            this.ucSuperTabControl1.Name = "ucSuperTabControl1";
            this.ucSuperTabControl1.ReorderTabsEnabled = true;
            this.ucSuperTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucSuperTabControl1.SelectedTabIndex = 1;
            this.ucSuperTabControl1.Size = new System.Drawing.Size(1215, 379);
            this.ucSuperTabControl1.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucSuperTabControl1.TabIndex = 6;
            this.ucSuperTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tbiDtlStkIn,
            this.tbiStkIn});
            this.ucSuperTabControl1.Text = "ucSuperTabControl1";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.dgvStkIn);
            this.superTabControlPanel2.Controls.Add(this.panMastWhere);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1215, 351);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tbiStkIn;
            // 
            // dgvStkIn
            // 
            this.dgvStkIn.AllowUserToAddRows = false;
            this.dgvStkIn.AllowUserToDeleteRows = false;
            this.dgvStkIn.AllowUserToOrderColumns = true;
            this.dgvStkIn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStkIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStkIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStkIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colStkInGuid,
            this.colBillNo,
            this.colInDate,
            this.colBillType,
            this.colSourceBillNo,
            this.colOperOrgID,
            this.colOperOrgName,
            this.colOperDeptID,
            this.colOperDeptName,
            this.colOperEmpID,
            this.colOperEmpName,
            this.colReceiverID,
            this.colReceiverName,
            this.colCurrency,
            this.colTaxRate,
            this.colExchangeRate,
            this.colAmount,
            this.colPaymentAmount,
            this.colRemark,
            this.colApproveStatus,
            this.colCreatedEmpID,
            this.colCreatedEmpName,
            this.colCreatedTime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStkIn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStkIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStkIn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStkIn.HighlightSelectedColumnHeaders = false;
            this.dgvStkIn.Location = new System.Drawing.Point(0, 37);
            this.dgvStkIn.Name = "dgvStkIn";
            this.dgvStkIn.PaintEnhancedSelection = false;
            this.dgvStkIn.ReadOnly = true;
            this.dgvStkIn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStkIn.RowTemplate.Height = 23;
            this.dgvStkIn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStkIn.SelectAllSignVisible = false;
            this.dgvStkIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStkIn.Size = new System.Drawing.Size(1215, 314);
            this.dgvStkIn.TabIndex = 5;
            this.dgvStkIn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStkIn_CellDoubleClick);
            this.dgvStkIn.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStkIn_RowEnter);
            // 
            // colSelect
            // 
            this.colSelect.Checked = true;
            this.colSelect.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.colSelect.CheckValue = "N";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSelect.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSelect.HeaderText = "选？";
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelect.Visible = false;
            this.colSelect.Width = 35;
            // 
            // colStkInGuid
            // 
            this.colStkInGuid.DataPropertyName = "StkInGuid";
            this.colStkInGuid.HeaderText = "入库GUID";
            this.colStkInGuid.Name = "colStkInGuid";
            this.colStkInGuid.ReadOnly = true;
            this.colStkInGuid.Visible = false;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "单据编号";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.ReadOnly = true;
            // 
            // colInDate
            // 
            // 
            // 
            // 
            this.colInDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colInDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colInDate.CustomFormat = "yyyy-MM-dd";
            this.colInDate.DataPropertyName = "InDate";
            this.colInDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.colInDate.HeaderText = "入库日期";
            this.colInDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colInDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colInDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colInDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colInDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colInDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.colInDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colInDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colInDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colInDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colInDate.Name = "colInDate";
            this.colInDate.ReadOnly = true;
            this.colInDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colBillType
            // 
            this.colBillType.DataPropertyName = "BillType";
            this.colBillType.DropDownHeight = 106;
            this.colBillType.DropDownWidth = 121;
            this.colBillType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colBillType.HeaderText = "单据类型";
            this.colBillType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colBillType.IntegralHeight = false;
            this.colBillType.ItemHeight = 16;
            this.colBillType.Name = "colBillType";
            this.colBillType.ReadOnly = true;
            this.colBillType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBillType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colSourceBillNo
            // 
            this.colSourceBillNo.DataPropertyName = "SourceBillNo";
            this.colSourceBillNo.HeaderText = "源单据编号";
            this.colSourceBillNo.Name = "colSourceBillNo";
            this.colSourceBillNo.ReadOnly = true;
            // 
            // colOperOrgID
            // 
            this.colOperOrgID.HeaderText = "归属机构ID";
            this.colOperOrgID.Name = "colOperOrgID";
            this.colOperOrgID.ReadOnly = true;
            this.colOperOrgID.Visible = false;
            // 
            // colOperOrgName
            // 
            this.colOperOrgName.DataPropertyName = "OperOrgName";
            this.colOperOrgName.HeaderText = "归属机构";
            this.colOperOrgName.Name = "colOperOrgName";
            this.colOperOrgName.ReadOnly = true;
            // 
            // colOperDeptID
            // 
            this.colOperDeptID.HeaderText = "归属部门ID";
            this.colOperDeptID.Name = "colOperDeptID";
            this.colOperDeptID.ReadOnly = true;
            this.colOperDeptID.Visible = false;
            // 
            // colOperDeptName
            // 
            this.colOperDeptName.DataPropertyName = "OperDeptName";
            this.colOperDeptName.HeaderText = "归属部门";
            this.colOperDeptName.Name = "colOperDeptName";
            this.colOperDeptName.ReadOnly = true;
            // 
            // colOperEmpID
            // 
            this.colOperEmpID.HeaderText = "归属人员ID";
            this.colOperEmpID.Name = "colOperEmpID";
            this.colOperEmpID.ReadOnly = true;
            this.colOperEmpID.Visible = false;
            // 
            // colOperEmpName
            // 
            this.colOperEmpName.DataPropertyName = "OperEmpName";
            this.colOperEmpName.HeaderText = "归属人员";
            this.colOperEmpName.Name = "colOperEmpName";
            this.colOperEmpName.ReadOnly = true;
            // 
            // colReceiverID
            // 
            this.colReceiverID.DataPropertyName = "ReceiverID";
            this.colReceiverID.HeaderText = "收货人员ID";
            this.colReceiverID.Name = "colReceiverID";
            this.colReceiverID.ReadOnly = true;
            this.colReceiverID.Visible = false;
            // 
            // colReceiverName
            // 
            this.colReceiverName.DataPropertyName = "ReceiverName";
            this.colReceiverName.HeaderText = "收货人员";
            this.colReceiverName.Name = "colReceiverName";
            this.colReceiverName.ReadOnly = true;
            // 
            // colCurrency
            // 
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.DropDownHeight = 106;
            this.colCurrency.DropDownWidth = 121;
            this.colCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCurrency.HeaderText = "币种";
            this.colCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colCurrency.IntegralHeight = false;
            this.colCurrency.ItemHeight = 16;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            this.colCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colTaxRate
            // 
            this.colTaxRate.DataPropertyName = "TaxRate";
            this.colTaxRate.DropDownHeight = 106;
            this.colTaxRate.DropDownWidth = 121;
            this.colTaxRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTaxRate.HeaderText = "税率";
            this.colTaxRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colTaxRate.IntegralHeight = false;
            this.colTaxRate.ItemHeight = 16;
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.ReadOnly = true;
            this.colTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colExchangeRate
            // 
            this.colExchangeRate.DataPropertyName = "ExchangeRate";
            this.colExchangeRate.HeaderText = "汇率";
            this.colExchangeRate.Name = "colExchangeRate";
            this.colExchangeRate.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "总金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            this.colPaymentAmount.HeaderText = "已付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // colApproveStatus
            // 
            this.colApproveStatus.DataPropertyName = "ApproveStatus";
            this.colApproveStatus.HeaderText = "单据状态";
            this.colApproveStatus.Name = "colApproveStatus";
            this.colApproveStatus.ReadOnly = true;
            // 
            // colCreatedEmpID
            // 
            this.colCreatedEmpID.DataPropertyName = "CreatedEmpID";
            this.colCreatedEmpID.HeaderText = "创建人员ID";
            this.colCreatedEmpID.Name = "colCreatedEmpID";
            this.colCreatedEmpID.ReadOnly = true;
            this.colCreatedEmpID.Visible = false;
            // 
            // colCreatedEmpName
            // 
            this.colCreatedEmpName.DataPropertyName = "CreatedEmpName";
            this.colCreatedEmpName.HeaderText = "创建人员";
            this.colCreatedEmpName.Name = "colCreatedEmpName";
            this.colCreatedEmpName.ReadOnly = true;
            // 
            // colCreatedTime
            // 
            this.colCreatedTime.DataPropertyName = "CreatedTime";
            this.colCreatedTime.HeaderText = "创建日期";
            this.colCreatedTime.Name = "colCreatedTime";
            this.colCreatedTime.ReadOnly = true;
            // 
            // panMastWhere
            // 
            this.panMastWhere.BackColor = System.Drawing.Color.Transparent;
            this.panMastWhere.Controls.Add(this.btnSearch);
            this.panMastWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMastWhere.Location = new System.Drawing.Point(0, 0);
            this.panMastWhere.Name = "panMastWhere";
            this.panMastWhere.Size = new System.Drawing.Size(1215, 37);
            this.panMastWhere.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(12, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbiStkIn
            // 
            this.tbiStkIn.AttachedControl = this.superTabControlPanel2;
            this.tbiStkIn.GlobalItem = false;
            this.tbiStkIn.Name = "tbiStkIn";
            this.tbiStkIn.Text = "采购入库单列表";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.dgvDtlStkIn);
            this.superTabControlPanel1.Controls.Add(this.panDtlWhere);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1215, 351);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tbiDtlStkIn;
            // 
            // dgvDtlStkIn
            // 
            this.dgvDtlStkIn.AllowUserToAddRows = false;
            this.dgvDtlStkIn.AllowUserToDeleteRows = false;
            this.dgvDtlStkIn.AllowUserToOrderColumns = true;
            this.dgvDtlStkIn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDtlStkIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDtlStkIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDtlStkIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDtlSelect,
            this.colDtlStkInLineGuid,
            this.colDtlStkInGuid,
            this.colDtlBillNo,
            this.colDtlInDate,
            this.colDtlBillType,
            this.colDtlItemCode,
            this.colDtlModel,
            this.colDtlBrand,
            this.colDtlPackage,
            this.colDtlBatch,
            this.colDtlQuality,
            this.colDtlMPQ,
            this.colDtlMarkCode,
            this.colDtlInvType,
            this.colDtlWarehouse,
            this.colDtlLocation,
            this.colDtlQty,
            this.colDtlBookedQty,
            this.colDtlStkOutQty,
            this.colDtlReturnOccQty,
            this.colDtlUnit,
            this.colDtlUnitPrice,
            this.colDtlFreight,
            this.colDtlCostPrice,
            this.colDtlCurrency,
            this.colDtlExchangeRate,
            this.colDtlTaxRate,
            this.colDtlIsRaiseTaxes,
            this.colDtlAmount,
            this.colDtlSCAmount,
            this.colDtlPaymentAmount,
            this.colDtlPayAmtDate,
            this.colDtlDemands,
            this.colDtlRemark,
            this.colDtlIsCut,
            this.colDtlIsPCut,
            this.colDtlIsGive,
            this.colDtlCreatedEmpID,
            this.colDtlCreatedEmpName,
            this.colDtlCreatedTime,
            this.colDtlUpdatedEmpID,
            this.colDtlUpdatedEmpName,
            this.colDtlUpdatedTime,
            this.colDtlIsDeleted,
            this.colDtlBuyerID,
            this.colDtlBuyerName,
            this.colDtlSourceBillGuid,
            this.colDtlSourceBillLineGuid,
            this.colDtlSOLineGuid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDtlStkIn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDtlStkIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDtlStkIn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDtlStkIn.HighlightSelectedColumnHeaders = false;
            this.dgvDtlStkIn.Location = new System.Drawing.Point(0, 37);
            this.dgvDtlStkIn.Name = "dgvDtlStkIn";
            this.dgvDtlStkIn.PaintEnhancedSelection = false;
            this.dgvDtlStkIn.ReadOnly = true;
            this.dgvDtlStkIn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDtlStkIn.RowTemplate.Height = 23;
            this.dgvDtlStkIn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDtlStkIn.SelectAllSignVisible = false;
            this.dgvDtlStkIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDtlStkIn.Size = new System.Drawing.Size(1215, 314);
            this.dgvDtlStkIn.TabIndex = 2;
            this.dgvDtlStkIn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDtlStkIn_CellDoubleClick);
            this.dgvDtlStkIn.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDtlStkIn_RowEnter);
            // 
            // panDtlWhere
            // 
            this.panDtlWhere.BackColor = System.Drawing.Color.Transparent;
            this.panDtlWhere.Controls.Add(this.btnDtlSearch);
            this.panDtlWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDtlWhere.Location = new System.Drawing.Point(0, 0);
            this.panDtlWhere.Name = "panDtlWhere";
            this.panDtlWhere.Size = new System.Drawing.Size(1215, 37);
            this.panDtlWhere.TabIndex = 4;
            // 
            // btnDtlSearch
            // 
            this.btnDtlSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDtlSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDtlSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnDtlSearch.Location = new System.Drawing.Point(12, 8);
            this.btnDtlSearch.Name = "btnDtlSearch";
            this.btnDtlSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDtlSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDtlSearch.TabIndex = 4;
            this.btnDtlSearch.Text = "搜索";
            this.btnDtlSearch.Click += new System.EventHandler(this.btnDtlSearch_Click);
            // 
            // tbiDtlStkIn
            // 
            this.tbiDtlStkIn.AttachedControl = this.superTabControlPanel1;
            this.tbiDtlStkIn.GlobalItem = false;
            this.tbiDtlStkIn.Name = "tbiDtlStkIn";
            this.tbiDtlStkIn.Text = "采购入库单明细列表";
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.pgStkIn);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel5.Location = new System.Drawing.Point(0, 379);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(1215, 36);
            this.ucPanel5.TabIndex = 5;
            // 
            // pgStkIn
            // 
            this.pgStkIn.BackColor = System.Drawing.Color.Transparent;
            this.pgStkIn.Location = new System.Drawing.Point(14, 11);
            this.pgStkIn.Name = "pgStkIn";
            this.pgStkIn.RecordCount = 0;
            this.pgStkIn.Size = new System.Drawing.Size(195, 15);
            this.pgStkIn.TabIndex = 0;
            this.pgStkIn.PageIndexChanged += new System.EventHandler(this.pgList_PageIndexChanged);
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucToolStrip1);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(1215, 40);
            this.ucPanel2.TabIndex = 6;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDel,
            this.tsbPrint,
            this.tlbAuditBill,
            this.tlbCancelBill});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(1215, 40);
            this.ucToolStrip1.TabIndex = 3;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(55, 27);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.ToolTipText = "添加新的入库单";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(55, 27);
            this.tsbEdit.Text = "修改";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(55, 27);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::ZNLCRM.UI.Properties.Resources.print_1;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(55, 27);
            this.tsbPrint.Text = "打印";
            // 
            // tlbAuditBill
            // 
            this.tlbAuditBill.Image = global::ZNLCRM.UI.Properties.Resources.checkok;
            this.tlbAuditBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAuditBill.Name = "tlbAuditBill";
            this.tlbAuditBill.Size = new System.Drawing.Size(55, 27);
            this.tlbAuditBill.Text = "审核";
            this.tlbAuditBill.Click += new System.EventHandler(this.tlbAuditBill_Click);
            // 
            // tlbCancelBill
            // 
            this.tlbCancelBill.Image = global::ZNLCRM.UI.Properties.Resources.refresh_1;
            this.tlbCancelBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbCancelBill.Name = "tlbCancelBill";
            this.tlbCancelBill.Size = new System.Drawing.Size(55, 27);
            this.tlbCancelBill.Text = "撤单";
            this.tlbCancelBill.Click += new System.EventHandler(this.tlbCancelBill_Click);
            // 
            // colDtlSelect
            // 
            this.colDtlSelect.Checked = true;
            this.colDtlSelect.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.colDtlSelect.CheckValue = "N";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDtlSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDtlSelect.HeaderText = "选择";
            this.colDtlSelect.Name = "colDtlSelect";
            this.colDtlSelect.ReadOnly = true;
            this.colDtlSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDtlSelect.Visible = false;
            this.colDtlSelect.Width = 35;
            // 
            // colDtlStkInLineGuid
            // 
            this.colDtlStkInLineGuid.DataPropertyName = "StkInLineGuid";
            this.colDtlStkInLineGuid.HeaderText = "入库明细GUID";
            this.colDtlStkInLineGuid.Name = "colDtlStkInLineGuid";
            this.colDtlStkInLineGuid.ReadOnly = true;
            this.colDtlStkInLineGuid.Visible = false;
            // 
            // colDtlStkInGuid
            // 
            this.colDtlStkInGuid.DataPropertyName = "StkInGuid";
            this.colDtlStkInGuid.HeaderText = "入库主单GUID";
            this.colDtlStkInGuid.Name = "colDtlStkInGuid";
            this.colDtlStkInGuid.ReadOnly = true;
            this.colDtlStkInGuid.Visible = false;
            // 
            // colDtlBillNo
            // 
            this.colDtlBillNo.DataPropertyName = "BillNo";
            this.colDtlBillNo.HeaderText = "单据编号";
            this.colDtlBillNo.Name = "colDtlBillNo";
            this.colDtlBillNo.ReadOnly = true;
            // 
            // colDtlInDate
            // 
            // 
            // 
            // 
            this.colDtlInDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colDtlInDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colDtlInDate.CustomFormat = "yyyy-MM-dd";
            this.colDtlInDate.DataPropertyName = "InDate";
            this.colDtlInDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.colDtlInDate.HeaderText = "入库日期";
            this.colDtlInDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colDtlInDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colDtlInDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colDtlInDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colDtlInDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colDtlInDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.colDtlInDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colDtlInDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colDtlInDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colDtlInDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colDtlInDate.Name = "colDtlInDate";
            this.colDtlInDate.ReadOnly = true;
            this.colDtlInDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDtlBillType
            // 
            this.colDtlBillType.DataPropertyName = "BillType";
            this.colDtlBillType.DropDownHeight = 106;
            this.colDtlBillType.DropDownWidth = 121;
            this.colDtlBillType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDtlBillType.HeaderText = "单据类型";
            this.colDtlBillType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colDtlBillType.IntegralHeight = false;
            this.colDtlBillType.ItemHeight = 16;
            this.colDtlBillType.Name = "colDtlBillType";
            this.colDtlBillType.ReadOnly = true;
            this.colDtlBillType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlBillType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colDtlItemCode
            // 
            this.colDtlItemCode.HeaderText = "库存ID";
            this.colDtlItemCode.Name = "colDtlItemCode";
            this.colDtlItemCode.ReadOnly = true;
            this.colDtlItemCode.Visible = false;
            // 
            // colDtlModel
            // 
            this.colDtlModel.DataPropertyName = "Model";
            this.colDtlModel.HeaderText = "型号";
            this.colDtlModel.Name = "colDtlModel";
            this.colDtlModel.ReadOnly = true;
            // 
            // colDtlBrand
            // 
            this.colDtlBrand.DataPropertyName = "Brand";
            this.colDtlBrand.HeaderText = "品牌";
            this.colDtlBrand.Name = "colDtlBrand";
            this.colDtlBrand.ReadOnly = true;
            // 
            // colDtlPackage
            // 
            this.colDtlPackage.DataPropertyName = "Package";
            this.colDtlPackage.HeaderText = "封装";
            this.colDtlPackage.Name = "colDtlPackage";
            this.colDtlPackage.ReadOnly = true;
            // 
            // colDtlBatch
            // 
            this.colDtlBatch.DataPropertyName = "Batch";
            this.colDtlBatch.HeaderText = "批号";
            this.colDtlBatch.Name = "colDtlBatch";
            this.colDtlBatch.ReadOnly = true;
            // 
            // colDtlQuality
            // 
            this.colDtlQuality.DataPropertyName = "Quality";
            this.colDtlQuality.HeaderText = "品质";
            this.colDtlQuality.Name = "colDtlQuality";
            this.colDtlQuality.ReadOnly = true;
            // 
            // colDtlMPQ
            // 
            this.colDtlMPQ.DataPropertyName = "MPQ";
            this.colDtlMPQ.HeaderText = "包装";
            this.colDtlMPQ.Name = "colDtlMPQ";
            this.colDtlMPQ.ReadOnly = true;
            // 
            // colDtlMarkCode
            // 
            this.colDtlMarkCode.DataPropertyName = "MarkCode";
            this.colDtlMarkCode.HeaderText = "标记码";
            this.colDtlMarkCode.Name = "colDtlMarkCode";
            this.colDtlMarkCode.ReadOnly = true;
            // 
            // colDtlInvType
            // 
            this.colDtlInvType.DataPropertyName = "InvType";
            this.colDtlInvType.HeaderText = "库存类型";
            this.colDtlInvType.Name = "colDtlInvType";
            this.colDtlInvType.ReadOnly = true;
            // 
            // colDtlWarehouse
            // 
            this.colDtlWarehouse.DataPropertyName = "Warehouse";
            this.colDtlWarehouse.HeaderText = "仓库";
            this.colDtlWarehouse.Name = "colDtlWarehouse";
            this.colDtlWarehouse.ReadOnly = true;
            // 
            // colDtlLocation
            // 
            this.colDtlLocation.DataPropertyName = "Location";
            this.colDtlLocation.HeaderText = "位置";
            this.colDtlLocation.Name = "colDtlLocation";
            this.colDtlLocation.ReadOnly = true;
            // 
            // colDtlQty
            // 
            this.colDtlQty.HeaderText = "入库数量";
            this.colDtlQty.Name = "colDtlQty";
            this.colDtlQty.ReadOnly = true;
            // 
            // colDtlBookedQty
            // 
            this.colDtlBookedQty.DataPropertyName = "BookedQty";
            this.colDtlBookedQty.HeaderText = "预留数";
            this.colDtlBookedQty.Name = "colDtlBookedQty";
            this.colDtlBookedQty.ReadOnly = true;
            // 
            // colDtlStkOutQty
            // 
            this.colDtlStkOutQty.DataPropertyName = "StkOutQty";
            this.colDtlStkOutQty.HeaderText = "出库数量";
            this.colDtlStkOutQty.Name = "colDtlStkOutQty";
            this.colDtlStkOutQty.ReadOnly = true;
            // 
            // colDtlReturnOccQty
            // 
            this.colDtlReturnOccQty.DataPropertyName = "ReturnOccQty";
            this.colDtlReturnOccQty.HeaderText = "采购退货占有数量";
            this.colDtlReturnOccQty.Name = "colDtlReturnOccQty";
            this.colDtlReturnOccQty.ReadOnly = true;
            // 
            // colDtlUnit
            // 
            this.colDtlUnit.DataPropertyName = "Unit";
            this.colDtlUnit.HeaderText = "单位";
            this.colDtlUnit.Name = "colDtlUnit";
            this.colDtlUnit.ReadOnly = true;
            // 
            // colDtlUnitPrice
            // 
            this.colDtlUnitPrice.DataPropertyName = "UnitPrice";
            this.colDtlUnitPrice.HeaderText = "采购进价";
            this.colDtlUnitPrice.Name = "colDtlUnitPrice";
            this.colDtlUnitPrice.ReadOnly = true;
            // 
            // colDtlFreight
            // 
            this.colDtlFreight.DataPropertyName = "Freight";
            this.colDtlFreight.HeaderText = "运费";
            this.colDtlFreight.Name = "colDtlFreight";
            this.colDtlFreight.ReadOnly = true;
            // 
            // colDtlCostPrice
            // 
            this.colDtlCostPrice.DataPropertyName = "CostPrice";
            this.colDtlCostPrice.HeaderText = "成本单价";
            this.colDtlCostPrice.Name = "colDtlCostPrice";
            this.colDtlCostPrice.ReadOnly = true;
            // 
            // colDtlCurrency
            // 
            this.colDtlCurrency.DataPropertyName = "Currency";
            this.colDtlCurrency.HeaderText = "币种";
            this.colDtlCurrency.Name = "colDtlCurrency";
            this.colDtlCurrency.ReadOnly = true;
            // 
            // colDtlExchangeRate
            // 
            this.colDtlExchangeRate.DataPropertyName = "ExchangeRate";
            this.colDtlExchangeRate.HeaderText = "汇率";
            this.colDtlExchangeRate.Name = "colDtlExchangeRate";
            this.colDtlExchangeRate.ReadOnly = true;
            // 
            // colDtlTaxRate
            // 
            this.colDtlTaxRate.DataPropertyName = "TaxRate";
            this.colDtlTaxRate.HeaderText = "税率";
            this.colDtlTaxRate.Name = "colDtlTaxRate";
            this.colDtlTaxRate.ReadOnly = true;
            // 
            // colDtlIsRaiseTaxes
            // 
            this.colDtlIsRaiseTaxes.DataPropertyName = "IsRaiseTaxes";
            this.colDtlIsRaiseTaxes.HeaderText = "是否已提税金";
            this.colDtlIsRaiseTaxes.Name = "colDtlIsRaiseTaxes";
            this.colDtlIsRaiseTaxes.ReadOnly = true;
            // 
            // colDtlAmount
            // 
            this.colDtlAmount.DataPropertyName = "Amount";
            this.colDtlAmount.HeaderText = "小计金额";
            this.colDtlAmount.Name = "colDtlAmount";
            this.colDtlAmount.ReadOnly = true;
            // 
            // colDtlSCAmount
            // 
            this.colDtlSCAmount.DataPropertyName = "SCAmount";
            this.colDtlSCAmount.HeaderText = "本币金额(RMB)";
            this.colDtlSCAmount.Name = "colDtlSCAmount";
            this.colDtlSCAmount.ReadOnly = true;
            // 
            // colDtlPaymentAmount
            // 
            this.colDtlPaymentAmount.DataPropertyName = "PaymentAmount";
            this.colDtlPaymentAmount.HeaderText = "已付款金额";
            this.colDtlPaymentAmount.Name = "colDtlPaymentAmount";
            this.colDtlPaymentAmount.ReadOnly = true;
            // 
            // colDtlPayAmtDate
            // 
            this.colDtlPayAmtDate.DataPropertyName = "PayAmtDate";
            this.colDtlPayAmtDate.HeaderText = "付款日期";
            this.colDtlPayAmtDate.Name = "colDtlPayAmtDate";
            this.colDtlPayAmtDate.ReadOnly = true;
            // 
            // colDtlDemands
            // 
            this.colDtlDemands.DataPropertyName = "Demands";
            this.colDtlDemands.HeaderText = "采购要求";
            this.colDtlDemands.Name = "colDtlDemands";
            this.colDtlDemands.ReadOnly = true;
            // 
            // colDtlRemark
            // 
            this.colDtlRemark.DataPropertyName = "Remark";
            this.colDtlRemark.HeaderText = "备注";
            this.colDtlRemark.Name = "colDtlRemark";
            this.colDtlRemark.ReadOnly = true;
            // 
            // colDtlIsCut
            // 
            this.colDtlIsCut.DataPropertyName = "IsCut";
            this.colDtlIsCut.HeaderText = "是否纳入销售提成";
            this.colDtlIsCut.Name = "colDtlIsCut";
            this.colDtlIsCut.ReadOnly = true;
            // 
            // colDtlIsPCut
            // 
            this.colDtlIsPCut.DataPropertyName = "IsPCut";
            this.colDtlIsPCut.HeaderText = "是否纳入采购提成";
            this.colDtlIsPCut.Name = "colDtlIsPCut";
            this.colDtlIsPCut.ReadOnly = true;
            // 
            // colDtlIsGive
            // 
            this.colDtlIsGive.DataPropertyName = "IsGive";
            this.colDtlIsGive.HeaderText = "是否赠送";
            this.colDtlIsGive.Name = "colDtlIsGive";
            this.colDtlIsGive.ReadOnly = true;
            // 
            // colDtlCreatedEmpID
            // 
            this.colDtlCreatedEmpID.DataPropertyName = "CreatedEmpID";
            this.colDtlCreatedEmpID.HeaderText = "创建人ID";
            this.colDtlCreatedEmpID.Name = "colDtlCreatedEmpID";
            this.colDtlCreatedEmpID.ReadOnly = true;
            // 
            // colDtlCreatedEmpName
            // 
            this.colDtlCreatedEmpName.DataPropertyName = "CreatedEmpName";
            this.colDtlCreatedEmpName.HeaderText = "创建人";
            this.colDtlCreatedEmpName.Name = "colDtlCreatedEmpName";
            this.colDtlCreatedEmpName.ReadOnly = true;
            // 
            // colDtlCreatedTime
            // 
            this.colDtlCreatedTime.DataPropertyName = "CreatedTime";
            this.colDtlCreatedTime.HeaderText = "创建时间";
            this.colDtlCreatedTime.Name = "colDtlCreatedTime";
            this.colDtlCreatedTime.ReadOnly = true;
            // 
            // colDtlUpdatedEmpID
            // 
            this.colDtlUpdatedEmpID.DataPropertyName = "UpdatedEmpID";
            this.colDtlUpdatedEmpID.HeaderText = "更新人ID";
            this.colDtlUpdatedEmpID.Name = "colDtlUpdatedEmpID";
            this.colDtlUpdatedEmpID.ReadOnly = true;
            // 
            // colDtlUpdatedEmpName
            // 
            this.colDtlUpdatedEmpName.DataPropertyName = "UpdatedEmpName";
            this.colDtlUpdatedEmpName.HeaderText = "更新人";
            this.colDtlUpdatedEmpName.Name = "colDtlUpdatedEmpName";
            this.colDtlUpdatedEmpName.ReadOnly = true;
            // 
            // colDtlUpdatedTime
            // 
            this.colDtlUpdatedTime.DataPropertyName = "UpdatedTime";
            this.colDtlUpdatedTime.HeaderText = "更新时间";
            this.colDtlUpdatedTime.Name = "colDtlUpdatedTime";
            this.colDtlUpdatedTime.ReadOnly = true;
            // 
            // colDtlIsDeleted
            // 
            this.colDtlIsDeleted.DataPropertyName = "IsDeleted";
            this.colDtlIsDeleted.HeaderText = "是否删除";
            this.colDtlIsDeleted.Name = "colDtlIsDeleted";
            this.colDtlIsDeleted.ReadOnly = true;
            // 
            // colDtlBuyerID
            // 
            this.colDtlBuyerID.DataPropertyName = "BuyerID";
            this.colDtlBuyerID.HeaderText = "采购员ID";
            this.colDtlBuyerID.Name = "colDtlBuyerID";
            this.colDtlBuyerID.ReadOnly = true;
            this.colDtlBuyerID.Visible = false;
            // 
            // colDtlBuyerName
            // 
            this.colDtlBuyerName.DataPropertyName = "BuyerName";
            this.colDtlBuyerName.HeaderText = "采购员";
            this.colDtlBuyerName.Name = "colDtlBuyerName";
            this.colDtlBuyerName.ReadOnly = true;
            // 
            // colDtlSourceBillGuid
            // 
            this.colDtlSourceBillGuid.DataPropertyName = "SourceBillGuid";
            this.colDtlSourceBillGuid.HeaderText = "关联单据主单GUID";
            this.colDtlSourceBillGuid.Name = "colDtlSourceBillGuid";
            this.colDtlSourceBillGuid.ReadOnly = true;
            this.colDtlSourceBillGuid.Visible = false;
            // 
            // colDtlSourceBillLineGuid
            // 
            this.colDtlSourceBillLineGuid.DataPropertyName = "SourceBillLineGuid";
            this.colDtlSourceBillLineGuid.HeaderText = "关联单据明细GUID";
            this.colDtlSourceBillLineGuid.Name = "colDtlSourceBillLineGuid";
            this.colDtlSourceBillLineGuid.ReadOnly = true;
            this.colDtlSourceBillLineGuid.Visible = false;
            // 
            // colDtlSOLineGuid
            // 
            this.colDtlSOLineGuid.DataPropertyName = "SOLineGuid";
            this.colDtlSOLineGuid.HeaderText = "销售明细Guid";
            this.colDtlSOLineGuid.Name = "colDtlSOLineGuid";
            this.colDtlSOLineGuid.ReadOnly = true;
            this.colDtlSOLineGuid.Visible = false;
            // 
            // frmStkInManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 455);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.ucPanel2);
            this.Name = "frmStkInManage";
            this.Text = "入库单管理";
            this.Load += new System.EventHandler(this.frmStkInManage_Load);
            this.ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucSuperTabControl1)).EndInit();
            this.ucSuperTabControl1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStkIn)).EndInit();
            this.panMastWhere.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDtlStkIn)).EndInit();
            this.panDtlWhere.ResumeLayout(false);
            this.ucPanel5.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel2.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private Controls.UcPanel panDtlWhere;
        private Controls.UcButton btnDtlSearch;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel5;
        private Controls.UcPager pgStkIn;
        private Controls.UcDataGridView dgvDtlStkIn;
        private System.Windows.Forms.ToolStripButton tlbAuditBill;
        private System.Windows.Forms.ToolStripButton tlbCancelBill;
        private Controls.UcSuperTabControl ucSuperTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tbiDtlStkIn;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tbiStkIn;
        private Controls.UcDataGridView dgvStkIn;
        private Controls.UcPanel panMastWhere;
        private Controls.UcButton btnSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkInGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colInDate;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colBillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperOrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperDeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiverName;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedTime;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colDtlSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlStkInLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlStkInGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBillNo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colDtlInDate;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colDtlBillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlMPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlMarkCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlInvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBookedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlStkOutQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlReturnOccQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlIsRaiseTaxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlSCAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlPayAmtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlDemands;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlIsCut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlIsPCut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlIsGive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlCreatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlCreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlUpdatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlUpdatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlUpdatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlIsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBuyerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlSourceBillGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlSourceBillLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlSOLineGuid;
    }
}