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
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonSave = new Wisej.Web.Button();
			this.textBox1 = new Wisej.Web.TextBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.igSpreadsheet1 = new Wisej.Web.Ext.Ignite.igSpreadsheet();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Size = new System.Drawing.Size(250, 446);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 356);
			this.buttonUpdate.Size = new System.Drawing.Size(194, 52);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igSpreadsheet1);
			this.panel.Size = new System.Drawing.Size(455, 446);
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
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".xlsx";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 308);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 11;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 308);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 10;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBox1
			// 
			this.textBox1.Label.Text = "Active Cell";
			this.textBox1.Location = new System.Drawing.Point(28, 36);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(194, 42);
			this.textBox1.TabIndex = 12;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 105);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(194, 38);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Formula Bar Visible";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Zoom Level";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 170);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(194, 42);
			this.numericUpDown1.TabIndex = 14;
			this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "down",
            "right",
            "up",
            "left"});
			this.comboBox1.Label.Text = "Enter Key Navigation Direction";
			this.comboBox1.Location = new System.Drawing.Point(28, 239);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(194, 42);
			this.comboBox1.TabIndex = 15;
			this.comboBox1.Text = "down";
			// 
			// igSpreadsheet1
			// 
			this.igSpreadsheet1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igSpreadsheet1.Location = new System.Drawing.Point(18, 18);
			this.igSpreadsheet1.Name = "igSpreadsheet1";
			this.igSpreadsheet1.Size = new System.Drawing.Size(414, 406);
			this.igSpreadsheet1.TabIndex = 0;
			this.igSpreadsheet1.Text = "igSpreadsheet1";
			this.igSpreadsheet1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[0];
			this.igSpreadsheet1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.igSpreadsheet1_WidgetEvent);
			this.igSpreadsheet1.Appear += new System.EventHandler(this.igSpreadsheet1_Appear);
			// 
			// igSpreadsheet
			// 
			this.Name = "igSpreadsheet";
			this.Size = new System.Drawing.Size(864, 636);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igSpreadsheet igSpreadsheet1;
		private Upload buttonLoad;
		private Button buttonSave;
		private CheckBox checkBox1;
		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
		private ComboBox comboBox1;
	}
}
