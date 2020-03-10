namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igFunnelChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igFunnelChart));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.igFunnelChart2 = new Wisej.Web.Ext.Ignite.igFunnelChart();
			this.igFunnelChart1 = new Wisej.Web.Ext.Ignite.igFunnelChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.igFunnelChart2);
			this.panel.Controls.Add(this.igFunnelChart1);
			this.panel.Size = new System.Drawing.Size(788, 464);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/funnel-chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://www.igniteui.com/help/api/2019.2/ui.igFunnelChart";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igfunnelchart-overview";
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Location = new System.Drawing.Point(157, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Funnel Chart";
			// 
			// label5
			// 
			this.label5.Anchor = Wisej.Web.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label5.Location = new System.Drawing.Point(514, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Inverted Funnel Chart";
			// 
			// igFunnelChart2
			// 
			this.igFunnelChart2.Anchor = Wisej.Web.AnchorStyles.None;
			this.igFunnelChart2.Location = new System.Drawing.Point(395, 44);
			this.igFunnelChart2.Name = "igFunnelChart2";
			this.igFunnelChart2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igFunnelChart2.Options"))));
			this.igFunnelChart2.Size = new System.Drawing.Size(380, 402);
			this.igFunnelChart2.TabIndex = 2;
			this.igFunnelChart2.Text = "igFunnelChart2";
			widgetFunction1.Name = "clickSlice";
			widgetFunction1.Source = "App.MainView.showAlert(arguments[1][\"item\"]);";
			this.igFunnelChart2.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// igFunnelChart1
			// 
			this.igFunnelChart1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igFunnelChart1.Location = new System.Drawing.Point(11, 44);
			this.igFunnelChart1.Name = "igFunnelChart1";
			this.igFunnelChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igFunnelChart1.Options"))));
			this.igFunnelChart1.Size = new System.Drawing.Size(380, 402);
			this.igFunnelChart1.TabIndex = 3;
			this.igFunnelChart1.Text = "igFunnelChart1";
			widgetFunction2.Name = "clickSlice";
			widgetFunction2.Source = "App.MainView.showAlert(arguments[1][\"item\"]);";
			this.igFunnelChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
			// 
			// igFunnelChart
			// 
			this.Name = "igFunnelChart";
			this.Size = new System.Drawing.Size(1197, 654);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igFunnelChart igFunnelChart1;
		private Ignite.igFunnelChart igFunnelChart2;
		private Label label5;
		private Label label4;
	}
}
