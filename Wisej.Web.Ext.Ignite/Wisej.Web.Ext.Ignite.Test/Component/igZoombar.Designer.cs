﻿namespace Wisej.Web.Ext.Ignite.Test.Component
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
			this.igDataChart1 = new Wisej.Web.Ext.Ignite.igDataChart();
			this.panel1 = new Wisej.Web.Panel();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Size = new System.Drawing.Size(250, 387);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown3, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 306);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.panel1);
			this.panel.Controls.Add(this.igDataChart1);
			this.panel.Size = new System.Drawing.Size(547, 387);
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
			this.igDataChart1.Size = new System.Drawing.Size(475, 263);
			this.igDataChart1.TabIndex = 1;
			this.igDataChart1.Text = "igDataChart1";
			this.igDataChart1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[0];
			this.igDataChart1.Initialized += new System.EventHandler(this.igDataChart1_Initialized);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.panel1.Location = new System.Drawing.Point(35, 300);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 57);
			this.panel1.TabIndex = 2;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Zoom Window Move Distance";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 24);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Label.Text = "Zoom Window Min Width";
			this.numericUpDown2.Location = new System.Drawing.Point(28, 126);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown2.TabIndex = 2;
			this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Label.Text = "Window Pan Duration";
			this.numericUpDown3.Location = new System.Drawing.Point(28, 228);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown3.TabIndex = 3;
			this.numericUpDown3.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// igZoombar
			// 
			this.Name = "igZoombar";
			this.Size = new System.Drawing.Size(956, 577);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Ignite.igDataChart igDataChart1;
		private Panel panel1;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
	}
}
