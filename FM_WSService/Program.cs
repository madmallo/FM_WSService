using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FM_WSService
{
   static class Program
   {
      /// <summary>
      /// Punto di ingresso principale dell'applicazione.
      /// </summary>
      static void Main()
      {
         ServiceBase[] ServicesToRun;

         Service1 FMSample = new Service1();

         ServicesToRun = new ServiceBase[]
         {
                FMSample
         };
         ServiceBase.Run(ServicesToRun);
      }
   }
}
