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
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igDoughnutChart1 = new Wisej.Web.Ext.Ignite.igDoughnutChart();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExportData = new Wisej.Web.Button();
			this.textBox1 = new Wisej.Web.TextBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.button1 = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExportData);
			this.groupBox1.Size = new System.Drawing.Size(250, 369);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExportData, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 288);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igDoughnutChart1);
			this.panel.Size = new System.Drawing.Size(455, 369);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/doughnut-chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igdoughnutchart";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igdoughnutchart-overview";
			// 
			// igDoughnutChart1
			// 
			this.igDoughnutChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igDoughnutChart1.Location = new System.Drawing.Point(23, 19);
			this.igDoughnutChart1.Name = "igDoughnutChart1";
			this.igDoughnutChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDoughnutChart1.Options"))));
			this.igDoughnutChart1.Size = new System.Drawing.Size(407, 328);
			this.igDoughnutChart1.Text = "igDoughnutChart1";
			widgetFunction1.Name = "formatLabel";
			widgetFunction1.Source = "var context = arguments[0];\r\n\r\nreturn context.itemLabel + \" (\" + context.item.Pop" +
    "1990 + \")\";\r\n        ";
			this.igDoughnutChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 240);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 17;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExportData
			// 
			this.buttonExportData.Display = Wisej.Web.Display.Icon;
			this.buttonExportData.ImageSource = "icon-save";
			this.buttonExportData.Location = new System.Drawing.Point(76, 240);
			this.buttonExportData.Name = "buttonExportData";
			this.buttonExportData.Size = new System.Drawing.Size(42, 42);
			this.buttonExportData.TabIndex = 16;
			this.buttonExportData.Click += new System.EventHandler(this.buttonExportData_Click);
			// 
			// textBox1
			// 
			this.textBox1.Label.Text = "Country Name";
			this.textBox1.Location = new System.Drawing.Point(9, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 42);
			this.textBox1.TabIndex = 18;
			this.textBox1.Text = "Canada";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Population";
			this.numericUpDown1.Location = new System.Drawing.Point(9, 86);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 42);
			this.numericUpDown1.TabIndex = 19;
			this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(20, 26);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(213, 187);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.Text = "Add a new Country";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 20;
			this.button1.Text = "Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// igDoughnutChart
			// 
			this.Name = "igDoughnutChart";
			this.Size = new System.Drawing.Size(864, 559);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igDoughnutChart igDoughnutChart1;
		private Upload buttonLoad;
		private Button buttonExportData;
		private NumericUpDown numericUpDown1;
		private TextBox textBox1;
		private GroupBox groupBox2;
		private Button button1;
	}
}
