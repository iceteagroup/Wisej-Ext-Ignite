namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igCombo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igCombo));
			this.igCombo1 = new Wisej.Web.Ext.Ignite.igCombo();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igCombo1);
			// 
			// igCombo1
			// 
			this.igCombo1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.igCombo1.Location = new System.Drawing.Point(69, 32);
			this.igCombo1.Name = "igCombo1";
			this.igCombo1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igCombo1.Options"))));
			this.igCombo1.Size = new System.Drawing.Size(314, 37);
			this.igCombo1.Text = "igCombo1";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Set Selected Index";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 63);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 42);
			this.numericUpDown1.TabIndex = 1;
			// 
			// igCombo
			// 
			this.Name = "igCombo";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igCombo igCombo1;
		private NumericUpDown numericUpDown1;
	}
}
