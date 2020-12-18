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

namespace TheStorageERP
{
    public partial class StorageInfo : Form
    {
        const string csvFilepath = @"C:\Users\kccistc\Desktop\StorageERP\Seoul.csv";

        public StorageInfo()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            svgMapControl.ZoomLevel = 5;

            var list = LoadData(csvFilepath);

            TreeMapFlatDataAdapter dataAdapter = treeMapControl3.DataAdapter as TreeMapFlatDataAdapter;
            dataAdapter.DataSource = list;
        }

        private List<SeoulTown> LoadData(string path)
        {
            var reader = new StreamReader(File.OpenRead(path));
            var list = new List<SeoulTown>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                list.Add(new SeoulTown(int.Parse(values[0]), values[1],/* values[2], values[3],*/ int.Parse(values[2])));
            }
            return list;
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
}
public class SeoulTown
{
    public int emd_cd { get; }
    public string emd_eng_nm { get; }
    //public string name { get; }
    //public string emd_kor_nm { get; }
    public int val1 { get; }

    public SeoulTown(int emd_cd, string emd_eng_nm,/* string name, string emd_kor_nm,*/ int val1)
    {
        this.emd_cd = emd_cd;
        this.emd_eng_nm = emd_eng_nm;
        //this.name = name;
        //this.emd_kor_nm = emd_eng_nm;
        this.val1 = val1;
    }
}

