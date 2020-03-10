﻿namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igDataChartIndicator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igDataChartIndicator));
			this.igDataChart1 = new Wisej.Web.Ext.Ignite.igDataChart();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExportImage = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExportImage);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExportImage, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igDataChart1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/data-chart/charts-financial-indicators";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igDataChart";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igdatachart-landing-page";
			// 
			// igDataChart1
			// 
			this.igDataChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igDataChart1.Location = new System.Drawing.Point(19, 27);
			this.igDataChart1.Name = "igDataChart1";
			this.igDataChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDataChart1.Options"))));
			this.igDataChart1.Size = new System.Drawing.Size(415, 259);
			this.igDataChart1.Text = "igDataChart1";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 172);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 17;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExportImage
			// 
			this.buttonExportImage.Display = Wisej.Web.Display.Icon;
			this.buttonExportImage.ImageSource = "icon-save";
			this.buttonExportImage.Location = new System.Drawing.Point(76, 172);
			this.buttonExportImage.Name = "buttonExportImage";
			this.buttonExportImage.Size = new System.Drawing.Size(42, 42);
			this.buttonExportImage.TabIndex = 16;
			this.buttonExportImage.Click += new System.EventHandler(this.buttonExportImage_Click);
			// 
			// igDataChartIndicator
			// 
			this.Name = "igDataChartIndicator";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igDataChart igDataChart1;
		private Upload buttonLoad;
		private Button buttonExportImage;
	}
}
