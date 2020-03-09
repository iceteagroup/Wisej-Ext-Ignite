using System;
using System.IO;
using System.Text;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igCategoryChart : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igCategoryChart()
		{
			InitializeComponent();
		}

		private void igCategoryChart_Load(object sender, EventArgs e)
		{
			this.comboBox1.DataSource = Enum.GetNames(typeof(Ignite.igCategoryChart.ChartTypes));
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igCategoryChart1.ChartType = (Ignite.igCategoryChart.ChartTypes)Enum.Parse(typeof(Ignite.igCategoryChart.ChartTypes), ((string)this.comboBox1.SelectedItem));

			this.igCategoryChart1.Update();
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igCategoryChart1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igCategoryChart1.Update();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.igCategoryChart1.Widget.getDataAsync();

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
	}
}
