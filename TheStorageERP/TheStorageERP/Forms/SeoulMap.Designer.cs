
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
            this.miniMapVectorItemsLayer1 = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(37.55D, 127D);
            this.mapControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MaxZoomLevel = 18D;
            dynamicMiniMapBehavior1.MaxZoomLevel = 18D;
            dynamicMiniMapBehavior1.MinZoomLevel = 10D;
            dynamicMiniMapBehavior1.ZoomOffset = -2D;
            miniMap1.Behavior = dynamicMiniMapBehavior1;
            miniMap1.Layers.Add(this.miniMapVectorItemsLayer1);
            this.mapControl1.MiniMap = miniMap1;
            this.mapControl1.MinZoomLevel = 10D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(800, 450);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 10D;
            // 
            // SeoulMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapControl1);
            this.Name = "SeoulMap";
            this.Text = "SeoulMap";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.MiniMapVectorItemsLayer miniMapVectorItemsLayer1;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
    }
}