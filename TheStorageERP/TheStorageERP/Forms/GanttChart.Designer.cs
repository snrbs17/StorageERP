
namespace TheStorageERP
{
    partial class GanttChart
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
            DevExpress.XtraCharts.GanttDiagram ganttDiagram1 = new DevExpress.XtraCharts.GanttDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.OverlappedGanttSeriesView overlappedGanttSeriesView1 = new DevExpress.XtraCharts.OverlappedGanttSeriesView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.comboType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboFacility = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboFacility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ganttDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(overlappedGanttSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.comboType);
            this.layoutControl1.Controls.Add(this.comboFacility);
            this.layoutControl1.Controls.Add(this.chartControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 540);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboType
            // 
            this.comboType.EditValue = "전체";
            this.comboType.Location = new System.Drawing.Point(317, 12);
            this.comboType.Name = "comboType";
            this.comboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboType.Properties.Items.AddRange(new object[] {
            "전체",
            "일반",
            "신선"});
            this.comboType.Size = new System.Drawing.Size(162, 24);
            this.comboType.StyleController = this.layoutControl1;
            this.comboType.TabIndex = 6;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // comboFacility
            // 
            this.comboFacility.EditValue = "화곡역";
            this.comboFacility.Location = new System.Drawing.Point(68, 12);
            this.comboFacility.Name = "comboFacility";
            this.comboFacility.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboFacility.Properties.Items.AddRange(new object[] {
            "화곡역",
            "송정역"});
            this.comboFacility.Size = new System.Drawing.Size(164, 24);
            this.comboFacility.StyleController = this.layoutControl1;
            this.comboFacility.TabIndex = 5;
            this.comboFacility.SelectedIndexChanged += new System.EventHandler(this.comboFacility_SelectedIndexChanged);
            // 
            // chartControl
            // 
            ganttDiagram1.AxisX.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            ganttDiagram1.AxisX.NumericScaleOptions.AutoGrid = false;
            ganttDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            ganttDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            ganttDiagram1.AxisY.CrosshairAxisLabelOptions.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            ganttDiagram1.AxisY.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            ganttDiagram1.AxisY.DateTimeScaleOptions.AutoGrid = false;
            ganttDiagram1.AxisY.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
            ganttDiagram1.AxisY.Label.Alignment = DevExpress.XtraCharts.AxisLabelAlignment.Center;
            ganttDiagram1.AxisY.ShowBehind = true;
            ganttDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            ganttDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = ganttDiagram1;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.Location = new System.Drawing.Point(12, 40);
            this.chartControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartControl.Name = "chartControl";
            series1.Name = "Series 1";
            series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.View = overlappedGanttSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.Size = new System.Drawing.Size(776, 488);
            this.chartControl.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 540);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chartControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 492);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(224, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(25, 28);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(25, 28);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(25, 28);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboFacility;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(224, 28);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(224, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(224, 28);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = " 보관소";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(44, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(471, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(309, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboType;
            this.layoutControlItem3.Location = new System.Drawing.Point(249, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(222, 28);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(222, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(222, 28);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "타입";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(44, 18);
            // 
            // GanttChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GanttChart";
            this.Text = "GanttChart";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboFacility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ganttDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(overlappedGanttSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit comboType;
        private DevExpress.XtraEditors.ComboBoxEdit comboFacility;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}