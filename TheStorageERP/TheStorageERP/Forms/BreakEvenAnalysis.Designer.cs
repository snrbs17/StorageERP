
namespace TheStorageERP.Forms
{
    partial class BreakEvenAnalysis
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.infoSummarizedBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.row_Date = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowGrossProfit1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowVariableCost = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFixedCost = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowInfoId = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowSales = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowOtherRevenues = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowSalesReturns = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowGrossProfit = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowWages = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDepreciation = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRent = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowOtherSupplies = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUtilities = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowInsurance = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMaintenance = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAdvertising = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowOtherExpenses = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.infoReorganizedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoSummarizedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountInfoDaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoSummarizedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoSummarizedBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoReorganizedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoSummarizedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoDaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoSummarizedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(559, 5);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(320, 372);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
            // 
            // chartControl2
            // 
            this.chartControl2.AllowGesture = false;
            this.chartControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            simpleDiagram3D1.RotationMatrixSerializable = "-0.774821100692203;0.198740454474444;-0.600128730921524;0;0.551501375026583;0.676" +
    "541959323525;-0.487993043616946;0;0.309028308195177;-0.709079127481584;-0.633804" +
    "619503561;0;0;0;0;1";
            simpleDiagram3D1.RuntimeRotation = true;
            this.chartControl2.Diagram = simpleDiagram3D1;
            this.chartControl2.Legend.ItemVisibilityMode = DevExpress.XtraCharts.LegendItemVisibilityMode.AutoGeneratedAndCustom;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl2.Location = new System.Drawing.Point(0, 1);
            this.chartControl2.MinimumSize = new System.Drawing.Size(500, 300);
            this.chartControl2.Name = "chartControl2";
            series2.Name = "Series 1";
            series2.View = pie3DSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(553, 376);
            this.chartControl2.TabIndex = 1;
            this.chartControl2.Click += new System.EventHandler(this.chartControl2_Click);
            // 
            // vGridControl1
            // 
            this.vGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.CustomizationFormBounds = new System.Drawing.Rectangle(624, 243, 269, 353);
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(12, 97);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowInfoId,
            this.rowSales,
            this.rowOtherRevenues,
            this.rowSalesReturns,
            this.rowGrossProfit,
            this.rowWages,
            this.rowDepreciation,
            this.rowRent,
            this.rowOtherSupplies,
            this.rowUtilities,
            this.rowInsurance,
            this.rowMaintenance,
            this.rowAdvertising,
            this.rowOtherExpenses});
            this.vGridControl1.Size = new System.Drawing.Size(241, 290);
            this.vGridControl1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.chartControl1);
            this.panelControl1.Controls.Add(this.chartControl2);
            this.panelControl1.Location = new System.Drawing.Point(259, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 376);
            this.panelControl1.TabIndex = 4;
            // 
            // vGridControl2
            // 
            this.vGridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl2.DataSource = this.infoSummarizedBindingSource2;
            this.vGridControl2.Location = new System.Drawing.Point(12, 394);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row_Date,
            this.rowGrossProfit1,
            this.rowVariableCost,
            this.rowFixedCost});
            this.vGridControl2.Size = new System.Drawing.Size(1126, 150);
            this.vGridControl2.TabIndex = 5;
            this.vGridControl2.SelectedChanged += new DevExpress.XtraVerticalGrid.Events.SelectedChangedHandler(this.vGridControl2_SelectedChanged);
            this.vGridControl2.MouseCaptureChanged += new System.EventHandler(this.vGridControl2_MouseCaptureChanged);
            this.vGridControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vGridControl2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Month";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Quarter";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "View_Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoSummarizedBindingSource2
            // 
            this.infoSummarizedBindingSource2.DataSource = typeof(TheStorageERP.Entities.InfoSummarized);
            // 
            // row_Date
            // 
            this.row_Date.Height = 27;
            this.row_Date.Name = "row_Date";
            this.row_Date.Properties.Caption = "Date";
            this.row_Date.Properties.FieldName = "_Date";
            // 
            // rowGrossProfit1
            // 
            this.rowGrossProfit1.Height = 35;
            this.rowGrossProfit1.Name = "rowGrossProfit1";
            this.rowGrossProfit1.Properties.Caption = "Gross Profit";
            this.rowGrossProfit1.Properties.FieldName = "GrossProfit";
            // 
            // rowVariableCost
            // 
            this.rowVariableCost.Height = 42;
            this.rowVariableCost.Name = "rowVariableCost";
            this.rowVariableCost.Properties.Caption = "Variable Cost";
            this.rowVariableCost.Properties.FieldName = "VariableCost";
            // 
            // rowFixedCost
            // 
            this.rowFixedCost.Height = 33;
            this.rowFixedCost.Name = "rowFixedCost";
            this.rowFixedCost.Properties.Caption = "Fixed Cost";
            this.rowFixedCost.Properties.FieldName = "FixedCost";
            // 
            // rowInfoId
            // 
            this.rowInfoId.Name = "rowInfoId";
            this.rowInfoId.Properties.Caption = "Info Id";
            this.rowInfoId.Properties.FieldName = "InfoId";
            // 
            // rowSales
            // 
            this.rowSales.Name = "rowSales";
            this.rowSales.Properties.Caption = "Sales";
            this.rowSales.Properties.FieldName = "Sales";
            // 
            // rowOtherRevenues
            // 
            this.rowOtherRevenues.Name = "rowOtherRevenues";
            this.rowOtherRevenues.Properties.Caption = "Other Revenues";
            this.rowOtherRevenues.Properties.FieldName = "OtherRevenues";
            // 
            // rowSalesReturns
            // 
            this.rowSalesReturns.Height = 22;
            this.rowSalesReturns.Name = "rowSalesReturns";
            this.rowSalesReturns.Properties.Caption = "Sales Returns";
            this.rowSalesReturns.Properties.FieldName = "SalesReturns";
            // 
            // rowGrossProfit
            // 
            this.rowGrossProfit.Name = "rowGrossProfit";
            this.rowGrossProfit.Properties.Caption = "Gross Profit";
            this.rowGrossProfit.Properties.FieldName = "GrossProfit";
            // 
            // rowWages
            // 
            this.rowWages.Height = 22;
            this.rowWages.Name = "rowWages";
            this.rowWages.Properties.Caption = "Wages";
            this.rowWages.Properties.FieldName = "Wages";
            // 
            // rowDepreciation
            // 
            this.rowDepreciation.Name = "rowDepreciation";
            this.rowDepreciation.Properties.Caption = "Depreciation";
            this.rowDepreciation.Properties.FieldName = "Depreciation";
            // 
            // rowRent
            // 
            this.rowRent.Name = "rowRent";
            this.rowRent.Properties.Caption = "Rent";
            this.rowRent.Properties.FieldName = "Rent";
            // 
            // rowOtherSupplies
            // 
            this.rowOtherSupplies.Name = "rowOtherSupplies";
            this.rowOtherSupplies.Properties.Caption = "Other Supplies";
            this.rowOtherSupplies.Properties.FieldName = "OtherSupplies";
            // 
            // rowUtilities
            // 
            this.rowUtilities.Name = "rowUtilities";
            this.rowUtilities.Properties.Caption = "Utilities";
            this.rowUtilities.Properties.FieldName = "Utilities";
            // 
            // rowInsurance
            // 
            this.rowInsurance.Name = "rowInsurance";
            this.rowInsurance.Properties.Caption = "Insurance";
            this.rowInsurance.Properties.FieldName = "Insurance";
            // 
            // rowMaintenance
            // 
            this.rowMaintenance.Height = 22;
            this.rowMaintenance.Name = "rowMaintenance";
            this.rowMaintenance.Properties.Caption = "Maintenance";
            this.rowMaintenance.Properties.FieldName = "Maintenance";
            // 
            // rowAdvertising
            // 
            this.rowAdvertising.Height = 23;
            this.rowAdvertising.Name = "rowAdvertising";
            this.rowAdvertising.Properties.Caption = "Advertising";
            this.rowAdvertising.Properties.FieldName = "Advertising";
            // 
            // rowOtherExpenses
            // 
            this.rowOtherExpenses.Height = 33;
            this.rowOtherExpenses.Name = "rowOtherExpenses";
            this.rowOtherExpenses.Properties.Caption = "Other Expenses";
            this.rowOtherExpenses.Properties.FieldName = "OtherExpenses";
            // 
            // infoReorganizedBindingSource
            // 
            this.infoReorganizedBindingSource.DataSource = typeof(TheStorageERP.Entities.InfoReorganized);
            // 
            // infoSummarizedBindingSource1
            // 
            this.infoSummarizedBindingSource1.DataSource = typeof(TheStorageERP.Entities.InfoSummarized);
            // 
            // accountInfoDaoBindingSource
            // 
            this.accountInfoDaoBindingSource.DataSource = typeof(TheStorageERP.Dao.AccountInfoDao);
            // 
            // infoSummarizedBindingSource
            // 
            this.infoSummarizedBindingSource.DataSource = typeof(TheStorageERP.Entities.InfoSummarized);
            // 
            // BreakEvenAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 556);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vGridControl2);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "BreakEvenAnalysis";
            this.Text = "BreakEvenAnalysis";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoSummarizedBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoReorganizedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoSummarizedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoDaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoSummarizedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.Windows.Forms.BindingSource accountInfoDaoBindingSource;
        private System.Windows.Forms.BindingSource infoReorganizedBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource infoSummarizedBindingSource1;
        private System.Windows.Forms.BindingSource infoSummarizedBindingSource;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
        private System.Windows.Forms.BindingSource infoSummarizedBindingSource2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row_Date;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowGrossProfit1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowVariableCost;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFixedCost;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowInfoId;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSales;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOtherRevenues;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSalesReturns;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowGrossProfit;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowWages;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDepreciation;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRent;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOtherSupplies;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUtilities;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowInsurance;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMaintenance;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAdvertising;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOtherExpenses;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
    }
}