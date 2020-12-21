
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
            DevExpress.XtraMap.ChoroplethColorizer choroplethColorizer1 = new DevExpress.XtraMap.ChoroplethColorizer();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem1 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem2 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem3 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem4 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem5 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem6 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem7 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem8 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem9 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem10 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem11 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem12 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem13 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem14 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem15 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem16 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem17 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem18 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem19 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem20 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem21 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem22 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem23 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem24 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem25 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution1 = new DevExpress.XtraMap.LinearRangeDistribution();
            DevExpress.XtraMap.ShapeAttributeValueProvider shapeAttributeValueProvider1 = new DevExpress.XtraMap.ShapeAttributeValueProvider();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.miniMapVectorItemsLayer1 = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.shapefileDataAdapter2 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(37.55D, 127D);
            this.mapControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
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
            this.miniMapVectorItemsLayer1.Data = this.shapefileDataAdapter1;
            this.shapefileDataAdapter1.FileUri = new System.Uri(@"./../SvgFile/Seoul.shp", System.UriKind.Relative);
            this.bingMapDataProvider1.BingKey = "AubFnqHZplmeCYwVruQ5HelHfa6Xk92I0BvwGlraSadj2NiNuNQ3aAldhzn1apNb";
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.shapefileDataAdapter2.FileUri = new System.Uri(@"./../SvgFile/Seoul.shp", System.UriKind.Relative);
            colorizerColorItem1.Color = System.Drawing.Color.Maroon;
            colorizerColorItem2.Color = System.Drawing.Color.LightCoral;
            colorizerColorItem3.Color = System.Drawing.Color.OrangeRed;
            colorizerColorItem4.Color = System.Drawing.Color.Chocolate;
            colorizerColorItem5.Color = System.Drawing.Color.NavajoWhite;
            colorizerColorItem6.Color = System.Drawing.Color.LightBlue;
            colorizerColorItem7.Color = System.Drawing.Color.Gold;
            colorizerColorItem8.Color = System.Drawing.Color.Olive;
            colorizerColorItem9.Color = System.Drawing.Color.GreenYellow;
            colorizerColorItem10.Color = System.Drawing.Color.LightGreen;
            colorizerColorItem11.Color = System.Drawing.Color.Aquamarine;
            colorizerColorItem12.Color = System.Drawing.Color.MediumSpringGreen;
            colorizerColorItem13.Color = System.Drawing.Color.CadetBlue;
            colorizerColorItem14.Color = System.Drawing.Color.DodgerBlue;
            colorizerColorItem15.Color = System.Drawing.Color.LightSteelBlue;
            colorizerColorItem16.Color = System.Drawing.Color.MidnightBlue;
            colorizerColorItem17.Color = System.Drawing.Color.MediumOrchid;
            colorizerColorItem18.Color = System.Drawing.Color.Violet;
            colorizerColorItem19.Color = System.Drawing.Color.Fuchsia;
            colorizerColorItem20.Color = System.Drawing.Color.SlateGray;
            colorizerColorItem21.Color = System.Drawing.Color.Crimson;
            colorizerColorItem22.Color = System.Drawing.Color.Pink;
            colorizerColorItem23.Color = System.Drawing.Color.RosyBrown;
            colorizerColorItem24.Color = System.Drawing.Color.PaleGreen;
            colorizerColorItem25.Color = System.Drawing.Color.DarkSlateBlue;
            choroplethColorizer1.ColorItems.Add(colorizerColorItem1);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem2);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem3);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem4);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem5);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem6);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem7);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem8);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem9);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem10);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem11);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem12);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem13);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem14);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem15);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem16);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem17);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem18);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem19);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem20);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem21);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem22);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem23);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem24);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem25);
            choroplethColorizer1.RangeDistribution = linearRangeDistribution1;
            choroplethColorizer1.RangeStops.Add(11110000D);
            choroplethColorizer1.RangeStops.Add(11140000D);
            choroplethColorizer1.RangeStops.Add(11170000D);
            choroplethColorizer1.RangeStops.Add(11200000D);
            choroplethColorizer1.RangeStops.Add(11215000D);
            choroplethColorizer1.RangeStops.Add(11230000D);
            choroplethColorizer1.RangeStops.Add(11260000D);
            choroplethColorizer1.RangeStops.Add(11290000D);
            choroplethColorizer1.RangeStops.Add(11305000D);
            choroplethColorizer1.RangeStops.Add(11320000D);
            choroplethColorizer1.RangeStops.Add(11350000D);
            choroplethColorizer1.RangeStops.Add(11380000D);
            choroplethColorizer1.RangeStops.Add(11410000D);
            choroplethColorizer1.RangeStops.Add(11440000D);
            choroplethColorizer1.RangeStops.Add(11470000D);
            choroplethColorizer1.RangeStops.Add(11500000D);
            choroplethColorizer1.RangeStops.Add(11530000D);
            choroplethColorizer1.RangeStops.Add(11545000D);
            choroplethColorizer1.RangeStops.Add(11560000D);
            choroplethColorizer1.RangeStops.Add(11590000D);
            choroplethColorizer1.RangeStops.Add(11620000D);
            choroplethColorizer1.RangeStops.Add(11650000D);
            choroplethColorizer1.RangeStops.Add(11680000D);
            choroplethColorizer1.RangeStops.Add(11710000D);
            choroplethColorizer1.RangeStops.Add(11740000D);
            shapeAttributeValueProvider1.AttributeName = "emd_cd";
            choroplethColorizer1.ValueProvider = shapeAttributeValueProvider1;
            this.vectorItemsLayer1.Colorizer = choroplethColorizer1;
            this.vectorItemsLayer1.Data = this.shapefileDataAdapter2;
            this.vectorItemsLayer1.ShapeTitlesPattern = "{emd_eng_nm}";
            this.vectorItemsLayer1.ToolTipPattern = "{emd_cd}";
            // 
            // SeoulMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapControl1);
            this.Name = "SeoulMap";
            this.Text = "SeoulMap";
            this.Load += new System.EventHandler(this.SeoulMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.MiniMapVectorItemsLayer miniMapVectorItemsLayer1;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter2;
    }
}