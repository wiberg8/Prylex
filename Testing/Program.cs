﻿using PrylanLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    static class Program
    {
        public static Installningar AppSettings { get; set; }
        public static DataAccess dataAccess { get; set; }

        static Program()
        {
           
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NyArtikelDialog());
        }

    }

    public enum Status
    {
        UTLAMNAD,
        INLAMNAD
    }
}
