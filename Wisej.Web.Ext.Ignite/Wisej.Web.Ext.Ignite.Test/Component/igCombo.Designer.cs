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
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igCombo1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/combo/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igCombo";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igcombo-igcombo";
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
			this.numericUpDown1.Location = new System.Drawing.Point(28, 33);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 42);
			this.numericUpDown1.TabIndex = 1;
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "editable",
            "dropdown",
            "readonlylist",
            "readonly"});
			this.comboBox1.Label.Text = "Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 103);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 42);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "editable";
			// 
			// comboBox2
			// 
			this.comboBox2.Items.AddRange(new object[] {
            "auto",
            "bottom",
            "top"});
			this.comboBox2.Label.Text = "Drop Down Orientation";
			this.comboBox2.Location = new System.Drawing.Point(28, 173);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 42);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.Text = "auto";
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
		private ComboBox comboBox1;
		private ComboBox comboBox2;
	}
}
