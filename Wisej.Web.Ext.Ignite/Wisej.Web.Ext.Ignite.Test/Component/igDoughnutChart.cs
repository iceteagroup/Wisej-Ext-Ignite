using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igDoughnutChart : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igDoughnutChart()
		{
			InitializeComponent();

			this.igDoughnutChart1.Widget.sliceClick += new WidgetEventHandler(igDoughnutChart_WidgetEvent);
		}

		private void igDoughnutChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igDoughnutChart1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igDoughnutChart1.Update();
		}

		private async void buttonExportData_Click(object sender, EventArgs e)
		{
			var data = await this.igDoughnutChart1.Widget.getDataAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "myData.json");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDoughnutChart1.Update();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Inserts a new item to the beginning of the dataSource
			this.igDoughnutChart1.InsertItem(new { CountryName = this.textBox1.Text, Pop1990 = this.numericUpDown1.Value }, 1, 0);
		}
	}
}
