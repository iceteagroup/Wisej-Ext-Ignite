namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igScheduler
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
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igScheduler));
			this.igScheduler1 = new Wisej.Web.Ext.Ignite.igScheduler();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igScheduler1);
			// 
			// igScheduler1
			// 
			this.igScheduler1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igScheduler1.Location = new System.Drawing.Point(21, 16);
			this.igScheduler1.Name = "igScheduler1";
			this.igScheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"views\":[\"monthView\",\"agendaView\"]}")));
			this.igScheduler1.Size = new System.Drawing.Size(412, 283);
			this.igScheduler1.Text = "igScheduler1";
			widgetFunction1.Name = "loadData";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.igScheduler1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			this.igScheduler1.Appear += new System.EventHandler(this.igScheduler1_Appear);
			// 
			// igScheduler
			// 
			this.Name = "igScheduler";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igScheduler igScheduler1;
	}
}
