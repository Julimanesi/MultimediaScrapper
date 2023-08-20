using System.Diagnostics;
using System.ComponentModel;
using System.Security.Policy;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace GoogleScrapper
{
    public partial class Form1 : Form
    {
        public static string URLGoogle = "https://www.google.com/search?q=";
        private int NroMinimoResultados = 1;
        public Form1()
        {
            InitializeComponent();
            FechaInicioDTP.Value = DateTime.Now.AddYears(-1);
            FechaFinDTP.Value = DateTime.Now;
            FechaInicioDTP.MaxDate = DateTime.Now;
            FechaFinDTP.MaxDate = DateTime.Now;
            EjecucionProcesos.Inicializar();
        }

        
    }
}