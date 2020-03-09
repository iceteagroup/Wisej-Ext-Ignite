namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igSparkline
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
			this.igSparkline1 = new Wisej.Web.Ext.Ignite.igSparkline();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igSparkline1);
			// 
			// igSparkline1
			// 
			this.igSparkline1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igSparkline1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.igSparkline1.Location = new System.Drawing.Point(21, 120);
			this.igSparkline1.Name = "igSparkline1";
			this.igSparkline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"valueMemberPath\":\"ExtendedPrice\",\"tooltipTemplate\":\"Low:${Low}<br>High:${High}\"" +
        "}")));
			this.igSparkline1.Size = new System.Drawing.Size(410, 72);
			this.igSparkline1.Text = "igSparkline1";
			// 
			// igSparkline
			// 
			this.Name = "igSparkline";
			this.Load += new System.EventHandler(this.igSparkline_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igSparkline igSparkline1;
	}
}
