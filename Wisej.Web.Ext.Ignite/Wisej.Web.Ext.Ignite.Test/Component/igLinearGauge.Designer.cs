namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igLinearGauge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igLinearGauge));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction4 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction5 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction6 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igLinearGauge1 = new Wisej.Web.Ext.Ignite.igLinearGauge();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.label6 = new Wisej.Web.Label();
			this.label7 = new Wisej.Web.Label();
			this.label8 = new Wisej.Web.Label();
			this.igLinearGauge2 = new Wisej.Web.Ext.Ignite.igLinearGauge();
			this.igLinearGauge3 = new Wisej.Web.Ext.Ignite.igLinearGauge();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igLinearGauge3);
			this.panel.Controls.Add(this.igLinearGauge2);
			this.panel.Controls.Add(this.label8);
			this.panel.Controls.Add(this.label7);
			this.panel.Controls.Add(this.label6);
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.igLinearGauge1);
			this.panel.Size = new System.Drawing.Size(597, 458);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/linear-gauge/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igLinearGauge";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/iglineargauge-overview";
			// 
			// igLinearGauge1
			// 
			this.igLinearGauge1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.igLinearGauge1.IsNeedleDraggingEnabled = true;
			this.igLinearGauge1.Location = new System.Drawing.Point(21, 72);
			this.igLinearGauge1.Name = "igLinearGauge1";
			this.igLinearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igLinearGauge1.Options"))));
			this.igLinearGauge1.Size = new System.Drawing.Size(552, 60);
			this.igLinearGauge1.TabIndex = 10;
			this.igLinearGauge1.Value = 40D;
			widgetFunction4.Name = "formatLabel";
			widgetFunction4.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"%\";";
			this.igLinearGauge1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction4};
			// 
			// label4
			// 
			this.label4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Location = new System.Drawing.Point(23, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Healthy Eating";
			// 
			// label5
			// 
			this.label5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Fat";
			// 
			// label6
			// 
			this.label6.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Carbohydrates";
			// 
			// label7
			// 
			this.label7.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 307);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 16);
			this.label7.TabIndex = 4;
			this.label7.Text = "Protein";
			// 
			// label8
			// 
			this.label8.Anchor = Wisej.Web.AnchorStyles.None;
			this.label8.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label8.Location = new System.Drawing.Point(21, 408);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(552, 34);
			this.label8.TabIndex = 5;
			this.label8.Text = "Total calories intake ratio between fat, carbohydrates and protein, where middle " +
    "ranges are healthy ratios and the target values - ideally set goals.";
			// 
			// igLinearGauge2
			// 
			this.igLinearGauge2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.igLinearGauge2.Location = new System.Drawing.Point(21, 198);
			this.igLinearGauge2.Name = "igLinearGauge2";
			this.igLinearGauge2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igLinearGauge2.Options"))));
			this.igLinearGauge2.Size = new System.Drawing.Size(552, 60);
			this.igLinearGauge2.TabIndex = 7;
			this.igLinearGauge2.Value = 35D;
			widgetFunction5.Name = "formatLabel";
			widgetFunction5.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"%\";";
			this.igLinearGauge2.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction5};
			// 
			// igLinearGauge3
			// 
			this.igLinearGauge3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.igLinearGauge3.Location = new System.Drawing.Point(21, 329);
			this.igLinearGauge3.Name = "igLinearGauge3";
			this.igLinearGauge3.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igLinearGauge3.Options"))));
			this.igLinearGauge3.Size = new System.Drawing.Size(552, 60);
			this.igLinearGauge3.TabIndex = 9;
			this.igLinearGauge3.Value = 25D;
			widgetFunction6.Name = "formatLabel";
			widgetFunction6.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"%\";";
			this.igLinearGauge3.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction6};
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 48);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 42);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "custom",
            "rectangle",
            "triangle",
            "needle",
            "trapezoid"});
			this.comboBox1.Label.Text = "Needle Shape";
			this.comboBox1.Location = new System.Drawing.Point(28, 138);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 42);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "needle";
			// 
			// igLinearGauge
			// 
			this.Name = "igLinearGauge";
			this.Size = new System.Drawing.Size(1006, 648);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igLinearGauge igLinearGauge1;
		private Ignite.igLinearGauge igLinearGauge3;
		private Ignite.igLinearGauge igLinearGauge2;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private NumericUpDown numericUpDown1;
		private ComboBox comboBox1;
	}
}
