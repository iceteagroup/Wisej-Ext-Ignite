namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igDoughnutChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igDoughnutChart));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igDoughnutChart1 = new Wisej.Web.Ext.Ignite.igDoughnutChart();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExportData = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExportData);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExportData, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igDoughnutChart1);
			// 
			// igDoughnutChart1
			// 
			this.igDoughnutChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igDoughnutChart1.Location = new System.Drawing.Point(23, 19);
			this.igDoughnutChart1.Name = "igDoughnutChart1";
			this.igDoughnutChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDoughnutChart1.Options"))));
			this.igDoughnutChart1.Size = new System.Drawing.Size(407, 274);
			this.igDoughnutChart1.Text = "igDoughnutChart1";
			widgetFunction2.Name = "formatLabel";
			widgetFunction2.Source = "var context = arguments[0];\r\n\r\nreturn context.itemLabel + \" (\" + context.item.Pop" +
    "1990 + \")\";\r\n        ";
			this.igDoughnutChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 175);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 17;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExportData
			// 
			this.buttonExportData.Display = Wisej.Web.Display.Icon;
			this.buttonExportData.ImageSource = "icon-save";
			this.buttonExportData.Location = new System.Drawing.Point(76, 175);
			this.buttonExportData.Name = "buttonExportData";
			this.buttonExportData.Size = new System.Drawing.Size(42, 42);
			this.buttonExportData.TabIndex = 16;
			this.buttonExportData.Click += new System.EventHandler(this.buttonExportData_Click);
			// 
			// igDoughnutChart
			// 
			this.Name = "igDoughnutChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igDoughnutChart igDoughnutChart1;
		private Upload buttonLoad;
		private Button buttonExportData;
	}
}
