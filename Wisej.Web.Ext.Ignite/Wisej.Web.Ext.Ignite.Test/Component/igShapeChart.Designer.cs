﻿namespace Wisej.Web.Ext.Ignite.Test.Component
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
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction3 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction4 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igShapeChart1 = new Wisej.Web.Ext.Ignite.igShapeChart();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 421);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 340);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igShapeChart1);
			this.panel.Size = new System.Drawing.Size(455, 421);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/shape-chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igSparkline";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igsparkline-landing";
			// 
			// igShapeChart1
			// 
			this.igShapeChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igShapeChart1.Location = new System.Drawing.Point(31, 20);
			this.igShapeChart1.Name = "igShapeChart1";
			this.igShapeChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igShapeChart1.Options"))));
			this.igShapeChart1.Size = new System.Drawing.Size(391, 379);
			this.igShapeChart1.TabIndex = 0;
			this.igShapeChart1.Text = "igShapeChart1";
			widgetFunction3.Name = "SetDensityData";
			widgetFunction3.Source = resources.GetString("widgetFunction3.Source");
			widgetFunction4.Name = "SetShapeData";
			widgetFunction4.Source = resources.GetString("widgetFunction4.Source");
			this.igShapeChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction3,
        widgetFunction4};
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
			this.comboBox1.Location = new System.Drawing.Point(28, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "point";
			// 
			// comboBox2
			// 
			this.comboBox2.Items.AddRange(new object[] {
            "default",
            "none",
            "horizontal",
            "vertical",
            "both"});
			this.comboBox2.Label.Text = "Crosshairs Display Mode";
			this.comboBox2.Location = new System.Drawing.Point(28, 106);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 41);
			this.comboBox2.TabIndex = 2;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 188);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 26;
			this.checkBox1.Text = "Horizontal Zoom";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(28, 267);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 27;
			this.checkBox2.Text = "Vertical Zoom";
			// 
			// igShapeChart
			// 
			this.Name = "igShapeChart";
			this.Size = new System.Drawing.Size(864, 611);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igShapeChart igShapeChart1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
