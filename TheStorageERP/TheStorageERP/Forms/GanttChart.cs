using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
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
    public partial class GanttChart : XtraForm
    {
        public GanttChart()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);



            Series series = new Series("asd", ViewType.Gantt);

            series.ValueScaleType = ScaleType.DateTime;

            series.Points.AddRange(new SeriesPoint[] { new SeriesPoint("storageNum1", new DateTime[] { new DateTime(2019, 02, 02, 07, 06, 01), new DateTime(2019, 02, 03, 15, 06, 01) }), new SeriesPoint("storageNum1", new DateTime[] { new DateTime(2019, 02, 05, 07, 06, 01), new DateTime(2019, 02, 06, 07, 06, 01) }) });
            series.Points.Add(new SeriesPoint("storageNum2", new DateTime[] { new DateTime(2019, 02, 01, 07, 06, 01), new DateTime(2019, 02, 03, 10, 06, 01) }));
            series.Points.Add(new SeriesPoint("storageNum3", new DateTime[] { new DateTime(2019, 02, 04, 09, 06, 01), new DateTime(2019, 02, 06, 13, 06, 01) }));


            chartControl.Series.AddRange(series);

            GanttDiagram myDiagram = (GanttDiagram)chartControl.Diagram;

            _ = myDiagram.AxisX.Title.Visibility;
            myDiagram.AxisX.Title.Text = "Tasks";
            //myDiagram.AxisY.Title.Visible = true;
            myDiagram.AxisY.Interlaced = true;
            myDiagram.AxisY.GridSpacing = 10;
            myDiagram.AxisY.Label.Angle = -30;
            myDiagram.AxisY.DateTimeOptions.Format = DateTimeFormat.MonthAndDay;
            //myDiagram.AxisY.DateTimeOptions.Format = DateTimeFormat.Custom;
            //myDiagram.AxisY.DateTimeOptions.FormatString = "yyyy-MM-dd hh:mm:ss";

        }
    }
}
