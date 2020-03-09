using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Test.Component
{
	public partial class igLinearGauge : Wisej.Web.Ext.Ignite.Test.Component.TestBase
	{
		public igLinearGauge()
		{
			InitializeComponent();

			this.igLinearGauge1.Widget.valueChanged += new WidgetEventHandler(igLinearGauge_WidgetEvent);
		}

		private void igLinearGauge_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
