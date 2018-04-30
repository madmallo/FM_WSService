using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FM_WSService
{
   public partial class Service1 : ServiceBase
   {
      public Service1()
      {
         InitializeComponent();
      }

      protected override void OnStart(string[] args)
      {
         this.Log("*** start service ***");
         this.FMTimer.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["MSInterval"]);
      }

      protected override void OnStop()
      {
         this.Log("*** stop service ***");
      }

      private void FMTimer_Tick(object sender, EventArgs e)
      {
         this.FMBrowser.Navigate(this.FMBrowser.Url);
         this.Log(this.FMBrowser.DocumentText);
      }

      private void Log(string message)
      {
         string path = "C:\\FMTest\\FM_WSService_log.txt";
         using (StreamWriter writer = new StreamWriter(path, true))
         {
            writer.WriteLine(string.Format(message, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
            writer.Close();
         }
      }
   }
}
