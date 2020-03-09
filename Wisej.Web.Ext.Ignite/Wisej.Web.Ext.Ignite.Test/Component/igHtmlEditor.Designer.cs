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
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igHtmlEditor1);
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
	}
}
