﻿namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igColorPicker
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
			this.label4 = new Wisej.Web.Label();
			this.igColorPicker1 = new Wisej.Web.Ext.Ignite.igColorPicker();
			this.textBox1 = new Wisej.Web.TextBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.igColorPicker1);
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://www.igniteui.com/help/api/2019.2/ui.igcolorpicker";
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.label4.Location = new System.Drawing.Point(126, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(201, 33);
			this.label4.TabIndex = 1;
			this.label4.Text = "Selected Color";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// igColorPicker1
			// 
			this.igColorPicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igColorPicker1.Location = new System.Drawing.Point(126, 52);
			this.igColorPicker1.Name = "igColorPicker1";
			this.igColorPicker1.Size = new System.Drawing.Size(201, 159);
			this.igColorPicker1.TabIndex = 2;
			this.igColorPicker1.Text = "igColorPicker1";
			// 
			// textBox1
			// 
			this.textBox1.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBox1.Label.Text = "Selects a Matching Color on the Widget";
			this.textBox1.Location = new System.Drawing.Point(8, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 42);
			this.textBox1.TabIndex = 1;
			// 
			// igColorPicker
			// 
			this.Name = "igColorPicker";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igColorPicker igColorPicker1;
		private Label label4;
		private TextBox textBox1;
	}
}
