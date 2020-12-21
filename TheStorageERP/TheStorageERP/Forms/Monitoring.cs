using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Data;

namespace TheStorageERP
{
    public partial class Monitoring : XtraForm
    {
        #region Field

        /// <summary>
        /// 난수기
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// 시리즈 배열
        /// </summary>
        private Series[] seriesArray = new Series[3];

        /// <summary>
        /// 인덱스
        /// </summary>
        private int index = 0;

        #endregion

        const int ViewportPointCount = 100000;
        int counter = 0;
        Thread dataAcquisitionThread;
        bool isEnabled = true;
        int lastRawDataIndex = 0;
        List<DataPoint> rawData = new List<DataPoint>();
        ObservableCollection<DataPoint> viewportData = new ObservableCollection<DataPoint>();
        int GB = 60;


        public Monitoring()
        {
            InitializeComponent();

            this.seriesArray[0] = new Series("섭씨온도('C)", ViewType.Line);
            this.seriesArray[1] = new Series("화씨온도('F)", ViewType.Line);
            this.seriesArray[2] = new Series("습도(%)", ViewType.Line);

            this.chartCtrl1.Series.Add(this.seriesArray[1]);
            this.chartCtrl1.Series.Add(this.seriesArray[0]);
            this.chartCtrl1.Series.Add(this.seriesArray[2]);

            this.chartCtrl1.CrosshairEnabled = DefaultBoolean.False;
            XYDiagram diagram = (XYDiagram)this.chartCtrl1.Diagram;

            
            diagram.AxisY.WholeRange.Auto = false;
            diagram.AxisY.WholeRange.MinValue = 0;
            diagram.AxisY.WholeRange.MaxValue = 100;
            //diagram.AxisX.WholeRange.SideMarginsValue = 0;
            diagram.AxisX.WholeRange.EndSideMargin = 0.4;
            

            ConstantLine constantLine = new ConstantLine();

            constantLine.Color = Color.LightYellow;
            constantLine.AxisValue = 0;
            constantLine.ShowInLegend = false;

            diagram.AxisY.ConstantLines.Add(constantLine);
            diagram.EnableAxisXScrolling = false;
            diagram.EnableAxisXZooming = false;

            LineSeriesView seriesView0 = (LineSeriesView)seriesArray[0].View;
            LineSeriesView seriesView1 = (LineSeriesView)seriesArray[1].View;
            LineSeriesView seriesView2 = (LineSeriesView)seriesArray[2].View;
            seriesView0.LastPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint;
            seriesView0.LastPoint.Label.TextPattern = "{V:f2}";            
            seriesView1.LastPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint;
            seriesView1.LastPoint.Label.TextPattern = "{V:f2}";            
            seriesView2.LastPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint;
            seriesView2.LastPoint.Label.TextPattern = "{V:f2}";
            


            #region 이벤트를 설정한다.
            Load += Monitoring_Load;
            #endregion
            

        }




        private void Monitoring_Load(object sender, EventArgs e)
        {
            timer3.Start();
            timer2.Start();
            timer1.Start();

            dataAcquisitionThread = new Thread(new ThreadStart(AcquireData));
            dataAcquisitionThread.Start();

            //차트 제목
            //chartctrl2.Titles.Add(new ChartTitle { Text = "Monitoring" });

            Series series = new Series();
            series.ChangeView(ViewType.Line);
            ((LineSeriesView)series.View).LineStyle.Thickness = 5;
            series.View.Color = Color.Green;

            series.DataSource = viewportData;
            series.DataSourceSorted = true;
            series.ArgumentDataMember = "Argument";
            series.ValueDataMembers.AddRange("Value");
            chartctrl2.Series.Add(series);


            LineSeriesView seriesView = (LineSeriesView)series.View;
            seriesView.LastPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint;
            seriesView.LastPoint.Label.TextPattern = "{V:f1}";

            XYDiagram diagram = (XYDiagram)chartctrl2.Diagram;

            diagram.AxisY.WholeRange.Auto = false;
            diagram.AxisY.WholeRange.MinValue = -GB;
            diagram.AxisY.WholeRange.MaxValue = GB;



            diagram.AxisX.DateTimeScaleOptions.GridSpacing = 1;
            //diagram.AxisX.VisualRange.SetMinMaxValues((DateTime)diagram.AxisX.WholeRange.MaxValue - new TimeSpan(0, 0, 10), ((DateTime)diagram.AxisX.WholeRange.MaxValue).AddSeconds(1));
            //diagram.AxisX.WholeRange.SetMinMaxValues(DateTime.Now.AddSeconds(-1), DateTime.Now);
            diagram.AxisX.Label.TextPattern = "{A : hh:mm:ss}";
            diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            diagram.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            diagram.AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;


            //차트 흔들림
            //diagram.AxisX.VisualRange.SideMarginsValue = 0;


            diagram.DependentAxesYRange = DefaultBoolean.True;
            diagram.AxisY.WholeRange.AlwaysShowZeroLevel = true;
            diagram.EnableAxisXScrolling = false;




        }


        private void ChartCtrl1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.seriesArray[0].Points.Count > 10)
            {
                this.seriesArray[0].Points.RemoveAt(0);
                this.seriesArray[1].Points.RemoveAt(0);
                this.seriesArray[2].Points.RemoveAt(0);
            }

            int a = this.random.Next(25, 30);
            double b = (a * 9 / 5) + 32;
            double c = a / 2;
            //this.seriesArray[0].Points.Add(new SeriesPoint(this.index, this.random.Next(-50, 50)));            
            this.seriesArray[0].Points.Add(new SeriesPoint(this.index, a));

            //this.seriesArray[1].Points.Add(new SeriesPoint(this.index, this.random.Next(25, 30)));
            this.seriesArray[1].Points.Add(new SeriesPoint(this.index, b));

            this.seriesArray[2].Points.Add(new SeriesPoint(this.index, c));

            this.index++;
        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            lock (rawData)
            {
                for (int i = Math.Max(lastRawDataIndex, rawData.Count - ViewportPointCount); i < rawData.Count; i++)
                {
                    viewportData.Add(rawData[i]);

                }
                lastRawDataIndex = rawData.Count;
                while (viewportData.Count > ViewportPointCount)
                    viewportData.RemoveAt(0);

            }
            XYDiagram diagram = (XYDiagram)chartctrl2.Diagram;

            diagram.AxisX.WholeRange.SetMinMaxValues(DateTime.Now.AddSeconds(-30), DateTime.Now);
        }

        void AcquireData()
        {
            while (isEnabled)
            {
                Thread.Sleep(15);
                lock (rawData)
                {
                    for (int i = 0; i < 20; i++)
                        rawData.Add(new DataPoint(DateTime.Now, GenerateValue(counter++)));
                    
                }
            }
        }

        //double GenerateValue(double x) { return Math.Sin(x / 1000.0) * 10 * x + x / 2 + 5; }
        double GenerateValue(double x) { return Math.Sin((x+50)*10000); }

        public class DataPoint
        {
            public DataPoint(DateTime argument, double value)
            {
                Argument = argument;
                Value = value;
            }
            public DateTime Argument { get; set; }
            public double Value { get; set; }
        }


        private void ChartControl2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("G");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            isEnabled = false;
            base.OnClosing(e);
        }
    }
}
