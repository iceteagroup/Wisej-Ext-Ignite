namespace Wisej.Web.Ext.Ignite.Test.Component
{
	partial class igScheduler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igScheduler));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igScheduler1 = new Wisej.Web.Ext.Ignite.igScheduler();
			this.buttonLoad = new Wisej.Web.Upload();
			this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.dateTimePicker2 = new Wisej.Web.DateTimePicker();
			this.button1 = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Size = new System.Drawing.Size(250, 438);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 357);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igScheduler1);
			this.panel.Size = new System.Drawing.Size(455, 438);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://www.igniteui.com/scheduler/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igScheduler";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "http://www.igniteui.com/help/igscheduler-overview";
			// 
			// igScheduler1
			// 
			this.igScheduler1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igScheduler1.Location = new System.Drawing.Point(21, 16);
			this.igScheduler1.Name = "igScheduler1";
			this.igScheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igScheduler1.Options"))));
			this.igScheduler1.Size = new System.Drawing.Size(412, 406);
			this.igScheduler1.Text = "igScheduler1";
			widgetFunction1.Name = "loadData";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.igScheduler1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			this.igScheduler1.Appear += new System.EventHandler(this.igScheduler1_Appear);
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 309);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 19;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Checked = false;
			this.dateTimePicker1.Label.Text = "From";
			this.dateTimePicker1.Location = new System.Drawing.Point(6, 35);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(183, 42);
			this.dateTimePicker1.TabIndex = 20;
			this.dateTimePicker1.Value = new System.DateTime(2020, 3, 10, 16, 0, 25, 25);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Location = new System.Drawing.Point(28, 31);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(195, 197);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.Text = "Export Appts. in Range";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Checked = false;
			this.dateTimePicker2.Label.Text = "To";
			this.dateTimePicker2.Location = new System.Drawing.Point(6, 101);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(183, 42);
			this.dateTimePicker2.TabIndex = 21;
			this.dateTimePicker2.Value = new System.DateTime(2020, 3, 10, 16, 0, 25, 25);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 164);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(183, 27);
			this.button1.TabIndex = 22;
			this.button1.Text = "Export";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// igScheduler
			// 
			this.Name = "igScheduler";
			this.Size = new System.Drawing.Size(864, 628);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igScheduler igScheduler1;
		private Upload buttonLoad;
		private GroupBox groupBox2;
		private Button button1;
		private DateTimePicker dateTimePicker2;
		private DateTimePicker dateTimePicker1;
	}
}
