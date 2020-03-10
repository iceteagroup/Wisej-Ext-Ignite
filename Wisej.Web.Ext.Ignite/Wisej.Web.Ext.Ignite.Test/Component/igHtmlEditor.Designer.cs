namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igHtmlEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igHtmlEditor));
			this.igHtmlEditor1 = new Wisej.Web.Ext.Ignite.igHtmlEditor();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExportData = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExportData);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExportData, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igHtmlEditor1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/html-editor/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.ightmleditor";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/ightmleditor-ightmleditor";
			// 
			// igHtmlEditor1
			// 
			this.igHtmlEditor1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igHtmlEditor1.Location = new System.Drawing.Point(21, 26);
			this.igHtmlEditor1.Name = "igHtmlEditor1";
			this.igHtmlEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igHtmlEditor1.Options"))));
			this.igHtmlEditor1.Size = new System.Drawing.Size(411, 261);
			this.igHtmlEditor1.Text = "igHtmlEditor1";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".html";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 186);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 19;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExportData
			// 
			this.buttonExportData.Display = Wisej.Web.Display.Icon;
			this.buttonExportData.ImageSource = "icon-save";
			this.buttonExportData.Location = new System.Drawing.Point(76, 186);
			this.buttonExportData.Name = "buttonExportData";
			this.buttonExportData.Size = new System.Drawing.Size(42, 42);
			this.buttonExportData.TabIndex = 18;
			this.buttonExportData.Click += new System.EventHandler(this.buttonExportData_Click);
			// 
			// igHtmlEditor
			// 
			this.Name = "igHtmlEditor";
			this.Load += new System.EventHandler(this.igHtmlEditor_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igHtmlEditor igHtmlEditor1;
		private Upload buttonLoad;
		private Button buttonExportData;
	}
}
