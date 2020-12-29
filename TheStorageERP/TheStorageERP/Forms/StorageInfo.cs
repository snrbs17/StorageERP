using DevExpress.XtraMap;
using DevExpress.XtraTreeMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheStorageERP.Client;

namespace TheStorageERP
{
    public partial class StorageInfo : Form
    {
        //const string csvFilepath = @"C:\Users\kccistc\Desktop\StorageERP\Seoul.csv";

        ColorizerColorItem[] colorItems = Factors.Items1;
        ShapefileDataAdapter adapter = new ShapefileDataAdapter();
        public StorageInfo()
        {
            InitializeComponent();
        }

        List<fakeDB> fakeDBs = new List<fakeDB>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            fakeDBs.Add(new fakeDB() { Name = "강서구", Sale = 1 });
            fakeDBs.Add(new fakeDB() { Name = "강남구", Sale = 5 });
            fakeDBs.Add(new fakeDB() { Name = "서초구", Sale = 10 });
            fakeDBs.Add(new fakeDB() { Name = "강북구", Sale = 20 });
            fakeDBs.Add(new fakeDB() { Name = "강동구", Sale = 15 });
            fakeDBs.Add(new fakeDB() { Name = "종로구", Sale = 7 });
            fakeDBs.Add(new fakeDB() { Name = "노원구", Sale = 40 });

            svgMapControl.CenterPoint = new GeoPoint(37.51243, 126.96995);
            svgMapControl.ZoomLevel = 10;

            CreateDB(fakeDBs);


            Uri baseUri = new Uri(System.Reflection.Assembly.GetExecutingAssembly().Location);
            adapter.FileUri = new Uri(baseUri, "../../SvgFile/Seoul.shp");
            svgMapControl.Layers.Add(new VectorItemsLayer
            {
                Data = adapter,
                Colorizer = CreatorColorizer(doubleList1, attribute2),
                //ToolTipPattern = "{VAL1}"
                ShapeTitlesPattern = "{EMD_ENG_NM}",
                ShapeTitlesVisibility = VisibilityMode.Auto
            });

            svgMapControl.Layers.Add(new ImageLayer()
            {
                DataProvider = new BingMapDataProvider()
                {
                    BingKey = "AubFnqHZplmeCYwVruQ5HelHfa6Xk92I0BvwGlraSadj2NiNuNQ3aAldhzn1apNb"
                }
            });


        }

        private MapColorizer CreatorColorizer(double[] doubleList, string attribute)
        {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.ColorItems.AddRange(colorItems);

            colorizer.RangeStops.AddRange(doubleList);

            colorizer.ValueProvider = new ShapeAttributeValueProvider() { AttributeName = attribute };

            return colorizer;
        }

        double[] doubleList2 ={11110000,
11140000,11170000,11200000,11215000,11230000,11260000,11290000,11305000,11320000,11350000,11380000,11410000,11440000,11470000,11500000,11530000,11545000,11560000,11590000,11620000,11650000,11680000,11710000,11740000 };
        double[] doubleList1 = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
        string attribute1 = "EMD_CD";
        string attribute2 = "VAL1";



        private void CreateDB(List<fakeDB> fakeDBs)
        {
            //var fakeDB = Clients.FakeAccountInfoes.GetFakeAccountInfoesAsync().Result;

            TreeMapFlatDataAdapter adapter = new TreeMapFlatDataAdapter
            {
                DataSource = fakeDBs,
                LabelDataMember = "Name",
                ValueDataMember = "Sale"
            };

            treeMapControl.DataAdapter = adapter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorItems = Factors.Items1;
            svgMapControl.Layers.Add(new VectorItemsLayer
            {
                Data = adapter,
                Colorizer = CreatorColorizer(doubleList2, attribute1)
            });

        }

        private void button4_Click(object sender, EventArgs e)
        {

            colorItems = Factors.Items2;
            svgMapControl.Layers.Add(new VectorItemsLayer
            {
                Data = adapter,
                Colorizer = CreatorColorizer(doubleList1, "VAL1")
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorItems = Factors.Items3;
            svgMapControl.Layers.Add(new VectorItemsLayer
            {
                Data = adapter,
                Colorizer = CreatorColorizer(doubleList1, "VAL2")
            });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorItems = Factors.Items4;
            svgMapControl.Layers.Add(new VectorItemsLayer
            {
                Data = adapter,
                Colorizer = CreatorColorizer(doubleList1, "VAL3")
            });

        }

        //List<BillionaireInfo> CreateBillionaireInfos()
        //{
        //    List<BillionaireInfo> infos = new List<BillionaireInfo> {
        //        new BillionaireInfo {Name = "Bill Gates",           NetWorth = 79.2,    Age = 60,   Residence = "United States",  Source = "Microsoft"},
        //        new BillionaireInfo {Name = "Carlos Slim Helu",     NetWorth = 77.1,    Age = 75,   Residence = "Mexico",         Source = "telecom"},
        //        new BillionaireInfo {Name = "Warren Buffett",       NetWorth = 72.7,    Age = 85,   Residence = "United States",  Source = "Berkshire Hathaway"},
        //        new BillionaireInfo {Name = "Amancio Ortega",       NetWorth = 64.5,    Age = 79,   Residence = "Spain",          Source = "Zara"},
        //        new BillionaireInfo {Name = "Larry Ellison",        NetWorth = 54.3,    Age = 71,   Residence = "United States",  Source = "Oracle"},
        //        new BillionaireInfo {Name = "Charles Koch",         NetWorth = 42.9,    Age = 79,   Residence = "United States",  Source = "diversified"},
        //        new BillionaireInfo {Name = "David Koch",           NetWorth = 42.9,    Age = 75,   Residence = "United States",  Source = "diversified"},
        //        new BillionaireInfo {Name = "Christy Walton",       NetWorth = 41.7,    Age = 60,   Residence = "United States",  Source = "Wal-Mart"},
        //        new BillionaireInfo {Name = "Jim Walton",           NetWorth = 40.6,    Age = 67,   Residence = "United States",  Source = "Wal-Mart"},
        //        new BillionaireInfo {Name = "Liliane Bettencourt",  NetWorth = 40.1,    Age = 93,   Residence = "France",         Source = "L'Oreal"}
        //    };
        //    return infos;
        //}

    }

    public class fakeDB
    {
        public string Name { get; set; }
        public int Sale { get; set; }

        //public fakeDB(string _name, int _sale)
        //{
        //    Name = _name;
        //    Sale = _sale;
        //}
    }
}

