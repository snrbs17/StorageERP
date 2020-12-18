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
            //myDiagram.AxisY.WholeRange.Auto = false;

            DateTime nowDate = DateTime.Now;
            myDiagram.AxisY.WholeRange.SetMinMaxValues(nowDate.AddDays(-2) , nowDate);

            XYDiagram xYDiagram = (XYDiagram)chartControl.Diagram;
            xYDiagram.AxisY.WholeRange.Auto = false;
            //xYDiagram.AxisY.WholeRange.SetMinMaxValues = 

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
                       select new DbDate
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

            List<DbDate> list = seriesData.ToList();
            List<DbDate> basic = new List<DbDate>();
            List<DbDate> fridge = new List<DbDate>();

            checkType(out basic, out fridge, list);

            if (typeText == 3)
            {
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
        }

        private void checkType(out List<DbDate> basic, out List<DbDate> fridge, List<DbDate> list)
        {
            List<DbDate> basicList = new List<DbDate>();
            List<DbDate> fridgeList = new List<DbDate>();

            for (int i = 0; i < list.Count(); i++)
            {
                if(list[i].storageType == 1)
                {
                    fridgeList.Add(new DbDate() 
                    { 
                        storageId = list[i].storageId, 
                        storageType = list[i].storageType, 
                        InTime = list[i].InTime, 
                        OutTime = list[i].OutTime 
                    });
                }
                else if(list[i].storageType ==2)
                {
                    basicList.Add(new DbDate() { storageId = list[i].storageId, storageType = list[i].storageType, InTime = list[i].InTime, OutTime = list[i].OutTime });
                }
            }
            basic = basicList;
            fridge = fridgeList;
        }

        public class DbDate
        {
            public DbDate()
            {

            }
            public DbDate(int _storageId, int _storageType, DateTimeOffset _InTime, DateTimeOffset _OutTime)
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

        private void calendarControl_DateTimeChanged(object sender, EventArgs e)
        {
            if (startDayText.Text == "")
            {
                startDayText.Text = calendarControl.DateTime.ToString("MM/dd/yyyy HH:mm");
                comboStartHour.SelectedIndex = 0;
                comboStartMin.SelectedIndex = 0;
            }
            else if (startDayText.Text != "")
            {
                DateTime startDate = Convert.ToDateTime(startDayText.Text);
                DateTime clickDate = Convert.ToDateTime(calendarControl.DateTime);
                if (startDate <= clickDate)
                {
                    endDayText.Text = calendarControl.DateTime.ToString("MM/dd/yyyy HH:mm");
                    comboEndHour.SelectedIndex = 0;
                    comboEndMin.SelectedIndex = 0;
                }
                else if (startDate > clickDate)
                {
                    startDayText.Text = calendarControl.DateTime.ToString("MM/dd/yyyy HH:mm");
                    comboStartHour.SelectedIndex = 0;
                    comboStartMin.SelectedIndex = 0;
                }
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit combo = sender as ComboBoxEdit;

            if (combo.Name.Contains("Start"))
            {
                DateTime startDateTime = Convert.ToDateTime(startDayText.Text);
                double startOldHour = Convert.ToDouble(-(startDateTime.Hour));
                double startNewHour = Convert.ToDouble(combo.Text);
                double startOldMin = Convert.ToDouble(-(startDateTime.Minute));
                double startNewMin = Convert.ToDouble(combo.Text);

                switch (combo.Name)
                {
                    case "comboStartHour":
                        startDayText.Text = startDateTime.AddHours(startOldHour + startNewHour).ToString("MM/dd/yyyy HH:mm");
                        break;
                    case "comboStartMin":
                        startDayText.Text = startDateTime.AddMinutes(startOldMin + startNewMin).ToString("MM/dd/yyyy HH:mm");
                        break;
                    default:
                        break;
                }
            }
            else if (combo.Name.Contains("End"))
            {
                DateTime endDateTime = Convert.ToDateTime(endDayText.Text);
                double endOldHour = Convert.ToDouble(-(endDateTime.Hour));
                double endNewHour = Convert.ToDouble(combo.Text);
                double endOldMin = Convert.ToDouble(-(endDateTime.Minute));
                double endNewMin = Convert.ToDouble(combo.Text);

                switch (combo.Name)
                {
                    case "comboEndHour":
                        endDayText.Text = endDateTime.AddHours(endOldHour + endNewHour).ToString("MM/dd/yyyy HH:mm");
                        break;
                    case "comboEndMin":
                        endDayText.Text = endDateTime.AddMinutes(endOldMin + endNewMin).ToString("MM/dd/yyyy HH:mm");
                        break;

                    default:
                        break;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(startDayText.Text);
            DateTime endDate = Convert.ToDateTime(endDayText.Text);

            GanttDiagram myDiagram = (GanttDiagram)chartControl.Diagram;
            myDiagram.AxisY.WholeRange.SetMinMaxValues(startDate, endDate);

            startDayText.Text = "";
            endDayText.Text = "";
        }
    }
}
