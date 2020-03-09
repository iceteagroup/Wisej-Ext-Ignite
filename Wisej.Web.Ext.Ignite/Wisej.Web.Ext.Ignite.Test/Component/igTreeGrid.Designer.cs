namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igTreeGrid
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
			this.igTreeGrid1 = new Wisej.Web.Ext.Ignite.igTreeGrid();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igTreeGrid1);
			// 
			// igTreeGrid1
			// 
			this.igTreeGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igTreeGrid1.Location = new System.Drawing.Point(22, 24);
			this.igTreeGrid1.Name = "igTreeGrid1";
			this.igTreeGrid1.Size = new System.Drawing.Size(409, 265);
			this.igTreeGrid1.Text = "igTreeGrid1";
			// 
			// igTreeGrid
			// 
			this.Name = "igTreeGrid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igTreeGrid igTreeGrid1;
	}
}
