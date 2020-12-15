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

        private void StorageMapBtn(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateForm(new StorageMap());
        }
    }
}
