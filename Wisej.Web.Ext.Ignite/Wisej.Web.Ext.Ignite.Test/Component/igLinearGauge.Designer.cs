namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igLinearGauge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igLinearGauge));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igLinearGauge1 = new Wisej.Web.Ext.Ignite.igLinearGauge();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igLinearGauge1);
			// 
			// igLinearGauge1
			// 
			this.igLinearGauge1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.igLinearGauge1.IsNeedleDraggingEnabled = true;
			this.igLinearGauge1.Location = new System.Drawing.Point(21, 31);
			this.igLinearGauge1.Name = "igLinearGauge1";
			this.igLinearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igLinearGauge1.Options"))));
			this.igLinearGauge1.Size = new System.Drawing.Size(410, 77);
			this.igLinearGauge1.Value = 40;
			widgetFunction1.Name = "formatLabel";
			widgetFunction1.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"%\";";
			this.igLinearGauge1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// igLinearGauge
			// 
			this.Name = "igLinearGauge";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igLinearGauge igLinearGauge1;
	}
}
