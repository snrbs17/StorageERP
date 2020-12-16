using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheStorageERP.Client;

namespace TheStorageERP
{
    public partial class FinancialStatementViewer : Form
    {

        Func<FakeAccountInfo, int> SelectTimeScope;
        int timeSelectFlag;
        public FinancialStatementViewer()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            radioButton1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = Dao.Dao.fakeAccountInfo.GetInfoReorganized(SelectTimeScope);
            FinancialStatement finance = new FinancialStatement();
            finance.DataSource = list;

            finance.tableCell15.TextFormatString = timeSelectFlag == 0 ? "Day {0}" : "Month {0}";
            ReportPrintTool printTool = new ReportPrintTool(finance);

            //objectData
            printTool.ShowPreview();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SelectTimeScope = x => x.Date.Day;
            
            timeSelectFlag = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SelectTimeScope = x => x.Date.Month;
            timeSelectFlag = 1;
        }
    }
    
}
