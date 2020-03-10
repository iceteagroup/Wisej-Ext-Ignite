namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igMap));
			Wisej.Web.Ext.Ignite.igBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate();
			this.igMap1 = new Wisej.Web.Ext.Ignite.igMap();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igMap1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/map/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igmap";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igmap-landing-page";
			// 
			// igMap1
			// 
			this.igMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igMap1.Location = new System.Drawing.Point(21, 21);
			this.igMap1.Name = "igMap1";
			this.igMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igMap1.Options"))));
			this.igMap1.Size = new System.Drawing.Size(410, 271);
			this.igMap1.Text = "igMap1";
			widgetTemplate1.Id = "tooltipTemplate";
			widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
			widgetTemplate1.Type = "text/x-jquery-tmpl";
			this.igMap1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[] {
        widgetTemplate1};
			// 
			// igMap
			// 
			this.Name = "igMap";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igMap igMap1;
	}
}
