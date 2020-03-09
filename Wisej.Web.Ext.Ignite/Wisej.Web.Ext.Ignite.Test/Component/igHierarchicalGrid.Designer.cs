namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igHierarchicalGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igHierarchicalGrid));
			this.igHierarchicalGrid1 = new Wisej.Web.Ext.Ignite.igHierarchicalGrid();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igHierarchicalGrid1);
			// 
			// igHierarchicalGrid1
			// 
			this.igHierarchicalGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igHierarchicalGrid1.Location = new System.Drawing.Point(20, 15);
			this.igHierarchicalGrid1.Name = "igHierarchicalGrid1";
			this.igHierarchicalGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igHierarchicalGrid1.Options"))));
			this.igHierarchicalGrid1.Size = new System.Drawing.Size(412, 283);
			this.igHierarchicalGrid1.Text = "igHierarchicalGrid1";
			// 
			// igHierarchicalGrid
			// 
			this.Name = "igHierarchicalGrid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igHierarchicalGrid igHierarchicalGrid1;
	}
}
