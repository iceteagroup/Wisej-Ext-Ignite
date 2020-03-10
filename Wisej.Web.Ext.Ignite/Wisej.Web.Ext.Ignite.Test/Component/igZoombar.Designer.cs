namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igZoombar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igZoombar));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igDataChart1 = new Wisej.Web.Ext.Ignite.igDataChart();
			this.igZoombar1 = new Wisej.Web.Ext.Ignite.igZoombar();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igDataChart1);
			this.panel.Controls.Add(this.igZoombar1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/zoombar/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igzoombar";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://www.igniteui.com/help/igzoombar-landingpage";
			// 
			// igDataChart1
			// 
			this.igDataChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igDataChart1.Location = new System.Drawing.Point(35, 26);
			this.igDataChart1.Name = "igDataChart1";
			this.igDataChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDataChart1.Options"))));
			this.igDataChart1.Size = new System.Drawing.Size(383, 191);
			this.igDataChart1.TabIndex = 1;
			this.igDataChart1.Text = "igDataChart1";
			this.igDataChart1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[0];
			this.igDataChart1.Appear += new System.EventHandler(this.igDataChart1_Appear);
			// 
			// igZoombar1
			// 
			this.igZoombar1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igZoombar1.Location = new System.Drawing.Point(35, 223);
			this.igZoombar1.Name = "igZoombar1";
			this.igZoombar1.Size = new System.Drawing.Size(383, 64);
			this.igZoombar1.TabIndex = 2;
			widgetFunction1.Name = "setTarget";
			widgetFunction1.Source = "var handle = arguments[0];\r\n\r\nthis.widget.option(\"target\", \"#id_\" + handle.toStri" +
    "ng() + \"_container\");";
			this.igZoombar1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			this.igZoombar1.Appear += new System.EventHandler(this.igZoombar1_Appear);
			// 
			// igZoombar
			// 
			this.Name = "igZoombar";
			this.Load += new System.EventHandler(this.igZoombar_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igZoombar igZoombar1;
		private Ignite.igDataChart igDataChart1;
	}
}
