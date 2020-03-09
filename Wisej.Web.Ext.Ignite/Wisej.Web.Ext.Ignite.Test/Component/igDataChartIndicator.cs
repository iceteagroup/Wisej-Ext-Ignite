using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igDataChartIndicator : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igDataChartIndicator()
		{
			InitializeComponent();

			this.igDataChart1.Widget.gridAreaRectChanged += new WidgetEventHandler(igDataChart_WidgetEvent);
			this.igDataChart1.Widget.seriesMouseLeftButtonUp += new WidgetEventHandler(igDataChart_WidgetEvent);
		}

		private void igDataChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
