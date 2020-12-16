using DevExpress.XtraEditors;
using DevExpress.XtraMap;
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
    public partial class BingMapForm : XtraForm
    {
        public BingMapForm()
        {
            InitializeComponent();
            mapControl.MapItemClick += OnPinClick;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            mapControl.CenterPoint = new GeoPoint(37.54164, 126.84035);
            mapControl.ZoomLevel = 13;

            VectorItemsLayer itemsLayer = new VectorItemsLayer();
            mapControl.Layers.Add(itemsLayer);

            MapItemStorage storage = new MapItemStorage();
            List<MapItem> capitals = GetCapitals();
            //MapItem[] capitals = GetCapitals();

            storage.Items.AddRange(capitals);
            itemsLayer.Data = storage;


        }

        private void OnPinClick(object sender, MapItemClickEventArgs e)
        {
            MessageBox.Show(((MapPushpin)e.Item).Text);
        }



        // 리스트 생성
        List<MapItem> GetCapitals()
        {

            int storageCount = Clients.Facilities.GetFacilitiesAsync().Result.Count;


            List<MapItem> mapItems = new List<MapItem>();

            for (int i = 1; i <= storageCount; i++)
            {
                int employeeId = Clients.Facilities.GetFacilityAsync(i).Result.EmployeeId;
                int regionId = Clients.Facilities.GetFacilityAsync(i).Result.RegionId;

                string storageName = Clients.Regions.GetRegionAsync(regionId).Result.Town;
                string employeeName = Clients.Employees.GetEmployeeAsync(employeeId).Result.Name;

                double latitude = Convert.ToDouble(Clients.Regions.GetRegionAsync(regionId).Result.Latitude);
                double longitude = Convert.ToDouble(Clients.Regions.GetRegionAsync(regionId).Result.Longitude);

                MapPushpin pushpin = new MapPushpin() { Text = $"{storageName}", Location = new GeoPoint(latitude, longitude), ToolTipPattern = $"보관소 : {storageName}\n담당직원 : {employeeName}\n" };
                mapItems.Add(pushpin);
            }

            return mapItems;

        }

        // 리스트 생성
        //MapItem[] GetCapitals()
        //{
        //    string storageName = Class1.regionsClient.GetRegionAsync(1).Result.Town;
        //    string employeeName = Class1.employeeClient.GetEmployeeAsync(1).Result.Name;

        //    return new MapItem[] {
        //        new MapPushpin() { Text = "화곡역", Location = new GeoPoint(37.54164, 126.84035), ToolTipPattern = $"보관소 : {storageName}\n담당직원 : {employeeName}\n"},
        //        new MapPushpin() { Text = "송정역", Location = new GeoPoint(37.56124, 126.81155) },
        //        new MapPushpin() { Text = "영등포구청역", Location = new GeoPoint(37.52422, 126.89512) },
        //        new MapPushpin() { Text = "합정역", Location = new GeoPoint(37.54904, 126.91336) },
        //        new MapPushpin() { Text = "가양역", Location = new GeoPoint(37.56099, 126.85495) }
        //    };
        //}
    }
}
