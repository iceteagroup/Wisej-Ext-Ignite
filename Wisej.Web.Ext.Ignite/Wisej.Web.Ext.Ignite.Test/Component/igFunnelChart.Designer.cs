namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igFunnelChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igFunnelChart));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.igFunnelChart2 = new Wisej.Web.Ext.Ignite.igFunnelChart();
			this.igFunnelChart1 = new Wisej.Web.Ext.Ignite.igFunnelChart();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 464);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 383);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.igFunnelChart2);
			this.panel.Controls.Add(this.igFunnelChart1);
			this.panel.Size = new System.Drawing.Size(788, 464);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/funnel-chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://www.igniteui.com/help/api/2019.2/ui.igFunnelChart";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igfunnelchart-overview";
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Location = new System.Drawing.Point(157, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Funnel Chart";
			// 
			// label5
			// 
			this.label5.Anchor = Wisej.Web.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label5.Location = new System.Drawing.Point(514, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "Inverted Funnel Chart";
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "uniform",
            "weighted"});
			this.comboBox1.Label.Text = "Funnel Slice Display";
			this.comboBox1.Location = new System.Drawing.Point(28, 306);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 21;
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 96);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 22;
			this.checkBox2.Text = "Use Bezier Curve";
			// 
			// igFunnelChart2
			// 
			this.igFunnelChart2.Anchor = Wisej.Web.AnchorStyles.None;
			this.igFunnelChart2.Location = new System.Drawing.Point(395, 44);
			this.igFunnelChart2.Name = "igFunnelChart2";
			this.igFunnelChart2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igFunnelChart2.Options"))));
			this.igFunnelChart2.Size = new System.Drawing.Size(380, 402);
			this.igFunnelChart2.TabIndex = 2;
			this.igFunnelChart2.Text = "igFunnelChart2";
			widgetFunction1.Name = "clickSlice";
			widgetFunction1.Source = "App.MainView.showAlert(arguments[1][\"item\"]);";
			this.igFunnelChart2.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// igFunnelChart1
			// 
			this.igFunnelChart1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igFunnelChart1.Location = new System.Drawing.Point(11, 44);
			this.igFunnelChart1.Name = "igFunnelChart1";
			this.igFunnelChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igFunnelChart1.Options"))));
			this.igFunnelChart1.Size = new System.Drawing.Size(380, 402);
			this.igFunnelChart1.TabIndex = 3;
			this.igFunnelChart1.Text = "igFunnelChart1";
			widgetFunction2.Name = "clickSlice";
			widgetFunction2.Source = "App.MainView.showAlert(arguments[1][\"item\"]);";
			this.igFunnelChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
			this.igFunnelChart1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[0];
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 165);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 23;
			this.checkBox3.Text = "Inverted";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Transition Duration";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 24);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown1.TabIndex = 24;
			this.numericUpDown1.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.DecimalPlaces = 2;
			this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown2.Label.Text = "Bottom Edge Width";
			this.numericUpDown2.Location = new System.Drawing.Point(28, 234);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown2.TabIndex = 25;
			this.numericUpDown2.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
			// 
			// igFunnelChart
			// 
			this.Name = "igFunnelChart";
			this.Size = new System.Drawing.Size(1197, 654);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igFunnelChart igFunnelChart1;
		private Ignite.igFunnelChart igFunnelChart2;
		private Label label5;
		private Label label4;
		private CheckBox checkBox2;
		private ComboBox comboBox1;
		private CheckBox checkBox3;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
	}
}
