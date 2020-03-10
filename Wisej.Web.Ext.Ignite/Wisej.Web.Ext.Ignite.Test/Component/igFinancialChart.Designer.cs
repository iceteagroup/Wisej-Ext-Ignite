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
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction3 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igFinancialChart));
			this.igFinancialChart1 = new Wisej.Web.Ext.Ignite.igFinancialChart();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 437);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.button2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 356);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igFinancialChart1);
			this.panel.Size = new System.Drawing.Size(455, 437);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/financial-chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igfinancialchart";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/financial-chart-overview";
			// 
			// igFinancialChart1
			// 
			this.igFinancialChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igFinancialChart1.Location = new System.Drawing.Point(19, 23);
			this.igFinancialChart1.Name = "igFinancialChart1";
			this.igFinancialChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"chartType\":\"candle\",\"zoomSliderType\":\"candle\",\"transitionDuration\":250}")));
			this.igFinancialChart1.Size = new System.Drawing.Size(414, 389);
			this.igFinancialChart1.Text = "igFinancialChart1";
			widgetFunction3.Name = "loadTheData";
			widgetFunction3.Source = resources.GetString("widgetFunction3.Source");
			this.igFinancialChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction3};
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "auto",
            "bar",
            "candle",
            "column",
            "line"});
			this.comboBox1.Label.Text = "Chart Type";
			this.comboBox1.Location = new System.Drawing.Point(28, 52);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 42);
			this.comboBox1.TabIndex = 1;
			// 
			// comboBox2
			// 
			this.comboBox2.Items.AddRange(new object[] {
            "none",
            "linearFit",
            "quadraticFit",
            "cubicFit",
            "quarticFit",
            "quinticFit",
            "logarithmicFit",
            "exponentialFit",
            "powerLawFit",
            "simpleAverage",
            "exponentialAverage",
            "modifiedAverage",
            "cumulativeAverage",
            "weightedAverage"});
			this.comboBox2.Label.Text = "Trend Line Type";
			this.comboBox2.Location = new System.Drawing.Point(28, 121);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 42);
			this.comboBox2.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 202);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "Add new Item";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(28, 275);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(195, 27);
			this.button2.TabIndex = 4;
			this.button2.Text = "Start Task";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// igFinancialChart
			// 
			this.Name = "igFinancialChart";
			this.Size = new System.Drawing.Size(864, 627);
			this.Load += new System.EventHandler(this.igFinancialChart_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igFinancialChart igFinancialChart1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private Button button1;
		private Button button2;
	}
}
