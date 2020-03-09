using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igDataChart : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igDataChart()
		{
			InitializeComponent();

			this.igDataChart1.Widget.gridAreaRectChanged += new WidgetEventHandler(igDataChart_WidgetEvent);
			this.igDataChart1.Widget.seriesMouseLeftButtonUp += new WidgetEventHandler(igDataChart_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Length > 0) { this.igDataChart1.Options.title = textBox1.Text; }
			if (this.textBox2.Text.Length > 0) { this.igDataChart1.Options.subtitle = textBox2.Text; }
			this.igDataChart1.Options.titleTextColor = comboBox1.SelectedItem;

			this.igDataChart1.Update();
		}

		private void igDataChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igDataChart1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igDataChart1.Update();
		}

		private void buttonExportImage_Click(object sender, EventArgs e)
		{
			this.igDataChart1.Call("exportImageData");
		}
	}
}
