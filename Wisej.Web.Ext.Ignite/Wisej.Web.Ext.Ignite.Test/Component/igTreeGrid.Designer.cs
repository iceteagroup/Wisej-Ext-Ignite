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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igTreeGrid));
			this.igTreeGrid1 = new Wisej.Web.Ext.Ignite.igTreeGrid();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExport = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExport);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igTreeGrid1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/tree-grid/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igTreeGrid";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igtreegrid-overview";
			// 
			// igTreeGrid1
			// 
			this.igTreeGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igTreeGrid1.AutoGenerateColumns = false;
			this.igTreeGrid1.Location = new System.Drawing.Point(22, 24);
			this.igTreeGrid1.Name = "igTreeGrid1";
			this.igTreeGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igTreeGrid1.Options"))));
			this.igTreeGrid1.Size = new System.Drawing.Size(409, 265);
			this.igTreeGrid1.Text = "igTreeGrid1";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 186);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 19;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExport
			// 
			this.buttonExport.Display = Wisej.Web.Display.Icon;
			this.buttonExport.ImageSource = "icon-save";
			this.buttonExport.Location = new System.Drawing.Point(76, 186);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(42, 42);
			this.buttonExport.TabIndex = 18;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
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
		private Upload buttonLoad;
		private Button buttonExport;
	}
}
