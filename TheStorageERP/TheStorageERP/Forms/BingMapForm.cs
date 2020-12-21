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
            storage.Items.AddRange(capitals);
            itemsLayer.Data = storage;
        }

        private void OnPinClick(object sender, MapItemClickEventArgs e)
        {
            //((MapPushpin)e.Item).Text
            MessageBox.Show(((MapPushpin)e.Item).Text);
        }

        // 리스트 생성
        List<MapItem> GetCapitals()
        {
            int storageCount = Clients.Facilities.GetFacilitiesAsync().Result.Count;
            List<MapItem> mapItems = new List<MapItem>();
            var facilities = Clients.Facilities.GetFacilitiesAsync().Result.ToList();

            for (int i = 0; i < storageCount; i++)
            {
                int facilityId = facilities[i].FacilityId;
                int employeeId = Clients.Facilities.GetFacilityAsync(facilityId).Result.EmployeeId;
                int regionId = Clients.Facilities.GetFacilityAsync(facilityId).Result.RegionId;

                string storageName = Clients.Regions.GetRegionAsync(regionId).Result.Town;
                string employeeName = Clients.Employees.GetEmployeeAsync(employeeId).Result.Name;

                double latitude = Convert.ToDouble(Clients.Regions.GetRegionAsync(regionId).Result.Latitude);
                double longitude = Convert.ToDouble(Clients.Regions.GetRegionAsync(regionId).Result.Longitude);

                MapPushpin pushpin = new MapPushpin() { Text = $"{storageName}", Location = new GeoPoint(latitude, longitude), ToolTipPattern = $"보관소 : {storageName}\n담당직원 : {employeeName}\n" };
                mapItems.Add(pushpin);
            }
            return mapItems;
        }
    }
}
