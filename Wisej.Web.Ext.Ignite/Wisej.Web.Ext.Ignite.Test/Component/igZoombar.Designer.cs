namespace Wisej.Web.Ext.Ignite.Test.Component
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
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.panel1);
			this.panel.Controls.Add(this.igDataChart1);
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
			this.igDataChart1.Size = new System.Drawing.Size(383, 191);
			this.igDataChart1.TabIndex = 1;
			this.igDataChart1.Text = "igDataChart1";
			this.igDataChart1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[0];
			this.igDataChart1.Initialized += new System.EventHandler(this.igDataChart1_Initialized);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.panel1.Location = new System.Drawing.Point(35, 228);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(384, 57);
			this.panel1.TabIndex = 2;
			this.panel1.TabStop = true;
			// 
			// igZoombar
			// 
			this.Name = "igZoombar";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Ignite.igDataChart igDataChart1;
		private Panel panel1;
	}
}
