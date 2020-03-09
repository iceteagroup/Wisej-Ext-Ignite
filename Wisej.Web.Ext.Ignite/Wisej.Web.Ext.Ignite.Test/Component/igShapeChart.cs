using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igShapeChart : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igShapeChart()
		{
			InitializeComponent();

			this.igShapeChart1.Widget.seriesPointerUp += new WidgetEventHandler(igShapeChart_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igShapeChart1.Options.title = this.comboBox1.SelectedItem;
			this.igShapeChart1.Options.chartType = this.comboBox1.SelectedItem;

			switch (this.comboBox1.SelectedItem)
			{
				case "highDensity":
					this.igShapeChart1.Call("SetDensityData");
					break;

				case "polygon":
				case "polyline":
					this.igShapeChart1.Call("SetShapeData");
					break;

				default:
					break;

			}

			this.igShapeChart1.Update();
		}

		private void igShapeChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
