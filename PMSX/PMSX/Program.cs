﻿using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DevExpress.UserSkins;

namespace PMSX {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {           
            CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new View.Form.Main());
        }
    }
}