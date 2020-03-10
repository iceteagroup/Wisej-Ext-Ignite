namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igSpreadsheet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igSpreadsheet));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igSpreadsheet1 = new Wisej.Web.Ext.Ignite.igSpreadsheet();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonSave = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igSpreadsheet1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/spreadsheet/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://www.igniteui.com/help/api/2019.2/ui.igSpreadsheet";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igspreadsheet-overview";
			// 
			// igSpreadsheet1
			// 
			this.igSpreadsheet1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igSpreadsheet1.Location = new System.Drawing.Point(18, 18);
			this.igSpreadsheet1.Name = "igSpreadsheet1";
			this.igSpreadsheet1.Size = new System.Drawing.Size(413, 277);
			this.igSpreadsheet1.Text = "igSpreadsheet1";
			widgetFunction1.Name = "loadWorkbook";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			widgetFunction2.Name = "loadWorkbookFile";
			widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
			this.igSpreadsheet1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1,
        widgetFunction2};
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".xlsx";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 167);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 11;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 167);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 10;
			// 
			// igSpreadsheet
			// 
			this.Name = "igSpreadsheet";
			this.Load += new System.EventHandler(this.igSpreadsheet_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igSpreadsheet igSpreadsheet1;
		private Upload buttonLoad;
		private Button buttonSave;
	}
}
