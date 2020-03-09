namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igFinancialChart
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igFinancialChart));
			this.igFinancialChart1 = new Wisej.Web.Ext.Ignite.igFinancialChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igFinancialChart1);
			// 
			// igFinancialChart1
			// 
			this.igFinancialChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igFinancialChart1.Location = new System.Drawing.Point(19, 23);
			this.igFinancialChart1.Name = "igFinancialChart1";
			this.igFinancialChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"chartType\":\"candle\",\"zoomSliderType\":\"candle\"}")));
			this.igFinancialChart1.Size = new System.Drawing.Size(414, 267);
			this.igFinancialChart1.Text = "igFinancialChart1";
			widgetFunction2.Name = "loadTheData";
			widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
			this.igFinancialChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
			// 
			// igFinancialChart
			// 
			this.Name = "igFinancialChart";
			this.Load += new System.EventHandler(this.igFinancialChart_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igFinancialChart igFinancialChart1;
	}
}
