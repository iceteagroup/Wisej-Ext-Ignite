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
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igRating1);
			// 
			// igRating1
			// 
			this.igRating1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igRating1.Location = new System.Drawing.Point(169, 136);
			this.igRating1.Name = "igRating1";
			this.igRating1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":3}")));
			this.igRating1.Size = new System.Drawing.Size(115, 40);
			this.igRating1.Text = "igRating1";
			// 
			// igRating
			// 
			this.Name = "igRating";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igRating igRating1;
	}
}
