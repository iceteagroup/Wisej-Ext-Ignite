namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igDataChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igDataChart));
			this.igDataChart1 = new Wisej.Web.Ext.Ignite.igDataChart();
			this.textBox1 = new Wisej.Web.TextBox();
			this.textBox2 = new Wisej.Web.TextBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExportImage = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExportImage);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 373);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExportImage, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 292);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igDataChart1);
			this.panel.Size = new System.Drawing.Size(455, 373);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/data-chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igDataChart";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://www.igniteui.com/data-chart/overview";
			// 
			// igDataChart1
			// 
			this.igDataChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igDataChart1.Location = new System.Drawing.Point(25, 15);
			this.igDataChart1.Name = "igDataChart1";
			this.igDataChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDataChart1.Options"))));
			this.igDataChart1.Size = new System.Drawing.Size(403, 341);
			this.igDataChart1.Text = "igDataChart1";
			// 
			// textBox1
			// 
			this.textBox1.Label.Text = "Title";
			this.textBox1.Location = new System.Drawing.Point(28, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 42);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Label.Text = "Subtitle";
			this.textBox2.Location = new System.Drawing.Point(28, 101);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(195, 42);
			this.textBox2.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "purple",
            "black",
            "white"});
			this.comboBox1.Label.Text = "Title Color";
			this.comboBox1.Location = new System.Drawing.Point(28, 166);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 42);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "black";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 230);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 15;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExportImage
			// 
			this.buttonExportImage.Display = Wisej.Web.Display.Icon;
			this.buttonExportImage.ImageSource = "icon-save";
			this.buttonExportImage.Location = new System.Drawing.Point(76, 230);
			this.buttonExportImage.Name = "buttonExportImage";
			this.buttonExportImage.Size = new System.Drawing.Size(42, 42);
			this.buttonExportImage.TabIndex = 14;
			this.buttonExportImage.Click += new System.EventHandler(this.buttonExportImage_Click);
			// 
			// igDataChart
			// 
			this.Name = "igDataChart";
			this.Size = new System.Drawing.Size(864, 563);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igDataChart igDataChart1;
		private TextBox textBox2;
		private TextBox textBox1;
		private ComboBox comboBox1;
		private Upload buttonLoad;
		private Button buttonExportImage;
	}
}
