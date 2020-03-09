namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igPivotView
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
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igPivotView));
			this.igPivotView1 = new Wisej.Web.Ext.Ignite.igPivotView();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igPivotView1);
			// 
			// igPivotView1
			// 
			this.igPivotView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igPivotView1.Location = new System.Drawing.Point(20, 24);
			this.igPivotView1.Name = "igPivotView1";
			this.igPivotView1.Size = new System.Drawing.Size(413, 264);
			this.igPivotView1.Text = "igPivotView1";
			widgetFunction1.Name = "loadTheData";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.igPivotView1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// igPivotView
			// 
			this.Name = "igPivotView";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igPivotView igPivotView1;
	}
}
