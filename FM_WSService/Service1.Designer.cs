namespace FM_WSService
{
   partial class Service1
   {
      /// <summary> 
      /// Variabile di progettazione necessaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Pulire le risorse in uso.
      /// </summary>
      /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Codice generato da Progettazione componenti

      /// <summary> 
      /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
      /// il contenuto del metodo con l'editor di codice.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.FMTimer = new System.Windows.Forms.Timer(this.components);
         this.FMBrowser = new System.Windows.Forms.WebBrowser();
         // 
         // FMTimer
         // 
         this.FMTimer.Enabled = true;
         this.FMTimer.Tick += new System.EventHandler(this.FMTimer_Tick);
         // 
         // FMBrowser
         // 
         this.FMBrowser.Location = new System.Drawing.Point(0, 0);
         this.FMBrowser.MinimumSize = new System.Drawing.Size(20, 20);
         this.FMBrowser.Name = "FMBrowser";
         this.FMBrowser.Size = new System.Drawing.Size(250, 250);
         this.FMBrowser.TabIndex = 0;
         this.FMBrowser.Visible = false;
         // 
         // Service1
         // 
         this.ServiceName = "Service1";

      }

      #endregion

      private System.Windows.Forms.Timer FMTimer;
      private System.Windows.Forms.WebBrowser FMBrowser;
   }
}
