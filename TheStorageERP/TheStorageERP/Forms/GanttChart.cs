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
using TheStorageERP.Client;

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

            startChart();

            GanttDiagram myDiagram = (GanttDiagram)chartControl.Diagram;

            myDiagram.AxisX.Title.Visible = true;
            myDiagram.AxisX.Title.Text = "보관함 번호";
            myDiagram.AxisY.Interlaced = true;
            myDiagram.AxisY.GridSpacing = 10;
            myDiagram.AxisY.Label.Angle = -30;
            myDiagram.AxisY.DateTimeOptions.Format = DateTimeFormat.Custom;
            myDiagram.AxisY.DateTimeOptions.FormatString = "yy/MM/dd hh:mm";  
        }

        private void startChart()
        {
            chartControl.Series.Clear();
            Series[] se = new Series[] { };

            int typeText = 0;
            if (comboType.Text == "전체")
            {
                typeText = 3;
            }
            else if (comboType.Text == "일반")
            {
                typeText = 2;
            }
            else if (comboType.Text == "신선")
            {
                typeText = 1;
            }


            int facilityId = getFacilityId(comboFacility.Text);

            CreateGanttChartSeries(ref se, typeText, facilityId);

            chartControl.Series.AddRange(se);
        }

        private int getFacilityId(string text)
        {
            var facility = Clients.Facilities.GetFacilitiesAsync().Result;
            var region = Clients.Regions.GetRegionsAsync().Result;

            var facilityId = from x in facility
                             join y in region on x.RegionId equals y.RegionId
                             where y.Town == text
                             select x.FacilityId;

            var facId = facilityId.ToList();

            return facId[0];
        }

        private void CreateGanttChartSeries(ref Series[] se, int typeText, int facilityId)
        {
            var storages = Clients.Storages.GetStoragesAsync().Result;
            var fares = Clients.Fares.GetFaresAsync().Result;
            var storageTypes = Clients.StorageTypes.GetStorageTypesAsync().Result;
            var purchaseItems = Clients.PurchaseItems.GetPurchaseItemsAsync().Result;
            
            var seriesData = from x in storages
                       join y in fares on x.FareId equals y.FareId
                       join z in storageTypes on y.StorageTypeId equals z.StorageTypeId
                       join a in purchaseItems on x.StorageId equals a.StorageId
                       where x.FacilityId == facilityId
                       select new Test
                       { 
                            storageId = x.StorageId,
                            InTime = a.InTime,
                            OutTime = a.OutTime,
                            storageType = z.StorageTypeId
                       };

            Series series = new Series("일반", ViewType.Gantt);
            series.ValueScaleType = ScaleType.DateTime;

            Series series2 = new Series("신선", ViewType.Gantt);
            series2.ValueScaleType = ScaleType.DateTime;

            List<Test> list = seriesData.ToList();
            List<Test> basic = new List<Test>();
            List<Test> fridge = new List<Test>();

            checkType(out basic, out fridge, list);

            if (typeText == 3)
            {
                //for (int i = 0; i < list.Count(); i++)
                //{
                //   series.Points.Add(new SeriesPoint($"{list[i].storageId}", new DateTime[] 
                //   { new DateTime(list[i].InTime.Year, list[i].InTime.Month, list[i].InTime.Day, list[i].InTime.Hour, list[i].InTime.Minute, list[i].InTime.Second), 
                //       new DateTime(list[i].OutTime.Year, list[i].OutTime.Month, list[i].OutTime.Day, list[i].OutTime.Hour, list[i].OutTime.Minute, list[i].OutTime.Second) }));
                //}

                for (int i = 0; i < basic.Count(); i++)
                {
                    series.Points.Add(new SeriesPoint($"{basic[i].storageId}", new DateTime[]
                    { new DateTime(basic[i].InTime.Year, basic[i].InTime.Month, basic[i].InTime.Day, basic[i].InTime.Hour, basic[i].InTime.Minute, basic[i].InTime.Second),
                       new DateTime(basic[i].OutTime.Year, basic[i].OutTime.Month, basic[i].OutTime.Day, basic[i].OutTime.Hour, basic[i].OutTime.Minute, basic[i].OutTime.Second) }));
                }

                for (int i = 0; i < fridge.Count(); i++)
                {
                    series2.Points.Add(new SeriesPoint($"{fridge[i].storageId}", new DateTime[]
                    { new DateTime(fridge[i].InTime.Year, fridge[i].InTime.Month, fridge[i].InTime.Day, fridge[i].InTime.Hour, fridge[i].InTime.Minute, fridge[i].InTime.Second),
                       new DateTime(fridge[i].OutTime.Year, fridge[i].OutTime.Month, fridge[i].OutTime.Day, fridge[i].OutTime.Hour, fridge[i].OutTime.Minute, fridge[i].OutTime.Second) }));
                }
            }
            else if (typeText == 2)
            {
                for (int i = 0; i < basic.Count(); i++)
                {
                    series.Points.Add(new SeriesPoint($"{basic[i].storageId}", new DateTime[]
                    { new DateTime(basic[i].InTime.Year, basic[i].InTime.Month, basic[i].InTime.Day, basic[i].InTime.Hour, basic[i].InTime.Minute, basic[i].InTime.Second),
                       new DateTime(basic[i].OutTime.Year, basic[i].OutTime.Month, basic[i].OutTime.Day, basic[i].OutTime.Hour, basic[i].OutTime.Minute, basic[i].OutTime.Second) }));
                }
            }
            else if (typeText == 1)
            {
                for (int i = 0; i < fridge.Count(); i++)
                {
                    series2.Points.Add(new SeriesPoint($"{fridge[i].storageId}", new DateTime[]
                    { new DateTime(fridge[i].InTime.Year, fridge[i].InTime.Month, fridge[i].InTime.Day, fridge[i].InTime.Hour, fridge[i].InTime.Minute, fridge[i].InTime.Second),
                       new DateTime(fridge[i].OutTime.Year, fridge[i].OutTime.Month, fridge[i].OutTime.Day, fridge[i].OutTime.Hour, fridge[i].OutTime.Minute, fridge[i].OutTime.Second) }));
                }
            }


            se = new Series[] { series, series2 };


            //Series series = new Series("일반", ViewType.Gantt);

            //series.ValueScaleType = ScaleType.DateTime;

            //series.Points.AddRange(new SeriesPoint[] { new SeriesPoint($"{a}", new DateTime[] { new DateTime(2019, 02, 02, 07, 06, 01), new DateTime(2019, 02, 03, 15, 06, 01) }), new SeriesPoint("storageNum1", new DateTime[] { new DateTime(2019, 02, 05, 07, 06, 01), new DateTime(2019, 02, 06, 07, 06, 01) }) });
            //series.Points.Add(new SeriesPoint("storageNum2", new DateTime[] { new DateTime(2019, 02, 01, 07, 06, 01), new DateTime(2019, 02, 03, 10, 06, 01) }));
            //series.Points.Add(new SeriesPoint("storageNum3", new DateTime[] { new DateTime(2019, 02, 04, 09, 06, 01), new DateTime(2019, 02, 06, 13, 06, 01) }));

            //se = new Series[]{series};
            //if (typeText == "전체")
            //{
            //    for (int i = 0; i < a; i++)
            //    {

            //    }
            //    Series series = new Series("일반", ViewType.Gantt);

            //    series.ValueScaleType = ScaleType.DateTime;

            //    series.Points.AddRange(new SeriesPoint[] { new SeriesPoint("storageNum1", new DateTime[] { new DateTime(2019, 02, 02, 07, 06, 01), new DateTime(2019, 02, 03, 15, 06, 01) }), new SeriesPoint("storageNum1", new DateTime[] { new DateTime(2019, 02, 05, 07, 06, 01), new DateTime(2019, 02, 06, 07, 06, 01) }) });
            //    series.Points.Add(new SeriesPoint("storageNum2", new DateTime[] { new DateTime(2019, 02, 01, 07, 06, 01), new DateTime(2019, 02, 03, 10, 06, 01) }));
            //    series.Points.Add(new SeriesPoint("storageNum3", new DateTime[] { new DateTime(2019, 02, 04, 09, 06, 01), new DateTime(2019, 02, 06, 13, 06, 01) }));

            //    Series series2 = new Series("신선", ViewType.Gantt);
            //    series2.ValueScaleType = ScaleType.DateTime;
            //    series2.Points.AddRange(new SeriesPoint[] { new SeriesPoint("storageNum4", new DateTime[] { new DateTime(2019, 02, 03, 07, 06, 01), new DateTime(2019, 02, 03, 15, 06, 01) }), new SeriesPoint("storageNum1", new DateTime[] { new DateTime(2019, 02, 05, 07, 06, 01), new DateTime(2019, 02, 06, 07, 06, 01) }) });

            //    se = new Series[] { series, series2 };
            //}
            //else if (typeText == "일반")
            //{

            //}
            //else if (typeText == "신선")
            //{

            //}
        }

        private void checkType(out List<Test> basic, out List<Test> fridge, List<Test> list)
        {
            List<Test> basicList = new List<Test>();
            List<Test> fridgeList = new List<Test>();

            for (int i = 0; i < list.Count(); i++)
            {
                if(list[i].storageType == 1)
                {
                    fridgeList.Add(new Test() 
                    { 
                        storageId = list[i].storageId, 
                        storageType = list[i].storageType, 
                        InTime = list[i].InTime, 
                        OutTime = list[i].OutTime 
                    });
                }
                else if(list[i].storageType ==2)
                {
                    basicList.Add(new Test() { storageId = list[i].storageId, storageType = list[i].storageType, InTime = list[i].InTime, OutTime = list[i].OutTime });
                }
                else
                {
                    comboType.Text = "1111111111111";
                }
            }
            basic = basicList;
            fridge = fridgeList;
        }

        public class Test
        {
            public Test()
            {

            }
            public Test(int _storageId, int _storageType, DateTimeOffset _InTime, DateTimeOffset _OutTime)
            {
                storageId = _storageId;
                storageType = _storageType;
                InTime = _InTime;
                OutTime = _OutTime;
            }

            public int storageId { get; set; }
            public int storageType { get; set; }
            public DateTimeOffset InTime { get; set; }
            public DateTimeOffset OutTime { get; set; }
        }

        private void comboFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            startChart();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            startChart();
        }
    }
}
