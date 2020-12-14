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

namespace TheStorageERP
{
    public partial class UserControl1 : XtraUserControl
    {
        public UserControl1()
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
            MapItem[] capitals = GetCapitals();
            storage.Items.AddRange(capitals);
            itemsLayer.Data = storage;
        }

        private void OnPinClick(object sender, MapItemClickEventArgs e)
        {
            MessageBox.Show(((MapPushpin)e.Item).Text);
        }


        // 리스트 생성
        MapItem[] GetCapitals()
        {
            return new MapItem[] {
                new MapPushpin() { Text = "화곡역", Location = new GeoPoint(37.54164, 126.84035) },
                new MapPushpin() { Text = "송정역", Location = new GeoPoint(37.56124, 126.81155) },
                new MapPushpin() { Text = "영등포구청역", Location = new GeoPoint(37.52422, 126.89512) },
                new MapPushpin() { Text = "합정역", Location = new GeoPoint(37.54904, 126.91336) },
                new MapPushpin() { Text = "가양역", Location = new GeoPoint(37.56099, 126.85495) }
            };
        }

        //없어도 가능
        #region PinClicked event things for C# 3.0
        public event EventHandler<PinClickedEventArgs> PinClicked;

        protected virtual void OnPinClicked(PinClickedEventArgs e)
        {
            if (PinClicked != null)
                PinClicked(this, e);
        }

        private PinClickedEventArgs OnPinClicked(string name)
        {
            PinClickedEventArgs args = new PinClickedEventArgs(name);
            OnPinClicked(args);

            return args;
        }

        private PinClickedEventArgs OnPinClickedForOut()
        {
            PinClickedEventArgs args = new PinClickedEventArgs();
            OnPinClicked(args);

            return args;
        }

        public class PinClickedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public PinClickedEventArgs()
            {
            }

            public PinClickedEventArgs(string name)
            {
                Name = name;
            }
        }
        #endregion


    }
}
