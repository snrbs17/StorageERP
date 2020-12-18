using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheStorageERP.Entities;

namespace TheStorageERP.Forms
{
    public partial class BreakEvenAnalysis : Form
    {
        public BreakEvenAnalysis()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            /*var info = new InfoReorganized();
            Type type = info.GetType();
            PropertyInfo[] properties = type.GetProperties();
            List<SeriesPoint> series = new List<SeriesPoint>();
            //string asdf = nameof(InfoReorganized.Advertising);
            foreach (var x in properties)
            {
                series.Add(new SeriesPoint(x.Name, 3));

            }*/

            var list = Dao.Dao.fakeAccountInfo.GetInfoReorganized().ToList();

            //chartControl2.Series[0].Points.AddRange(series.ToArray());
            chartControl2.Titles.Add(new ChartTitle() { Text = "Profit&Loss" });
            chartControl2.Series[0].DataSource = DataPoint.GetDataPoints(list[0]);
            chartControl2.Series[0].ArgumentDataMember = "Argument";
            chartControl2.Series[0].ValueDataMembers.AddRange(new string[] { "Value" });
            //chartControl2.Series[0].ArgumentDataMember = SeriesPoint.ArgumentProperty;
            chartControl2.Series[0].LegendTextPattern = "{A}";

            //SeriesPoint[] seriesPoints;
            for (int i = 0; i < 3; i++)
                chartControl1.Series.Add(new Series($"series{i}", ViewType.Line));
            foreach (var x in list)
            {
                chartControl1.Series[0].Points.Add(new SeriesPoint(x.InfoId.ToString(), x.GrossProfit));

                chartControl1.Series[1].Points.Add(new SeriesPoint(x.InfoId.ToString(), (x.Sales + x.Wages + x.Rent)));

                chartControl1.Series[2].Points.Add(new SeriesPoint(x.InfoId.ToString(), (x.OtherSupplies + x.Utilities + x.Insurance + x.Maintenance)));

            }

            vGridControl1.DataSource = Dao.Dao.fakeAccountInfo.GetInfoReorganized()
                .Where(x => x.InfoId == 0)
                .Select(x => x).ToList();

            vGridControl2.DataSource = Dao.Dao.InfoSummarized.GetInfoes();
        }



        public class DataPoint
        {
            public string Argument { get; set; }
            public int Value { get; set; }

            public static List<DataPoint> GetDataPoints(InfoReorganized info)
            {
                return new List<DataPoint> {
                //new DataPoint { Argument = "InfoId", Value = info.InfoId },
                new DataPoint { Argument = "Sales", Value = info.Sales},
                new DataPoint { Argument = "OtherRevenues", Value = info.OtherRevenues},
                new DataPoint { Argument = "SalesReturns", Value = info.SalesReturns},
                new DataPoint { Argument = "GrossProfit", Value = info.GrossProfit},
                new DataPoint { Argument = "Wages", Value = info.Wages},
                new DataPoint { Argument = "Depreciation", Value = info.Depreciation},
                new DataPoint { Argument = "OtherSupplies", Value = info.OtherSupplies},
                new DataPoint { Argument = "Utilities", Value = info.Utilities},
                new DataPoint { Argument = "Insurance", Value = info.Insurance},
                new DataPoint { Argument = "Maintenance", Value = info.Maintenance},
                new DataPoint { Argument = "Advertising", Value = info.Advertising},
                new DataPoint { Argument = "OtherExpenses", Value = info.OtherExpenses}
                };
            }
        }
        private void chartControl2_Click(object sender, EventArgs e)
        {
           
        }
        private void vGridControl1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
           
            double TotalBudget;
            for (int i = 0; i < vGridControl1.RecordCount; i++)
            {
                TotalBudget = 0;
                foreach (BaseRow row in vGridControl1.Rows["budget"].ChildRows)
                {
                    for (int j = 0; j < row.RowPropertiesCount; j++)
                    {
                        TotalBudget += Convert.ToDouble(row.GetRowProperties(j).Value);
                    }
                }
                vGridControl1.SetCellValue(vGridControl1.Rows["Total"], i, TotalBudget);
            }
        }
        private void vGridControl2_Click(object sender, MouseEventArgs e)
        {
            var hitInfo = vGridControl2.CalcHitInfo(e.Location).RecordIndex;

            if(hitInfo <0)
            {
                return;
            }

            VGridControl cn = sender as VGridControl;
            string a = cn.FocusedRow.Name;

            string q;
            foreach (BaseRow row in vGridControl2.Rows)
            {
                if (row is EditorRow)
                {
                    if (a == row.Name)
                    {
                        q = cn.GetCellDisplayText(row, hitInfo).ToString();
                        vGridControl1.DataSource = Dao.Dao.fakeAccountInfo.GetInfoReorganized()
                                                    .Where(x => x.InfoId == int.Parse(q))
                                                    .Select(x => x).ToList();
                    }

                }
            }
        }

        private void vGridControl2_SelectedChanged(object sender, DevExpress.XtraVerticalGrid.Events.SelectedChangedEventArgs e)
        {
            MessageBox.Show("asdf");
        }

        private void vGridView2_SelectChanged(object sender, MouseEventArgs e)
        {
            
            MessageBox.Show("");
        }

        private void vGridControl2_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void vGridControl2_Click_1(object sender, EventArgs e)
        {
            DataGridCell dataGridCell = (DataGridCell)sender;
            MessageBox.Show(dataGridCell.ColumnNumber.ToString());
        }

        
    }
}
