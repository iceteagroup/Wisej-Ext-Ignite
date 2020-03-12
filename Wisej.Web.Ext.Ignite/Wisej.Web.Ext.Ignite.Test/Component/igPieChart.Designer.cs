namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igPieChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igPieChart));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igPieChart1 = new Wisej.Web.Ext.Ignite.igPieChart();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.button1 = new Wisej.Web.Button();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.textBox1 = new Wisej.Web.TextBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igPieChart1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/pie-chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igPieChart";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igpiechart";
			// 
			// igPieChart1
			// 
			this.igPieChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igPieChart1.Location = new System.Drawing.Point(18, 18);
			this.igPieChart1.Name = "igPieChart1";
			this.igPieChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igPieChart1.Options"))));
			this.igPieChart1.Size = new System.Drawing.Size(417, 277);
			this.igPieChart1.TabIndex = 0;
			this.igPieChart1.Text = "igPieChart1";
			widgetFunction1.Name = "AddItem";
			widgetFunction1.Source = "this.widget.addItem({\r\n    Label: \"Test\",\r\n    Budget: 50\r\n});";
			this.igPieChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(28, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(195, 182);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.Text = "Add Item";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 146);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(183, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Budget";
			this.numericUpDown1.Location = new System.Drawing.Point(6, 83);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(183, 42);
			this.numericUpDown1.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Label.Text = "Department";
			this.textBox1.Location = new System.Drawing.Point(6, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(183, 42);
			this.textBox1.TabIndex = 0;
			// 
			// igPieChart
			// 
			this.Name = "igPieChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igPieChart igPieChart1;
		private GroupBox groupBox2;
		private Button button1;
		private NumericUpDown numericUpDown1;
		private TextBox textBox1;
	}
}
