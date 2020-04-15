﻿namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igRating
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igRating));
			this.igRating1 = new Wisej.Web.Ext.Ignite.igRating();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.pictureBox1);
			this.panel.Controls.Add(this.igRating1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/rating/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igrating";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igrating-igrating";
			// 
			// igRating1
			// 
			this.igRating1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igRating1.Location = new System.Drawing.Point(257, 71);
			this.igRating1.Name = "igRating1";
			this.igRating1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":3}")));
			this.igRating1.Size = new System.Drawing.Size(115, 40);
			this.igRating1.TabIndex = 0;
			this.igRating1.Value = 3;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 2;
			this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown1.Label.Text = "Set Value";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 137);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(25, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(226, 242);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Location = new System.Drawing.Point(257, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(171, 30);
			this.label4.TabIndex = 2;
			this.label4.Text = "The Avengers";
			// 
			// label5
			// 
			this.label5.Anchor = Wisej.Web.AnchorStyles.None;
			this.label5.Location = new System.Drawing.Point(257, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(171, 160);
			this.label5.TabIndex = 3;
			this.label5.Text = "Earth\'s mightiest heroes must come together and learn to fight as a team if they " +
    "are going to stop the mischievous Loki and his alien army from enslaving humanit" +
    "y.";
			// 
			// igRating
			// 
			this.Name = "igRating";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igRating igRating1;
		private NumericUpDown numericUpDown1;
		private Label label5;
		private Label label4;
		private PictureBox pictureBox1;
	}
}
