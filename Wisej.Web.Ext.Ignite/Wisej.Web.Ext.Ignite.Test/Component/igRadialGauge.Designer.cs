﻿namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igRadialGauge
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
			this.igRadialGauge1 = new Wisej.Web.Ext.Ignite.igRadialGauge();
			this.button2 = new Wisej.Web.Button();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.button1 = new Wisej.Web.Button();
			this.button3 = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Size = new System.Drawing.Size(250, 367);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button2, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.button3, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 285);
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igRadialGauge1);
			this.panel.Size = new System.Drawing.Size(440, 367);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/radial-gauge/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igRadialGauge";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://www.igniteui.com/help/igradialgauge-igradialgauge-overview";
			// 
			// igRadialGauge1
			// 
			this.igRadialGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igRadialGauge1.Location = new System.Drawing.Point(50, 29);
			this.igRadialGauge1.Name = "igRadialGauge1";
			this.igRadialGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"transitionDuration\":250,\"isNeedleDraggingEnabled\":true}")));
			this.igRadialGauge1.Size = new System.Drawing.Size(338, 307);
			this.igRadialGauge1.TabIndex = 0;
			this.igRadialGauge1.Text = "igRadialGauge1";
			this.igRadialGauge1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[0];
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(28, 120);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(195, 27);
			this.button2.TabIndex = 1;
			this.button2.Text = "Start Task";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.Label.Text = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 37);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 55);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.TextAlign = Wisej.Web.HorizontalAlignment.Center;
			this.numericUpDown1.UpDownAlign = Wisej.Web.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 175);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "Get Range Names";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(28, 230);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(195, 27);
			this.button3.TabIndex = 3;
			this.button3.Text = "Add New Range";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// igRadialGauge
			// 
			this.Name = "igRadialGauge";
			this.Size = new System.Drawing.Size(1047, 557);
			this.Load += new System.EventHandler(this.igRadialGauge_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igRadialGauge igRadialGauge1;
        private Button button2;
        private NumericUpDown numericUpDown1;
		private Button button1;
		private Button button3;
	}
}
