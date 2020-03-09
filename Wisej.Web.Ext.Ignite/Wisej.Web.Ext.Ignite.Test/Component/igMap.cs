using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igMap : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igMap()
		{
			InitializeComponent();

			this.igMap1.Widget.seriesMouseLeftButtonUp += new WidgetEventHandler(igMap_WidgetEvent);
		}

		private void igMap_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
