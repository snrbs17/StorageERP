using DevExpress.Map.Dashboard;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheStorageERP.Forms
{
    public partial class SeoulMap : Form
    {
        public SeoulMap()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            Uri baseUri = new Uri(System.Reflection.Assembly.GetExecutingAssembly().Location);
            ShapefileDataAdapter adapter = new ShapefileDataAdapter();
            adapter.FileUri = new Uri(baseUri, "../../SvgFile/Seoul.shp");
            mapControl1.Layers.Add(new VectorItemsLayer
            {
                Data = adapter
            });

            mapControl1.Layers.Add(new ImageLayer()
            {
                DataProvider = new BingMapDataProvider()
                {
                    BingKey = "AubFnqHZplmeCYwVruQ5HelHfa6Xk92I0BvwGlraSadj2NiNuNQ3aAldhzn1apNb"
                }
            });

            
            mapControl1.Layers.Add(new VectorItemsLayer()
            {
                
            });
        }
    }
}
