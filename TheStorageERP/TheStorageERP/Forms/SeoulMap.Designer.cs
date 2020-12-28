
namespace TheStorageERP.Forms
{
    partial class SeoulMap
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
            DevExpress.XtraMap.MiniMap miniMap1 = new DevExpress.XtraMap.MiniMap();
            DevExpress.XtraMap.DynamicMiniMapBehavior dynamicMiniMapBehavior1 = new DevExpress.XtraMap.DynamicMiniMapBehavior();
            DevExpress.XtraTreeMap.HatchFillStyle hatchFillStyle1 = new DevExpress.XtraTreeMap.HatchFillStyle();
            DevExpress.XtraTreeMap.HatchFillStyle hatchFillStyle2 = new DevExpress.XtraTreeMap.HatchFillStyle();
            this.miniMapVectorItemsLayer1 = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.treeMapControl1 = new DevExpress.XtraTreeMap.TreeMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(37.55D, 127D);
            this.mapControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.mapControl1.Location = new System.Drawing.Point(337, 0);
            this.mapControl1.MaxZoomLevel = 18D;
            dynamicMiniMapBehavior1.MaxZoomLevel = 18D;
            dynamicMiniMapBehavior1.MinZoomLevel = 10D;
            dynamicMiniMapBehavior1.ZoomOffset = -2D;
            miniMap1.Behavior = dynamicMiniMapBehavior1;
            miniMap1.Layers.Add(this.miniMapVectorItemsLayer1);
            this.mapControl1.MiniMap = miniMap1;
            this.mapControl1.MinZoomLevel = 10D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(463, 450);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 10D;
            // 
            // treeMapControl1
            // 
            this.treeMapControl1.Appearance.GroupStyle.TextGlowColor = System.Drawing.Color.Empty;
            this.treeMapControl1.Appearance.HighlightedLeafStyle.FillStyle = hatchFillStyle1;
            this.treeMapControl1.Appearance.SelectedLeafStyle.FillStyle = hatchFillStyle2;
            this.treeMapControl1.Location = new System.Drawing.Point(12, 12);
            this.treeMapControl1.Name = "treeMapControl1";
            this.treeMapControl1.Size = new System.Drawing.Size(319, 426);
            this.treeMapControl1.TabIndex = 1;
            // 
            // SeoulMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeMapControl1);
            this.Controls.Add(this.mapControl1);
            this.Name = "SeoulMap";
            this.Text = "SeoulMap";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.MiniMapVectorItemsLayer miniMapVectorItemsLayer1;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraTreeMap.TreeMapControl treeMapControl1;
    }
}