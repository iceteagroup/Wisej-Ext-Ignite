namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igTimePicker
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
			this.igTimePicker1 = new Wisej.Web.Ext.Ignite.igTimePicker();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igTimePicker1);
			// 
			// igTimePicker1
			// 
			this.igTimePicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igTimePicker1.Location = new System.Drawing.Point(86, 142);
			this.igTimePicker1.Name = "igTimePicker1";
			this.igTimePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"15:00\"}")));
			this.igTimePicker1.Size = new System.Drawing.Size(280, 29);
			this.igTimePicker1.Value = "15:00";
			// 
			// igTimePicker
			// 
			this.Name = "igTimePicker";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igTimePicker igTimePicker1;
	}
}
