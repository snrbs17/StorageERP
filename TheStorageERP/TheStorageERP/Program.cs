﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheStorageERP.Client;
using TheStorageERP.Forms;

namespace TheStorageERP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StorageInfo());
            //Application.Run(new SeoulMap());
            //Application.Run(new MainForm());
            //Application.Run(new BreakEvenAnalysis());
            //Application.Run(new FinancialStatementViewer());
        }
    }
}
