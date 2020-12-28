using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStorageERP
{
    public static class Factors
    {
        public static Func<FakeAccountInfo, int> SelectTimeScope
        = x => x.Date.Month;

        public static ColorizerColorItem[] Items1 =
        {
        new ColorizerColorItem(Color.FromArgb(0x5F, 0x8B, 0x95)),
        new ColorizerColorItem(Color.FromArgb(0x79, 0x96, 0x89)),
        new ColorizerColorItem(Color.FromArgb(0xA2, 0xA8, 0x75)),
        new ColorizerColorItem(Color.FromArgb(0xCE, 0xBB, 0x5F)),
        new ColorizerColorItem(Color.FromArgb(0xF2, 0xCB, 0x4E)),
        new ColorizerColorItem(Color.FromArgb(0xF1, 0xC1, 0x49)),
        new ColorizerColorItem(Color.FromArgb(0xE5, 0xA8, 0x4D)),
        new ColorizerColorItem(Color.FromArgb(0xD6, 0x86, 0x4E)),
        new ColorizerColorItem(Color.FromArgb(0xC5, 0x64, 0x50)),
        new ColorizerColorItem(Color.FromArgb(0xBA, 0x4D, 0x51))
        };

        public static ColorizerColorItem[] Items2 =
        {
        new ColorizerColorItem(Color.FromArgb(0x5F, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x79, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0xA2, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0xCE, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0xF2, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0xF1, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0xE5, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0xD6, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0xC5, 0x00, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0xBA, 0x00, 0x00)),
        };

        public static ColorizerColorItem[] Items3 =
            {
        new ColorizerColorItem(Color.FromArgb(0x00, 0x5F, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0x79, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0xA2, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0xCE, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0xF2, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0xF1, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0xE5, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0xD6, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0xC5, 0x00)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0xBA, 0x00)),
        };

        public static ColorizerColorItem[] Items4 =
        {
        new ColorizerColorItem(Color.FromArgb(0x00, 0x00, 0x5F)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0x00, 0x79)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0x00, 0xA2)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0x00, 0xCE)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0x00, 0xF2)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0x00, 0xF1)),
        new ColorizerColorItem(Color.FromArgb(0x00, 0x00, 0xE5)),
        new ColorizerColorItem(Color.FromArgb(0x00,0x00, 0xD6)),
        new ColorizerColorItem(Color.FromArgb(0x00,0x00, 0xC5)),
        new ColorizerColorItem(Color.FromArgb(0x00,0x00,0xBA)),
        };
    }
}

