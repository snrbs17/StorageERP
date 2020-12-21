
namespace TheStorageERP
{
    partial class StorageInfo
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
            DevExpress.XtraTreeMap.HatchFillStyle hatchFillStyle1 = new DevExpress.XtraTreeMap.HatchFillStyle();
            DevExpress.XtraTreeMap.HatchFillStyle hatchFillStyle2 = new DevExpress.XtraTreeMap.HatchFillStyle();
            DevExpress.XtraTreeMap.TreeMapFlatDataAdapter treeMapFlatDataAdapter1 = new DevExpress.XtraTreeMap.TreeMapFlatDataAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.svgMapControl = new DevExpress.XtraMap.MapControl();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.treeMapControl = new DevExpress.XtraTreeMap.TreeMapControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.button1 = new System.Windows.Forms.Button();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.button2 = new System.Windows.Forms.Button();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.button3 = new System.Windows.Forms.Button();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.button4 = new System.Windows.Forms.Button();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.infoReorganizedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoReorganizedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.button4);
            this.layoutControl1.Controls.Add(this.button3);
            this.layoutControl1.Controls.Add(this.button2);
            this.layoutControl1.Controls.Add(this.button1);
            this.layoutControl1.Controls.Add(this.svgMapControl);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.treeMapControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1072, 630);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // svgMapControl
            // 
            this.svgMapControl.Layers.Add(this.vectorItemsLayer1);
            this.svgMapControl.Location = new System.Drawing.Point(403, 12);
            this.svgMapControl.Name = "svgMapControl";
            this.svgMapControl.Size = new System.Drawing.Size(657, 577);
            this.svgMapControl.TabIndex = 12;
            this.svgMapControl.ZoomLevel = 1.1D;
            this.vectorItemsLayer1.Data = this.shapefileDataAdapter1;
            this.shapefileDataAdapter1.FileUri = new System.Uri("C:\\Users\\kccistc\\Desktop\\StorageERP\\Seoul.shp", System.UriKind.Absolute);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(387, 18);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "보관소별 매출현황";
            // 
            // treeMapControl
            // 
            this.treeMapControl.Appearance.GroupStyle.TextGlowColor = System.Drawing.Color.Empty;
            this.treeMapControl.Appearance.HighlightedLeafStyle.FillStyle = hatchFillStyle1;
            this.treeMapControl.Appearance.SelectedLeafStyle.FillStyle = hatchFillStyle2;
            this.treeMapControl.DataAdapter = treeMapFlatDataAdapter1;
            this.treeMapControl.Location = new System.Drawing.Point(12, 34);
            this.treeMapControl.Name = "treeMapControl";
            this.treeMapControl.Size = new System.Drawing.Size(387, 584);
            this.treeMapControl.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem9,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1072, 630);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.treeMapControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(391, 588);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 22);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(18, 22);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(391, 22);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.svgMapControl;
            this.layoutControlItem9.Location = new System.Drawing.Point(391, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(661, 581);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.button1;
            this.layoutControlItem1.Location = new System.Drawing.Point(391, 581);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(165, 29);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.button2;
            this.layoutControlItem3.Location = new System.Drawing.Point(721, 581);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(165, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(898, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.button3;
            this.layoutControlItem5.Location = new System.Drawing.Point(886, 581);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(166, 29);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.button4;
            this.layoutControlItem6.Location = new System.Drawing.Point(556, 581);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(165, 29);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // infoReorganizedBindingSource
            // 
            this.infoReorganizedBindingSource.DataSource = typeof(TheStorageERP.Entities.InfoReorganized);
            // 
            // StorageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 630);
            this.Controls.Add(this.layoutControl1);
            this.Name = "StorageInfo";
            this.Text = "StorageInfo";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoReorganizedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTreeMap.TreeMapControl treeMapControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraMap.MapControl svgMapControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.BindingSource infoReorganizedBindingSource;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}