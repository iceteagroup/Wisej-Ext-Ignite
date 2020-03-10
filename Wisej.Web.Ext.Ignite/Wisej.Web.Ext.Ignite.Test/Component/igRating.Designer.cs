namespace Wisej.Web.Ext.Ignite.Test.Component
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
			this.igRating1 = new Wisej.Web.Ext.Ignite.igRating();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
			this.igRating1.Location = new System.Drawing.Point(169, 136);
			this.igRating1.Name = "igRating1";
			this.igRating1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":3}")));
			this.igRating1.Size = new System.Drawing.Size(115, 40);
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
			this.numericUpDown1.Location = new System.Drawing.Point(28, 58);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 42);
			this.numericUpDown1.TabIndex = 1;
			// 
			// igRating
			// 
			this.Name = "igRating";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igRating igRating1;
		private NumericUpDown numericUpDown1;
	}
}
