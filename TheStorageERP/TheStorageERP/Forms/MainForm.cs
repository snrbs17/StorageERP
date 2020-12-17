using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheStorageERP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CreateForm(Form form)
        {
            
            form.MdiParent = this;
            form.Show();
        }

        private void StorageInfoBtn(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateForm(new StorageInfo());
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateForm(new BingMapForm());

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateForm(new GanttChart());
        }
    }
}
