namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igShapeChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igShapeChart));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igShapeChart1 = new Wisej.Web.Ext.Ignite.igShapeChart();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igShapeChart1);
			// 
			// igShapeChart1
			// 
			this.igShapeChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igShapeChart1.Location = new System.Drawing.Point(31, 20);
			this.igShapeChart1.Name = "igShapeChart1";
			this.igShapeChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igShapeChart1.Options"))));
			this.igShapeChart1.Size = new System.Drawing.Size(391, 273);
			this.igShapeChart1.Text = "igShapeChart1";
			widgetFunction1.Name = "SetDensityData";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			widgetFunction2.Name = "SetShapeData";
			widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
			this.igShapeChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1,
        widgetFunction2};
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "auto",
            "point",
            "line",
            "spline",
            "bubble",
            "highDensity",
            "area",
            "contour",
            "polygon",
            "polyline"});
			this.comboBox1.Label.Text = "Chart Type";
			this.comboBox1.Location = new System.Drawing.Point(28, 63);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 42);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "point";
			// 
			// igShapeChart
			// 
			this.Name = "igShapeChart";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igShapeChart igShapeChart1;
		private ComboBox comboBox1;
	}
}
